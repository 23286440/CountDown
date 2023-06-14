namespace 倒计时程序
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.文本显示 = new System.Windows.Forms.Label();
            this.循环触发器 = new System.Windows.Forms.Timer(this.components);
            this.菜单 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启用开机启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单.SuspendLayout();
            this.SuspendLayout();
            // 
            // 文本显示
            // 
            this.文本显示.AutoSize = true;
            this.文本显示.ContextMenuStrip = this.菜单;
            this.文本显示.Font = new System.Drawing.Font("隶书", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文本显示.Location = new System.Drawing.Point(0, 0);
            this.文本显示.Name = "文本显示";
            this.文本显示.Size = new System.Drawing.Size(955, 64);
            this.文本显示.TabIndex = 0;
            this.文本显示.Text = "右击显示菜单|倒计时 by 侏罗纪";
            this.文本显示.MouseDown += new System.Windows.Forms.MouseEventHandler(this.文本显示_MouseDown);
            this.文本显示.MouseMove += new System.Windows.Forms.MouseEventHandler(this.文本显示_MouseMove);
            this.文本显示.MouseUp += new System.Windows.Forms.MouseEventHandler(this.文本显示_MouseUp);
            // 
            // 循环触发器
            // 
            this.循环触发器.Enabled = true;
            this.循环触发器.Interval = 2000;
            this.循环触发器.Tick += new System.EventHandler(this.循环触发器_Tick);
            // 
            // 菜单
            // 
            this.菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭ToolStripMenuItem,
            this.启用开机启动ToolStripMenuItem});
            this.菜单.Name = "菜单";
            this.菜单.Size = new System.Drawing.Size(149, 48);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 启用开机启动ToolStripMenuItem
            // 
            this.启用开机启动ToolStripMenuItem.Name = "启用开机启动ToolStripMenuItem";
            this.启用开机启动ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.启用开机启动ToolStripMenuItem.Text = "启用开机启动";
            this.启用开机启动ToolStripMenuItem.Click += new System.EventHandler(this.启用开机自启ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1011, 107);
            this.Controls.Add(this.文本显示);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "倒计时";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.菜单.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 文本显示;
        private System.Windows.Forms.Timer 循环触发器;
        private System.Windows.Forms.ContextMenuStrip 菜单;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启用开机启动ToolStripMenuItem;
    }
}

