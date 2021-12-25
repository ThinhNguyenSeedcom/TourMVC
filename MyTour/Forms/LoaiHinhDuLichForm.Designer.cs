
namespace MyTour.Forms
{
    partial class LoaiHinhDuLichForm
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
            this.dataGridViewLoaiTour = new System.Windows.Forms.DataGridView();
            this.maloaitour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaitour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaLoai = new System.Windows.Forms.TextBox();
            this.textBoxTenLoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiTour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Tour";
            // 
            // dataGridViewLoaiTour
            // 
            this.dataGridViewLoaiTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaitour,
            this.tenloaitour});
            this.dataGridViewLoaiTour.Location = new System.Drawing.Point(19, 67);
            this.dataGridViewLoaiTour.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLoaiTour.Name = "dataGridViewLoaiTour";
            this.dataGridViewLoaiTour.RowHeadersWidth = 51;
            this.dataGridViewLoaiTour.Size = new System.Drawing.Size(491, 446);
            this.dataGridViewLoaiTour.TabIndex = 1;
            this.dataGridViewLoaiTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiTour_CellClick);
            this.dataGridViewLoaiTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiTour_CellContentClick);
            // 
            // maloaitour
            // 
            this.maloaitour.Frozen = true;
            this.maloaitour.HeaderText = "Mã Loại Tour";
            this.maloaitour.MinimumWidth = 6;
            this.maloaitour.Name = "maloaitour";
            this.maloaitour.Width = 125;
            // 
            // tenloaitour
            // 
            this.tenloaitour.Frozen = true;
            this.tenloaitour.HeaderText = "Tên Loại Tour";
            this.tenloaitour.MinimumWidth = 6;
            this.tenloaitour.Name = "tenloaitour";
            this.tenloaitour.Width = 300;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(706, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Loại";
            // 
            // textBoxMaLoai
            // 
            this.textBoxMaLoai.Location = new System.Drawing.Point(538, 85);
            this.textBoxMaLoai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaLoai.Name = "textBoxMaLoai";
            this.textBoxMaLoai.Size = new System.Drawing.Size(279, 22);
            this.textBoxMaLoai.TabIndex = 5;
            // 
            // textBoxTenLoai
            // 
            this.textBoxTenLoai.Location = new System.Drawing.Point(538, 171);
            this.textBoxTenLoai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenLoai.Name = "textBoxTenLoai";
            this.textBoxTenLoai.Size = new System.Drawing.Size(279, 22);
            this.textBoxTenLoai.TabIndex = 6;
            // 
            // LoaiHinhDuLichForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 554);
            this.Controls.Add(this.textBoxTenLoai);
            this.Controls.Add(this.textBoxMaLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewLoaiTour);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiHinhDuLichForm";
            this.Text = "LoaiHinhDuLichForm";
            this.Load += new System.EventHandler(this.LoaiHinhDuLichForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLoaiTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaitour;
        private System.Windows.Forms.DataGridViewTextBoxColumn temloaitour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaitour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaLoai;
        private System.Windows.Forms.TextBox textBoxTenLoai;
    }
}