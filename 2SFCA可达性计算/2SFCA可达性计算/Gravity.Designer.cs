namespace _2SFCA可达性计算
{
    partial class Gravity
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
            this.Load_publicFac_btn = new System.Windows.Forms.Button();
            this.Load_ODTIME_BTN = new System.Windows.Forms.Button();
            this.Load_gridPop = new System.Windows.Forms.Button();
            this.PublicFac_fileName = new System.Windows.Forms.TextBox();
            this.OD_TIME_TEXT = new System.Windows.Forms.TextBox();
            this.GridPopu_FilenameTxt = new System.Windows.Forms.TextBox();
            this.Beta_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Comfirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load_publicFac_btn
            // 
            this.Load_publicFac_btn.Location = new System.Drawing.Point(16, 106);
            this.Load_publicFac_btn.Name = "Load_publicFac_btn";
            this.Load_publicFac_btn.Size = new System.Drawing.Size(136, 23);
            this.Load_publicFac_btn.TabIndex = 7;
            this.Load_publicFac_btn.Text = "加载公共服务设施";
            this.Load_publicFac_btn.UseVisualStyleBackColor = true;
            this.Load_publicFac_btn.Click += new System.EventHandler(this.Load_publicFac_btn_Click);
            // 
            // Load_ODTIME_BTN
            // 
            this.Load_ODTIME_BTN.Location = new System.Drawing.Point(16, 147);
            this.Load_ODTIME_BTN.Name = "Load_ODTIME_BTN";
            this.Load_ODTIME_BTN.Size = new System.Drawing.Size(136, 23);
            this.Load_ODTIME_BTN.TabIndex = 8;
            this.Load_ODTIME_BTN.Text = "加载OD交通时间";
            this.Load_ODTIME_BTN.UseVisualStyleBackColor = true;
            this.Load_ODTIME_BTN.Click += new System.EventHandler(this.Load_ODTIME_BTN_Click);
            // 
            // Load_gridPop
            // 
            this.Load_gridPop.Location = new System.Drawing.Point(16, 64);
            this.Load_gridPop.Name = "Load_gridPop";
            this.Load_gridPop.Size = new System.Drawing.Size(136, 23);
            this.Load_gridPop.TabIndex = 9;
            this.Load_gridPop.Text = "加载格网人口文件";
            this.Load_gridPop.UseVisualStyleBackColor = true;
            this.Load_gridPop.Click += new System.EventHandler(this.Load_gridPop_Click);
            // 
            // PublicFac_fileName
            // 
            this.PublicFac_fileName.Location = new System.Drawing.Point(172, 106);
            this.PublicFac_fileName.Name = "PublicFac_fileName";
            this.PublicFac_fileName.Size = new System.Drawing.Size(100, 21);
            this.PublicFac_fileName.TabIndex = 4;
            // 
            // OD_TIME_TEXT
            // 
            this.OD_TIME_TEXT.Location = new System.Drawing.Point(172, 147);
            this.OD_TIME_TEXT.Name = "OD_TIME_TEXT";
            this.OD_TIME_TEXT.Size = new System.Drawing.Size(100, 21);
            this.OD_TIME_TEXT.TabIndex = 5;
            // 
            // GridPopu_FilenameTxt
            // 
            this.GridPopu_FilenameTxt.Location = new System.Drawing.Point(172, 64);
            this.GridPopu_FilenameTxt.Name = "GridPopu_FilenameTxt";
            this.GridPopu_FilenameTxt.Size = new System.Drawing.Size(100, 21);
            this.GridPopu_FilenameTxt.TabIndex = 6;
            // 
            // Beta_Textbox
            // 
            this.Beta_Textbox.Location = new System.Drawing.Point(172, 21);
            this.Beta_Textbox.Name = "Beta_Textbox";
            this.Beta_Textbox.Size = new System.Drawing.Size(100, 21);
            this.Beta_Textbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "β:";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(186, 197);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 12;
            this.Cancel_btn.Text = "取消";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Comfirm_btn
            // 
            this.Comfirm_btn.Location = new System.Drawing.Point(101, 197);
            this.Comfirm_btn.Name = "Comfirm_btn";
            this.Comfirm_btn.Size = new System.Drawing.Size(75, 23);
            this.Comfirm_btn.TabIndex = 11;
            this.Comfirm_btn.Text = "确定";
            this.Comfirm_btn.UseVisualStyleBackColor = true;
            this.Comfirm_btn.Click += new System.EventHandler(this.Comfirm_btn_Click);
            // 
            // Gravity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 240);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Comfirm_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load_publicFac_btn);
            this.Controls.Add(this.Load_ODTIME_BTN);
            this.Controls.Add(this.Load_gridPop);
            this.Controls.Add(this.PublicFac_fileName);
            this.Controls.Add(this.OD_TIME_TEXT);
            this.Controls.Add(this.Beta_Textbox);
            this.Controls.Add(this.GridPopu_FilenameTxt);
            this.Name = "Gravity";
            this.Text = "Gravity";
            this.Load += new System.EventHandler(this.Gravity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_publicFac_btn;
        private System.Windows.Forms.Button Load_ODTIME_BTN;
        private System.Windows.Forms.Button Load_gridPop;
        private System.Windows.Forms.TextBox PublicFac_fileName;
        private System.Windows.Forms.TextBox OD_TIME_TEXT;
        private System.Windows.Forms.TextBox GridPopu_FilenameTxt;
        private System.Windows.Forms.TextBox Beta_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Comfirm_btn;
    }
}