namespace PicTools
{
    partial class 动画帧格式化工具
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leftup = new System.Windows.Forms.ToolStripMenuItem();
            this.leftdown = new System.Windows.Forms.ToolStripMenuItem();
            this.rightup = new System.Windows.Forms.ToolStripMenuItem();
            this.rightdown = new System.Windows.Forms.ToolStripMenuItem();
            this.center = new System.Windows.Forms.ToolStripMenuItem();
            this.centerup = new System.Windows.Forms.ToolStripMenuItem();
            this.centerdown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(39, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(39, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 100);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请浏览保存路径:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftup,
            this.leftdown,
            this.centerup,
            this.center,
            this.centerdown,
            this.rightup,
            this.rightdown});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "对齐方式";
            // 
            // leftup
            // 
            this.leftup.Name = "leftup";
            this.leftup.Size = new System.Drawing.Size(152, 22);
            this.leftup.Text = "左上对齐";
            this.leftup.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // leftdown
            // 
            this.leftdown.Name = "leftdown";
            this.leftdown.Size = new System.Drawing.Size(152, 22);
            this.leftdown.Text = "左下对齐";
            this.leftdown.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // rightup
            // 
            this.rightup.Name = "rightup";
            this.rightup.Size = new System.Drawing.Size(152, 22);
            this.rightup.Text = "右上对齐";
            this.rightup.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // rightdown
            // 
            this.rightdown.Name = "rightdown";
            this.rightdown.Size = new System.Drawing.Size(152, 22);
            this.rightdown.Text = "右下对齐";
            this.rightdown.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // center
            // 
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(152, 22);
            this.center.Text = "中心对齐";
            this.center.Click += new System.EventHandler(this.center_Click);
            // 
            // centerup
            // 
            this.centerup.Name = "centerup";
            this.centerup.Size = new System.Drawing.Size(152, 22);
            this.centerup.Text = "中上对齐";
            this.centerup.Click += new System.EventHandler(this.centerup_Click);
            // 
            // centerdown
            // 
            this.centerdown.Name = "centerdown";
            this.centerdown.Size = new System.Drawing.Size(152, 22);
            this.centerdown.Text = "中下对齐";
            this.centerdown.Click += new System.EventHandler(this.centerdown_Click);
            // 
            // 动画帧格式化工具
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "动画帧格式化工具";
            this.Text = "动画帧格式化工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leftup;
        private System.Windows.Forms.ToolStripMenuItem leftdown;
        private System.Windows.Forms.ToolStripMenuItem rightup;
        private System.Windows.Forms.ToolStripMenuItem rightdown;
        private System.Windows.Forms.ToolStripMenuItem center;
        private System.Windows.Forms.ToolStripMenuItem centerup;
        private System.Windows.Forms.ToolStripMenuItem centerdown;
    }
}

