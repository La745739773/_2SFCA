namespace _2SFCA可达性计算
{
    partial class _2SFCAForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Population_threshold_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Attenuation_functionCombo = new System.Windows.Forms.ComboBox();
            this.Comfirm_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Load_gridPop = new System.Windows.Forms.Button();
            this.GridPopu_FilenameTxt = new System.Windows.Forms.TextBox();
            this.OD_TIME_TEXT = new System.Windows.Forms.TextBox();
            this.Load_ODTIME_BTN = new System.Windows.Forms.Button();
            this.PublicFac_fileName = new System.Windows.Forms.TextBox();
            this.Load_publicFac_btn = new System.Windows.Forms.Button();
            this.radioBtn_ClosetFac = new System.Windows.Forms.RadioButton();
            this.radioBtn_inputTime = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_closetFaculity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间阈值：";
            // 
            // Population_threshold_Textbox
            // 
            this.Population_threshold_Textbox.Location = new System.Drawing.Point(122, 90);
            this.Population_threshold_Textbox.Name = "Population_threshold_Textbox";
            this.Population_threshold_Textbox.Size = new System.Drawing.Size(100, 21);
            this.Population_threshold_Textbox.TabIndex = 1;
            this.Population_threshold_Textbox.Text = "90";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "衰减函数选择";
            // 
            // Attenuation_functionCombo
            // 
            this.Attenuation_functionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Attenuation_functionCombo.FormattingEnabled = true;
            this.Attenuation_functionCombo.Location = new System.Drawing.Point(126, 28);
            this.Attenuation_functionCombo.Name = "Attenuation_functionCombo";
            this.Attenuation_functionCombo.Size = new System.Drawing.Size(121, 20);
            this.Attenuation_functionCombo.TabIndex = 10;
            // 
            // Comfirm_btn
            // 
            this.Comfirm_btn.Location = new System.Drawing.Point(168, 263);
            this.Comfirm_btn.Name = "Comfirm_btn";
            this.Comfirm_btn.Size = new System.Drawing.Size(75, 23);
            this.Comfirm_btn.TabIndex = 3;
            this.Comfirm_btn.Text = "确定";
            this.Comfirm_btn.UseVisualStyleBackColor = true;
            this.Comfirm_btn.Click += new System.EventHandler(this.Comfirm_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(253, 263);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 4;
            this.Cancel_btn.Text = "取消";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Load_gridPop
            // 
            this.Load_gridPop.Location = new System.Drawing.Point(12, 133);
            this.Load_gridPop.Name = "Load_gridPop";
            this.Load_gridPop.Size = new System.Drawing.Size(136, 23);
            this.Load_gridPop.TabIndex = 3;
            this.Load_gridPop.Text = "加载格网人口文件";
            this.Load_gridPop.UseVisualStyleBackColor = true;
            this.Load_gridPop.Click += new System.EventHandler(this.Load_gridPop_Click);
            // 
            // GridPopu_FilenameTxt
            // 
            this.GridPopu_FilenameTxt.Location = new System.Drawing.Point(168, 133);
            this.GridPopu_FilenameTxt.Name = "GridPopu_FilenameTxt";
            this.GridPopu_FilenameTxt.Size = new System.Drawing.Size(100, 21);
            this.GridPopu_FilenameTxt.TabIndex = 1;
            // 
            // OD_TIME_TEXT
            // 
            this.OD_TIME_TEXT.Location = new System.Drawing.Point(168, 216);
            this.OD_TIME_TEXT.Name = "OD_TIME_TEXT";
            this.OD_TIME_TEXT.Size = new System.Drawing.Size(100, 21);
            this.OD_TIME_TEXT.TabIndex = 1;
            // 
            // Load_ODTIME_BTN
            // 
            this.Load_ODTIME_BTN.Location = new System.Drawing.Point(12, 216);
            this.Load_ODTIME_BTN.Name = "Load_ODTIME_BTN";
            this.Load_ODTIME_BTN.Size = new System.Drawing.Size(136, 23);
            this.Load_ODTIME_BTN.TabIndex = 3;
            this.Load_ODTIME_BTN.Text = "加载OD交通时间";
            this.Load_ODTIME_BTN.UseVisualStyleBackColor = true;
            this.Load_ODTIME_BTN.Click += new System.EventHandler(this.Load_ODTIME_BTN_Click);
            // 
            // PublicFac_fileName
            // 
            this.PublicFac_fileName.Location = new System.Drawing.Point(168, 175);
            this.PublicFac_fileName.Name = "PublicFac_fileName";
            this.PublicFac_fileName.Size = new System.Drawing.Size(100, 21);
            this.PublicFac_fileName.TabIndex = 1;
            // 
            // Load_publicFac_btn
            // 
            this.Load_publicFac_btn.Location = new System.Drawing.Point(12, 175);
            this.Load_publicFac_btn.Name = "Load_publicFac_btn";
            this.Load_publicFac_btn.Size = new System.Drawing.Size(136, 23);
            this.Load_publicFac_btn.TabIndex = 3;
            this.Load_publicFac_btn.Text = "加载公共服务设施";
            this.Load_publicFac_btn.UseVisualStyleBackColor = true;
            this.Load_publicFac_btn.Click += new System.EventHandler(this.Load_publicFac_btn_Click);
            // 
            // radioBtn_ClosetFac
            // 
            this.radioBtn_ClosetFac.AutoSize = true;
            this.radioBtn_ClosetFac.Location = new System.Drawing.Point(19, 57);
            this.radioBtn_ClosetFac.Name = "radioBtn_ClosetFac";
            this.radioBtn_ClosetFac.Size = new System.Drawing.Size(131, 16);
            this.radioBtn_ClosetFac.TabIndex = 11;
            this.radioBtn_ClosetFac.TabStop = true;
            this.radioBtn_ClosetFac.Text = "最邻近占比计算阈值";
            this.radioBtn_ClosetFac.UseVisualStyleBackColor = true;
            this.radioBtn_ClosetFac.CheckedChanged += new System.EventHandler(this.radioBtn_ClosetFac_CheckedChanged);
            // 
            // radioBtn_inputTime
            // 
            this.radioBtn_inputTime.AutoSize = true;
            this.radioBtn_inputTime.Location = new System.Drawing.Point(168, 57);
            this.radioBtn_inputTime.Name = "radioBtn_inputTime";
            this.radioBtn_inputTime.Size = new System.Drawing.Size(155, 16);
            this.radioBtn_inputTime.TabIndex = 11;
            this.radioBtn_inputTime.TabStop = true;
            this.radioBtn_inputTime.Text = "输入时间计算阈值(分钟)";
            this.radioBtn_inputTime.UseVisualStyleBackColor = true;
            this.radioBtn_inputTime.CheckedChanged += new System.EventHandler(this.radioBtn_inputTime_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export_closetFaculity});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // Export_closetFaculity
            // 
            this.Export_closetFaculity.Name = "Export_closetFaculity";
            this.Export_closetFaculity.Size = new System.Drawing.Size(160, 22);
            this.Export_closetFaculity.Text = "导出最邻近结果";
            this.Export_closetFaculity.Click += new System.EventHandler(this.Export_closetFaculity_Click);
            // 
            // _2SFCAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 307);
            this.Controls.Add(this.radioBtn_inputTime);
            this.Controls.Add(this.radioBtn_ClosetFac);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Load_publicFac_btn);
            this.Controls.Add(this.Load_ODTIME_BTN);
            this.Controls.Add(this.Load_gridPop);
            this.Controls.Add(this.Comfirm_btn);
            this.Controls.Add(this.Attenuation_functionCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PublicFac_fileName);
            this.Controls.Add(this.OD_TIME_TEXT);
            this.Controls.Add(this.GridPopu_FilenameTxt);
            this.Controls.Add(this.Population_threshold_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_2SFCAForm";
            this.Text = "_2SFCA面板";
            this.Load += new System.EventHandler(this._2SFCAForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Population_threshold_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Attenuation_functionCombo;
        private System.Windows.Forms.Button Comfirm_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Load_gridPop;
        private System.Windows.Forms.TextBox GridPopu_FilenameTxt;
        private System.Windows.Forms.TextBox OD_TIME_TEXT;
        private System.Windows.Forms.Button Load_ODTIME_BTN;
        private System.Windows.Forms.TextBox PublicFac_fileName;
        private System.Windows.Forms.Button Load_publicFac_btn;
        private System.Windows.Forms.RadioButton radioBtn_ClosetFac;
        private System.Windows.Forms.RadioButton radioBtn_inputTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Export_closetFaculity;
    }
}