
namespace MyTour.Forms
{
    partial class GiaTourForm
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
            this.dataGridViewFGiaTour = new System.Windows.Forms.DataGridView();
            this.magiatourFgiatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matourFgiatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeFgiatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeFgiatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienFgiatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaGia = new System.Windows.Forms.TextBox();
            this.textBoxMaTour = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxThanhTien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFGiaTour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Tour";
            // 
            // dataGridViewFGiaTour
            // 
            this.dataGridViewFGiaTour.AllowUserToAddRows = false;
            this.dataGridViewFGiaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFGiaTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiatourFgiatour,
            this.matourFgiatour,
            this.startTimeFgiatour,
            this.endTimeFgiatour,
            this.thanhtienFgiatour});
            this.dataGridViewFGiaTour.Location = new System.Drawing.Point(21, 67);
            this.dataGridViewFGiaTour.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFGiaTour.Name = "dataGridViewFGiaTour";
            this.dataGridViewFGiaTour.RowHeadersWidth = 51;
            this.dataGridViewFGiaTour.Size = new System.Drawing.Size(788, 472);
            this.dataGridViewFGiaTour.TabIndex = 1;
            this.dataGridViewFGiaTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFGiaTour_CellClick);
            // 
            // magiatourFgiatour
            // 
            this.magiatourFgiatour.HeaderText = "Mã Giá";
            this.magiatourFgiatour.MinimumWidth = 6;
            this.magiatourFgiatour.Name = "magiatourFgiatour";
            this.magiatourFgiatour.Width = 70;
            // 
            // matourFgiatour
            // 
            this.matourFgiatour.HeaderText = "Mã Tour";
            this.matourFgiatour.MinimumWidth = 6;
            this.matourFgiatour.Name = "matourFgiatour";
            this.matourFgiatour.Width = 90;
            // 
            // startTimeFgiatour
            // 
            this.startTimeFgiatour.HeaderText = "Thời Gian Bắt Đầu";
            this.startTimeFgiatour.MinimumWidth = 6;
            this.startTimeFgiatour.Name = "startTimeFgiatour";
            this.startTimeFgiatour.Width = 125;
            // 
            // endTimeFgiatour
            // 
            this.endTimeFgiatour.HeaderText = "Thời Gian Kết Thúc";
            this.endTimeFgiatour.MinimumWidth = 6;
            this.endTimeFgiatour.Name = "endTimeFgiatour";
            this.endTimeFgiatour.Width = 125;
            // 
            // thanhtienFgiatour
            // 
            this.thanhtienFgiatour.HeaderText = "Thành Tiền";
            this.thanhtienFgiatour.MinimumWidth = 6;
            this.thanhtienFgiatour.Name = "thanhtienFgiatour";
            this.thanhtienFgiatour.Width = 175;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(869, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(869, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Tour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(869, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời Gian Bắt Đầu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(869, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời Gian Kết Thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(869, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thành Tiền";
            // 
            // textBoxMaGia
            // 
            this.textBoxMaGia.Location = new System.Drawing.Point(963, 53);
            this.textBoxMaGia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaGia.Name = "textBoxMaGia";
            this.textBoxMaGia.Size = new System.Drawing.Size(299, 22);
            this.textBoxMaGia.TabIndex = 7;
            // 
            // textBoxMaTour
            // 
            this.textBoxMaTour.Location = new System.Drawing.Point(963, 105);
            this.textBoxMaTour.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaTour.Name = "textBoxMaTour";
            this.textBoxMaTour.Size = new System.Drawing.Size(299, 22);
            this.textBoxMaTour.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1028, 172);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1028, 233);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // textBoxThanhTien
            // 
            this.textBoxThanhTien.BackColor = System.Drawing.Color.White;
            this.textBoxThanhTien.Location = new System.Drawing.Point(976, 295);
            this.textBoxThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxThanhTien.Name = "textBoxThanhTien";
            this.textBoxThanhTien.Size = new System.Drawing.Size(286, 22);
            this.textBoxThanhTien.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(872, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(872, 469);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GiaTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxThanhTien);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMaTour);
            this.Controls.Add(this.textBoxMaGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewFGiaTour);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiaTourForm";
            this.Text = "GiaTour";
            this.Load += new System.EventHandler(this.GiaTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFGiaTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFGiaTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMaGia;
        private System.Windows.Forms.TextBox textBoxMaTour;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxThanhTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiatourFgiatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn matourFgiatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeFgiatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeFgiatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienFgiatour;
    }
}