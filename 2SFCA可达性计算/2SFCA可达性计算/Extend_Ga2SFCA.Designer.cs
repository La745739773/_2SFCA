namespace _2SFCA可达性计算
{
    partial class Extend_Ga2SFCA
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
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Load_publicFac_btn = new System.Windows.Forms.Button();
            this.Load_ODTIME_BTN = new System.Windows.Forms.Button();
            this.Load_gridPop = new System.Windows.Forms.Button();
            this.Comfirm_btn = new System.Windows.Forms.Button();
            this.PublicFac_fileName = new System.Windows.Forms.TextBox();
            this.OD_TIME_TEXT = new System.Windows.Forms.TextBox();
            this.GridPopu_FilenameTxt = new System.Windows.Forms.TextBox();
            this.Time_threshold_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Average_timeTextbox = new System.Windows.Forms.TextBox();
            this.damping_function_DownValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Calculate_kValue = new System.Windows.Forms.Button();
            this.KValue_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Population_threshold_Textbox = new System.Windows.Forms.TextBox();
            this.CalculateKvalue_inputParam_label = new System.Windows.Forms.Label();
            this.radioBtn_inputTime = new System.Windows.Forms.RadioButton();
            this.radioBtn_ClosetFac = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(319, 261);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 12;
            this.Cancel_btn.Text = "取消";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Load_publicFac_btn
            // 
            this.Load_publicFac_btn.Location = new System.Drawing.Point(22, 144);
            this.Load_publicFac_btn.Name = "Load_publicFac_btn";
            this.Load_publicFac_btn.Size = new System.Drawing.Size(136, 23);
            this.Load_publicFac_btn.TabIndex = 8;
            this.Load_publicFac_btn.Text = "加载公共服务设施";
            this.Load_publicFac_btn.UseVisualStyleBackColor = true;
            this.Load_publicFac_btn.Click += new System.EventHandler(this.Load_publicFac_btn_Click);
            // 
            // Load_ODTIME_BTN
            // 
            this.Load_ODTIME_BTN.Location = new System.Drawing.Point(22, 183);
            this.Load_ODTIME_BTN.Name = "Load_ODTIME_BTN";
            this.Load_ODTIME_BTN.Size = new System.Drawing.Size(136, 23);
            this.Load_ODTIME_BTN.TabIndex = 9;
            this.Load_ODTIME_BTN.Text = "加载OD交通时间";
            this.Load_ODTIME_BTN.UseVisualStyleBackColor = true;
            this.Load_ODTIME_BTN.Click += new System.EventHandler(this.Load_ODTIME_BTN_Click);
            // 
            // Load_gridPop
            // 
            this.Load_gridPop.Location = new System.Drawing.Point(22, 100);
            this.Load_gridPop.Name = "Load_gridPop";
            this.Load_gridPop.Size = new System.Drawing.Size(136, 23);
            this.Load_gridPop.TabIndex = 10;
            this.Load_gridPop.Text = "加载格网人口文件";
            this.Load_gridPop.UseVisualStyleBackColor = true;
            this.Load_gridPop.Click += new System.EventHandler(this.Load_gridPop_Click);
            // 
            // Comfirm_btn
            // 
            this.Comfirm_btn.Location = new System.Drawing.Point(185, 261);
            this.Comfirm_btn.Name = "Comfirm_btn";
            this.Comfirm_btn.Size = new System.Drawing.Size(75, 23);
            this.Comfirm_btn.TabIndex = 11;
            this.Comfirm_btn.Text = "确定";
            this.Comfirm_btn.UseVisualStyleBackColor = true;
            this.Comfirm_btn.Click += new System.EventHandler(this.Comfirm_btn_Click);
            // 
            // PublicFac_fileName
            // 
            this.PublicFac_fileName.Location = new System.Drawing.Point(185, 144);
            this.PublicFac_fileName.Name = "PublicFac_fileName";
            this.PublicFac_fileName.Size = new System.Drawing.Size(100, 21);
            this.PublicFac_fileName.TabIndex = 5;
            // 
            // OD_TIME_TEXT
            // 
            this.OD_TIME_TEXT.Location = new System.Drawing.Point(185, 185);
            this.OD_TIME_TEXT.Name = "OD_TIME_TEXT";
            this.OD_TIME_TEXT.Size = new System.Drawing.Size(100, 21);
            this.OD_TIME_TEXT.TabIndex = 6;
            // 
            // GridPopu_FilenameTxt
            // 
            this.GridPopu_FilenameTxt.Location = new System.Drawing.Point(185, 102);
            this.GridPopu_FilenameTxt.Name = "GridPopu_FilenameTxt";
            this.GridPopu_FilenameTxt.Size = new System.Drawing.Size(100, 21);
            this.GridPopu_FilenameTxt.TabIndex = 7;
            // 
            // Time_threshold_Textbox
            // 
            this.Time_threshold_Textbox.Location = new System.Drawing.Point(182, 62);
            this.Time_threshold_Textbox.Name = "Time_threshold_Textbox";
            this.Time_threshold_Textbox.Size = new System.Drawing.Size(100, 21);
            this.Time_threshold_Textbox.TabIndex = 14;
            this.Time_threshold_Textbox.Text = "1";
            this.Time_threshold_Textbox.TextChanged += new System.EventHandler(this.AverageTime_threshold_Textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "平均时间倍数(小数)：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "衰减函数：";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(98, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "f(d) = exp((-(d-dmin)^2 )) / k)";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "平均出行时间(min):";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Average_timeTextbox
            // 
            this.Average_timeTextbox.Location = new System.Drawing.Point(185, 222);
            this.Average_timeTextbox.Name = "Average_timeTextbox";
            this.Average_timeTextbox.ReadOnly = true;
            this.Average_timeTextbox.Size = new System.Drawing.Size(100, 21);
            this.Average_timeTextbox.TabIndex = 6;
            this.Average_timeTextbox.TextChanged += new System.EventHandler(this.Average_timeTextbox_TextChanged);
            // 
            // damping_function_DownValue
            // 
            this.damping_function_DownValue.Location = new System.Drawing.Point(163, 38);
            this.damping_function_DownValue.Name = "damping_function_DownValue";
            this.damping_function_DownValue.Size = new System.Drawing.Size(100, 21);
            this.damping_function_DownValue.TabIndex = 6;
            this.damping_function_DownValue.Text = "0.05";
            this.damping_function_DownValue.TextChanged += new System.EventHandler(this.Average_timeTextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(24, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "衰减函数值下限:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calculate_kValue
            // 
            this.Calculate_kValue.Location = new System.Drawing.Point(69, 153);
            this.Calculate_kValue.Name = "Calculate_kValue";
            this.Calculate_kValue.Size = new System.Drawing.Size(75, 23);
            this.Calculate_kValue.TabIndex = 11;
            this.Calculate_kValue.Text = "计算k值";
            this.Calculate_kValue.UseVisualStyleBackColor = true;
            this.Calculate_kValue.Click += new System.EventHandler(this.Calculate_kValue_Click);
            // 
            // KValue_textbox
            // 
            this.KValue_textbox.Location = new System.Drawing.Point(163, 155);
            this.KValue_textbox.Name = "KValue_textbox";
            this.KValue_textbox.ReadOnly = true;
            this.KValue_textbox.Size = new System.Drawing.Size(100, 21);
            this.KValue_textbox.TabIndex = 6;
            this.KValue_textbox.TextChanged += new System.EventHandler(this.Average_timeTextbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Population_threshold_Textbox);
            this.panel1.Controls.Add(this.CalculateKvalue_inputParam_label);
            this.panel1.Controls.Add(this.radioBtn_inputTime);
            this.panel1.Controls.Add(this.radioBtn_ClosetFac);
            this.panel1.Controls.Add(this.damping_function_DownValue);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Calculate_kValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.KValue_textbox);
            this.panel1.Location = new System.Drawing.Point(291, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 199);
            this.panel1.TabIndex = 15;
            // 
            // Population_threshold_Textbox
            // 
            this.Population_threshold_Textbox.Location = new System.Drawing.Point(163, 115);
            this.Population_threshold_Textbox.Name = "Population_threshold_Textbox";
            this.Population_threshold_Textbox.Size = new System.Drawing.Size(100, 21);
            this.Population_threshold_Textbox.TabIndex = 17;
            this.Population_threshold_Textbox.TextChanged += new System.EventHandler(this.Population_threshold_Textbox_TextChanged);
            // 
            // CalculateKvalue_inputParam_label
            // 
            this.CalculateKvalue_inputParam_label.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CalculateKvalue_inputParam_label.Location = new System.Drawing.Point(13, 113);
            this.CalculateKvalue_inputParam_label.Name = "CalculateKvalue_inputParam_label";
            this.CalculateKvalue_inputParam_label.Size = new System.Drawing.Size(144, 23);
            this.CalculateKvalue_inputParam_label.TabIndex = 16;
            // 
            // radioBtn_inputTime
            // 
            this.radioBtn_inputTime.AutoSize = true;
            this.radioBtn_inputTime.Location = new System.Drawing.Point(147, 79);
            this.radioBtn_inputTime.Name = "radioBtn_inputTime";
            this.radioBtn_inputTime.Size = new System.Drawing.Size(149, 16);
            this.radioBtn_inputTime.TabIndex = 14;
            this.radioBtn_inputTime.TabStop = true;
            this.radioBtn_inputTime.Text = "输入时间计算K值(分钟)";
            this.radioBtn_inputTime.UseVisualStyleBackColor = true;
            this.radioBtn_inputTime.CheckedChanged += new System.EventHandler(this.radioBtn_inputTime_CheckedChanged);
            // 
            // radioBtn_ClosetFac
            // 
            this.radioBtn_ClosetFac.AutoSize = true;
            this.radioBtn_ClosetFac.Location = new System.Drawing.Point(16, 79);
            this.radioBtn_ClosetFac.Name = "radioBtn_ClosetFac";
            this.radioBtn_ClosetFac.Size = new System.Drawing.Size(125, 16);
            this.radioBtn_ClosetFac.TabIndex = 15;
            this.radioBtn_ClosetFac.TabStop = true;
            this.radioBtn_ClosetFac.Text = "平均值占比计算K值";
            this.radioBtn_ClosetFac.UseVisualStyleBackColor = true;
            this.radioBtn_ClosetFac.CheckedChanged += new System.EventHandler(this.radioBtn_ClosetFac_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(65, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "高斯衰减k值讨论";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // Extend_Ga2SFCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 303);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Time_threshold_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Load_publicFac_btn);
            this.Controls.Add(this.Load_ODTIME_BTN);
            this.Controls.Add(this.Load_gridPop);
            this.Controls.Add(this.Comfirm_btn);
            this.Controls.Add(this.PublicFac_fileName);
            this.Controls.Add(this.Average_timeTextbox);
            this.Controls.Add(this.OD_TIME_TEXT);
            this.Controls.Add(this.GridPopu_FilenameTxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Extend_Ga2SFCA";
            this.Text = "Extend_Ga2SFCA";
            this.Load += new System.EventHandler(this.Extend_Ga2SFCA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Load_publicFac_btn;
        private System.Windows.Forms.Button Load_ODTIME_BTN;
        private System.Windows.Forms.Button Load_gridPop;
        private System.Windows.Forms.Button Comfirm_btn;
        private System.Windows.Forms.TextBox PublicFac_fileName;
        private System.Windows.Forms.TextBox OD_TIME_TEXT;
        private System.Windows.Forms.TextBox GridPopu_FilenameTxt;
        private System.Windows.Forms.TextBox Time_threshold_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Average_timeTextbox;
        private System.Windows.Forms.TextBox damping_function_DownValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Calculate_kValue;
        private System.Windows.Forms.TextBox KValue_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBtn_inputTime;
        private System.Windows.Forms.RadioButton radioBtn_ClosetFac;
        private System.Windows.Forms.TextBox Population_threshold_Textbox;
        private System.Windows.Forms.Label CalculateKvalue_inputParam_label;
    }
}