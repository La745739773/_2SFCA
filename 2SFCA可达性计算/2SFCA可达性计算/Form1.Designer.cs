namespace _2SFCA可达性计算
{
    partial class Main_frame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.可达性计算模型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwosFCA_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.可达性计算模型ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 可达性计算模型ToolStripMenuItem
            // 
            this.可达性计算模型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TwosFCA_menuItem});
            this.可达性计算模型ToolStripMenuItem.Name = "可达性计算模型ToolStripMenuItem";
            this.可达性计算模型ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.可达性计算模型ToolStripMenuItem.Text = "可达性计算模型";
            // 
            // TwosFCA_menuItem
            // 
            this.TwosFCA_menuItem.Name = "TwosFCA_menuItem";
            this.TwosFCA_menuItem.Size = new System.Drawing.Size(152, 22);
            this.TwosFCA_menuItem.Text = "2SFCA";
            this.TwosFCA_menuItem.Click += new System.EventHandler(this.TwosFCA_menuItem_Click);
            // 
            // Main_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 24);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_frame";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 可达性计算模型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwosFCA_menuItem;
    }
}

