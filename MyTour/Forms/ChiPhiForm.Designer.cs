
namespace MyTour.Forms
{
    partial class ChiPhiForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMaChiPhi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxMaLoaiChiPhi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSoTien = new System.Windows.Forms.TextBox();
            this.labelMaDoan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Chi Phí Vào Đoàn: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mã Chi Phí";
            // 
            // textBoxMaChiPhi
            // 
            this.textBoxMaChiPhi.Location = new System.Drawing.Point(173, 86);
            this.textBoxMaChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaChiPhi.Name = "textBoxMaChiPhi";
            this.textBoxMaChiPhi.Size = new System.Drawing.Size(265, 22);
            this.textBoxMaChiPhi.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mã Loại Chi Phí";
            // 
            // comboBoxMaLoaiChiPhi
            // 
            this.comboBoxMaLoaiChiPhi.FormattingEnabled = true;
            this.comboBoxMaLoaiChiPhi.Location = new System.Drawing.Point(173, 139);
            this.comboBoxMaLoaiChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaLoaiChiPhi.Name = "comboBoxMaLoaiChiPhi";
            this.comboBoxMaLoaiChiPhi.Size = new System.Drawing.Size(265, 24);
            this.comboBoxMaLoaiChiPhi.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Số Tiền";
            // 
            // textBoxSoTien
            // 
            this.textBoxSoTien.Location = new System.Drawing.Point(173, 193);
            this.textBoxSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoTien.Name = "textBoxSoTien";
            this.textBoxSoTien.Size = new System.Drawing.Size(265, 22);
            this.textBoxSoTien.TabIndex = 23;
            // 
            // labelMaDoan
            // 
            this.labelMaDoan.AutoSize = true;
            this.labelMaDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaDoan.Location = new System.Drawing.Point(339, 16);
            this.labelMaDoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaDoan.Name = "labelMaDoan";
            this.labelMaDoan.Size = new System.Drawing.Size(81, 29);
            this.labelMaDoan.TabIndex = 24;
            this.labelMaDoan.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(24, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(416, 65);
            this.button1.TabIndex = 26;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChiPhiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMaDoan);
            this.Controls.Add(this.textBoxSoTien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxMaLoaiChiPhi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxMaChiPhi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiPhiForm";
            this.Text = "ChiPhiForm";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMaChiPhi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxMaLoaiChiPhi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSoTien;
        private System.Windows.Forms.Label labelMaDoan;
        private System.Windows.Forms.Button button1;
    }
}