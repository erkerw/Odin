namespace Odin
{
    partial class MainForm
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
            this.MainFormStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadPanel = new System.Windows.Forms.Panel();
            this.MainFormStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormStrip
            // 
            this.MainFormStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.类型ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.连接ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.MainFormStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormStrip.Name = "MainFormStrip";
            this.MainFormStrip.Size = new System.Drawing.Size(1342, 28);
            this.MainFormStrip.TabIndex = 0;
            this.MainFormStrip.Text = "MainFormStrip";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 类型ToolStripMenuItem
            // 
            this.类型ToolStripMenuItem.Name = "类型ToolStripMenuItem";
            this.类型ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.类型ToolStripMenuItem.Text = "类型";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 连接ToolStripMenuItem
            // 
            this.连接ToolStripMenuItem.Name = "连接ToolStripMenuItem";
            this.连接ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.连接ToolStripMenuItem.Text = "连接";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // ReloadPanel
            // 
            this.ReloadPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReloadPanel.Location = new System.Drawing.Point(0, 31);
            this.ReloadPanel.Name = "ReloadPanel";
            this.ReloadPanel.Size = new System.Drawing.Size(1342, 691);
            this.ReloadPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1342, 721);
            this.Controls.Add(this.ReloadPanel);
            this.Controls.Add(this.MainFormStrip);
            this.MainMenuStrip = this.MainFormStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainFormStrip.ResumeLayout(false);
            this.MainFormStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Panel ReloadPanel;
    }
}

