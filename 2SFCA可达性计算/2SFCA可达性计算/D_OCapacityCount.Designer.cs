namespace _2SFCA可达性计算
{
    partial class D_OCapacityCount
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
            this.LoadPopu_Data = new System.Windows.Forms.Button();
            this.PopuFile_Name = new System.Windows.Forms.TextBox();
            this.DO_FILENAME = new System.Windows.Forms.TextBox();
            this.LoadD_OTimeMatrix = new System.Windows.Forms.Button();
            this.Calc_ResultBtn = new System.Windows.Forms.Button();
            this.Threshold_Text = new System.Windows.Forms.TextBox();
            this.TimeThreshold_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadPopu_Data
            // 
            this.LoadPopu_Data.Location = new System.Drawing.Point(12, 29);
            this.LoadPopu_Data.Name = "LoadPopu_Data";
            this.LoadPopu_Data.Size = new System.Drawing.Size(136, 23);
            this.LoadPopu_Data.TabIndex = 4;
            this.LoadPopu_Data.Text = "加载人口数据";
            this.LoadPopu_Data.UseVisualStyleBackColor = true;
            this.LoadPopu_Data.Click += new System.EventHandler(this.LoadPopu_Data_Click);
            // 
            // PopuFile_Name
            // 
            this.PopuFile_Name.Location = new System.Drawing.Point(164, 29);
            this.PopuFile_Name.Name = "PopuFile_Name";
            this.PopuFile_Name.ReadOnly = true;
            this.PopuFile_Name.Size = new System.Drawing.Size(93, 21);
            this.PopuFile_Name.TabIndex = 3;
            // 
            // DO_FILENAME
            // 
            this.DO_FILENAME.Location = new System.Drawing.Point(162, 87);
            this.DO_FILENAME.Name = "DO_FILENAME";
            this.DO_FILENAME.ReadOnly = true;
            this.DO_FILENAME.Size = new System.Drawing.Size(95, 21);
            this.DO_FILENAME.TabIndex = 3;
            // 
            // LoadD_OTimeMatrix
            // 
            this.LoadD_OTimeMatrix.Location = new System.Drawing.Point(12, 85);
            this.LoadD_OTimeMatrix.Name = "LoadD_OTimeMatrix";
            this.LoadD_OTimeMatrix.Size = new System.Drawing.Size(136, 23);
            this.LoadD_OTimeMatrix.TabIndex = 4;
            this.LoadD_OTimeMatrix.Text = "加载Travel-Time矩阵";
            this.LoadD_OTimeMatrix.UseVisualStyleBackColor = true;
            this.LoadD_OTimeMatrix.Click += new System.EventHandler(this.LoadD_OTimeMatrix_Click);
            // 
            // Calc_ResultBtn
            // 
            this.Calc_ResultBtn.Location = new System.Drawing.Point(87, 171);
            this.Calc_ResultBtn.Name = "Calc_ResultBtn";
            this.Calc_ResultBtn.Size = new System.Drawing.Size(117, 45);
            this.Calc_ResultBtn.TabIndex = 4;
            this.Calc_ResultBtn.Text = "计算结果";
            this.Calc_ResultBtn.UseVisualStyleBackColor = true;
            this.Calc_ResultBtn.Click += new System.EventHandler(this.Calc_ResultBtn_Click);
            // 
            // Threshold_Text
            // 
            this.Threshold_Text.Location = new System.Drawing.Point(164, 134);
            this.Threshold_Text.Name = "Threshold_Text";
            this.Threshold_Text.Size = new System.Drawing.Size(95, 21);
            this.Threshold_Text.TabIndex = 3;
            this.Threshold_Text.Text = "30";
            // 
            // TimeThreshold_label
            // 
            this.TimeThreshold_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeThreshold_label.Location = new System.Drawing.Point(53, 134);
            this.TimeThreshold_label.Name = "TimeThreshold_label";
            this.TimeThreshold_label.Size = new System.Drawing.Size(75, 23);
            this.TimeThreshold_label.TabIndex = 5;
            this.TimeThreshold_label.Text = "时间阈值";
            // 
            // D_OCapacityCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TimeThreshold_label);
            this.Controls.Add(this.Calc_ResultBtn);
            this.Controls.Add(this.LoadD_OTimeMatrix);
            this.Controls.Add(this.LoadPopu_Data);
            this.Controls.Add(this.Threshold_Text);
            this.Controls.Add(this.DO_FILENAME);
            this.Controls.Add(this.PopuFile_Name);
            this.Name = "D_OCapacityCount";
            this.Text = "D_OCapacityCount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadPopu_Data;
        private System.Windows.Forms.TextBox PopuFile_Name;
        private System.Windows.Forms.TextBox DO_FILENAME;
        private System.Windows.Forms.Button LoadD_OTimeMatrix;
        private System.Windows.Forms.Button Calc_ResultBtn;
        private System.Windows.Forms.TextBox Threshold_Text;
        private System.Windows.Forms.Label TimeThreshold_label;
    }
}