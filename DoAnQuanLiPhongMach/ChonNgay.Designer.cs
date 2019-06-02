namespace DoAnQuanLiPhongMach
{
    partial class ChonNgay
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
            this.dtpStar = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpStar
            // 
            this.dtpStar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStar.Location = new System.Drawing.Point(159, 73);
            this.dtpStar.Name = "dtpStar";
            this.dtpStar.Size = new System.Drawing.Size(77, 20);
            this.dtpStar.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(159, 129);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(77, 20);
            this.dtpEnd.TabIndex = 1;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(280, 96);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 2;
            this.btLoad.Text = "Load Báo Cáo";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // ChonNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStar);
            this.Name = "ChonNgay";
            this.Text = "ChonNgay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStar;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btLoad;
    }
}