namespace lamchovo.GUI
{
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.btnImport = new System.Windows.Forms.Button();
            this.dtDayImport = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbSheet = new System.Windows.Forms.TextBox();
            this.cbClientImport = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTypeFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImport.BackgroundImage")));
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(8, 204);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(174, 28);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // dtDayImport
            // 
            this.dtDayImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDayImport.Location = new System.Drawing.Point(8, 170);
            this.dtDayImport.Name = "dtDayImport";
            this.dtDayImport.Size = new System.Drawing.Size(175, 20);
            this.dtDayImport.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Ngày nộp vé:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Khách hàng";
            // 
            // txbSheet
            // 
            this.txbSheet.Location = new System.Drawing.Point(8, 76);
            this.txbSheet.Name = "txbSheet";
            this.txbSheet.Size = new System.Drawing.Size(175, 20);
            this.txbSheet.TabIndex = 29;
            // 
            // cbClientImport
            // 
            this.cbClientImport.FormattingEnabled = true;
            this.cbClientImport.Location = new System.Drawing.Point(8, 121);
            this.cbClientImport.Name = "cbClientImport";
            this.cbClientImport.Size = new System.Drawing.Size(175, 21);
            this.cbClientImport.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Sheet";
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.FormattingEnabled = true;
            this.cbTypeFilter.Location = new System.Drawing.Point(8, 30);
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(175, 21);
            this.cbTypeFilter.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Chọn loại vé";
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dtDayImport);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbTypeFilter);
            this.Controls.Add(this.cbClientImport);
            this.Controls.Add(this.txbSheet);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập liệu từ file Excel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmImport_FormClosed);
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbSheet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbClientImport;
        private System.Windows.Forms.DateTimePicker dtDayImport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbTypeFilter;
        private System.Windows.Forms.Label label1;
    }
}