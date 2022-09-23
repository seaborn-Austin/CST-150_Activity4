namespace Stopwatch
{
    partial class secConvertFrm
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
            this.nmbSecTxt = new System.Windows.Forms.Label();
            this.secTxt = new System.Windows.Forms.TextBox();
            this.secConvLbl = new System.Windows.Forms.Label();
            this.secConvTxt = new System.Windows.Forms.TextBox();
            this.secConversionBtn = new System.Windows.Forms.Button();
            this.minLbl = new System.Windows.Forms.Label();
            this.minTxt = new System.Windows.Forms.TextBox();
            this.hourLbl = new System.Windows.Forms.Label();
            this.hourTxt = new System.Windows.Forms.TextBox();
            this.daysLbl = new System.Windows.Forms.Label();
            this.daysTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nmbSecTxt
            // 
            this.nmbSecTxt.AutoSize = true;
            this.nmbSecTxt.Location = new System.Drawing.Point(3, 9);
            this.nmbSecTxt.Name = "nmbSecTxt";
            this.nmbSecTxt.Size = new System.Drawing.Size(234, 13);
            this.nmbSecTxt.TabIndex = 0;
            this.nmbSecTxt.Text = "Enter the number of seconds that have elapsed:";
            // 
            // secTxt
            // 
            this.secTxt.Location = new System.Drawing.Point(243, 2);
            this.secTxt.Name = "secTxt";
            this.secTxt.Size = new System.Drawing.Size(100, 20);
            this.secTxt.TabIndex = 1;
            // 
            // secConvLbl
            // 
            this.secConvLbl.AutoSize = true;
            this.secConvLbl.Location = new System.Drawing.Point(3, 115);
            this.secConvLbl.Name = "secConvLbl";
            this.secConvLbl.Size = new System.Drawing.Size(52, 13);
            this.secConvLbl.TabIndex = 2;
            this.secConvLbl.Text = "Seconds:";
            // 
            // secConvTxt
            // 
            this.secConvTxt.AcceptsReturn = true;
            this.secConvTxt.Location = new System.Drawing.Point(49, 108);
            this.secConvTxt.Name = "secConvTxt";
            this.secConvTxt.Size = new System.Drawing.Size(100, 20);
            this.secConvTxt.TabIndex = 3;
            // 
            // secConversionBtn
            // 
            this.secConversionBtn.Location = new System.Drawing.Point(143, 169);
            this.secConversionBtn.Name = "secConversionBtn";
            this.secConversionBtn.Size = new System.Drawing.Size(75, 23);
            this.secConversionBtn.TabIndex = 4;
            this.secConversionBtn.Text = "Convert";
            this.secConversionBtn.UseVisualStyleBackColor = true;
            this.secConversionBtn.Click += new System.EventHandler(this.secConversionBtn_Click);
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Location = new System.Drawing.Point(3, 92);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(47, 13);
            this.minLbl.TabIndex = 5;
            this.minLbl.Text = "Minutes:";
            // 
            // minTxt
            // 
            this.minTxt.Location = new System.Drawing.Point(49, 85);
            this.minTxt.Name = "minTxt";
            this.minTxt.Size = new System.Drawing.Size(100, 20);
            this.minTxt.TabIndex = 6;
            // 
            // hourLbl
            // 
            this.hourLbl.AutoSize = true;
            this.hourLbl.Location = new System.Drawing.Point(3, 69);
            this.hourLbl.Name = "hourLbl";
            this.hourLbl.Size = new System.Drawing.Size(38, 13);
            this.hourLbl.TabIndex = 7;
            this.hourLbl.Text = "Hours:";
            // 
            // hourTxt
            // 
            this.hourTxt.Location = new System.Drawing.Point(47, 62);
            this.hourTxt.Name = "hourTxt";
            this.hourTxt.Size = new System.Drawing.Size(100, 20);
            this.hourTxt.TabIndex = 8;
            // 
            // daysLbl
            // 
            this.daysLbl.AutoSize = true;
            this.daysLbl.Location = new System.Drawing.Point(3, 47);
            this.daysLbl.Name = "daysLbl";
            this.daysLbl.Size = new System.Drawing.Size(34, 13);
            this.daysLbl.TabIndex = 9;
            this.daysLbl.Text = "Days:";
            // 
            // daysTxt
            // 
            this.daysTxt.Location = new System.Drawing.Point(43, 40);
            this.daysTxt.Name = "daysTxt";
            this.daysTxt.Size = new System.Drawing.Size(100, 20);
            this.daysTxt.TabIndex = 10;
            // 
            // secConvertFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 224);
            this.Controls.Add(this.daysTxt);
            this.Controls.Add(this.daysLbl);
            this.Controls.Add(this.hourTxt);
            this.Controls.Add(this.hourLbl);
            this.Controls.Add(this.minTxt);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.secConversionBtn);
            this.Controls.Add(this.secConvTxt);
            this.Controls.Add(this.secConvLbl);
            this.Controls.Add(this.secTxt);
            this.Controls.Add(this.nmbSecTxt);
            this.Name = "secConvertFrm";
            this.Text = "Seconds Converted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nmbSecTxt;
        private System.Windows.Forms.TextBox secTxt;
        private System.Windows.Forms.Label secConvLbl;
        private System.Windows.Forms.TextBox secConvTxt;
        private System.Windows.Forms.Button secConversionBtn;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.TextBox minTxt;
        private System.Windows.Forms.Label hourLbl;
        private System.Windows.Forms.TextBox hourTxt;
        private System.Windows.Forms.Label daysLbl;
        private System.Windows.Forms.TextBox daysTxt;
    }
}

