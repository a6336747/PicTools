using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicTools
{
    public partial class 动画帧格式化工具 : Form
    {
        private string[] fileNames;
        List<Image> orginImgs = new List<Image>();
        List<Image> currentImgs = new List<Image>();
        public 动画帧格式化工具()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        private void Execute(string[] paths)
        {
            orginImgs.Clear();
            currentImgs.Clear();
            List<Image> orginImgsPre = new List<Image>();
            List<Image> currentImgsPre = new List<Image>();
            foreach (var path in paths)
            {
                try
                {
                    var img = Image.FromFile(path);
                    orginImgs.Add(img);

                    var imgPre = Image.FromFile(path);
                    var gr = Graphics.FromImage(imgPre);
                    gr.DrawRectangle(Pens.Aqua, new Rectangle(0, 0, imgPre.Width - 1, imgPre.Height - 1));
                    orginImgsPre.Add(imgPre);
                    gr.Dispose();
                }
                catch (Exception e)
                {

                }
            }
            //获取集合最大宽高
            var maxHeight = orginImgs.Max(d => d.Size.Height);
            var maxWidth = orginImgs.Max(d => d.Size.Width);

            //渲染预览图到pictureBox集合里
            var count = 0;
            var orginPoint = new Point(17, 16);
            foreach (var orginImgsPr in orginImgsPre)
            {
                var pic = new PictureBox();
                pic.Image = orginImgsPr;
                orginPoint = new Point(orginPoint.X + (count == 0 ? 0 : orginImgsPre[count - 1].Size.Width), orginPoint.Y);
                pic.Location = orginPoint;
                pic.SizeMode = PictureBoxSizeMode.AutoSize;
                pic.Show();
                panel1.Controls.Add(pic);
                count++;
            }

            count = 0;//初始化count
            //批量设定图片宽高
            foreach (var orginImg in orginImgs)
            {
                var bmp = new Bitmap(maxWidth, maxHeight);
                var gr = Graphics.FromImage(bmp);
                //导出图
                gr.DrawImage(orginImg, (maxWidth / 2) - (orginImg.Size.Width / 2), (maxHeight / 2) - (orginImg.Size.Height / 2));
                currentImgs.Add(bmp);
                gr.Dispose();

                var bmp1 = new Bitmap(maxWidth, maxHeight);
                var gr1 = Graphics.FromImage(bmp1);
                //预览图
                gr1.DrawImage(orginImg, (maxWidth/2)-(orginImg.Size.Width/2), (maxHeight / 2) - (orginImg.Size.Height / 2));
                gr1.DrawRectangle(Pens.Aqua, new Rectangle(0, 0, bmp1.Width - 1, bmp1.Height - 1));
                currentImgsPre.Add(bmp1);
                gr1.Dispose();
            }

            var currentPoint = new Point(17, 16);
            foreach (var currentImgPre in currentImgsPre)
            {
                var pic = new PictureBox();
                pic.Image = currentImgPre;
                currentPoint = new Point(currentPoint.X + (count == 0 ? 0 : currentImgsPre[count - 1].Size.Width), currentPoint.Y);
                pic.Location = currentPoint;
                pic.SizeMode = PictureBoxSizeMode.AutoSize;
                pic.Show();
                panel2.Controls.Add(pic);
                count++;
            }

            
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else e.Effect = DragDropEffects.None;
        }
        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            //获取第一个文件名            
            fileNames = (e.Data.GetData(DataFormats.FileDrop, false) as String[]);
            Execute(fileNames);
            try
            {
                //                this.pictureBox1.ImageLocation = fileName;
            }
            catch (Exception)
            {
                MessageBox.Show("文件格式不对");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择要保存的路径";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                
            }
            label1.Text=dialog.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label1.Text)||label1.Text== @"请浏览保存路径:")
            {
                MessageBox.Show(this, "文件夹路径不能为空", "提示");
            }
            else
            {
                if (currentImgs.Any())
                {
                    int i = 0;
                    foreach (var currentImg in currentImgs)
                    {
                        string path = label1.Text + @"/" +i.ToString() +@".png";
                        currentImg.Save(path,ImageFormat.Png);
                        i++;
                    }
                    MessageBox.Show(this, "处理成功!", "提示");
                }
                else
                {
                    MessageBox.Show(this, "请拖入要处理的图片集", "提示");
                }
            }
        }
    }
}

