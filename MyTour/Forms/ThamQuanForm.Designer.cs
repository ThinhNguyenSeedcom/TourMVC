
namespace MyTour.Forms
{
    partial class ThamQuanForm
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
            this.dataGridViewThamQuan = new System.Windows.Forms.DataGridView();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThamQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewThamQuan
            // 
            this.dataGridViewThamQuan.AllowUserToAddRows = false;
            this.dataGridViewThamQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThamQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTour,
            this.maDiaDiem,
            this.tenDiaDiem,
            this.tenTour,
            this.thuTu});
            this.dataGridViewThamQuan.Location = new System.Drawing.Point(13, 101);
            this.dataGridViewThamQuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewThamQuan.Name = "dataGridViewThamQuan";
            this.dataGridViewThamQuan.RowHeadersWidth = 51;
            this.dataGridViewThamQuan.Size = new System.Drawing.Size(1500, 315);
            this.dataGridViewThamQuan.TabIndex = 0;
            // 
            // maTour
            // 
            this.maTour.HeaderText = "Mã Tour";
            this.maTour.MinimumWidth = 6;
            this.maTour.Name = "maTour";
            this.maTour.Width = 80;
            // 
            // maDiaDiem
            // 
            this.maDiaDiem.HeaderText = "Mã Địa Điểm";
            this.maDiaDiem.MinimumWidth = 6;
            this.maDiaDiem.Name = "maDiaDiem";
            this.maDiaDiem.Width = 125;
            // 
            // tenDiaDiem
            // 
            this.tenDiaDiem.HeaderText = "Tên Địa Điểm";
            this.tenDiaDiem.MinimumWidth = 6;
            this.tenDiaDiem.Name = "tenDiaDiem";
            this.tenDiaDiem.Width = 300;
            // 
            // tenTour
            // 
            this.tenTour.HeaderText = "Tên Tour";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.Width = 500;
            // 
            // thuTu
            // 
            this.thuTu.HeaderText = "Thứ Tự";
            this.thuTu.MinimumWidth = 6;
            this.thuTu.Name = "thuTu";
            this.thuTu.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tham Quan";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(1286, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm Địa Điểm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThamQuanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewThamQuan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThamQuanForm";
            this.Text = "DiaDiem";
            this.Load += new System.EventHandler(this.DiaDiemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThamQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThamQuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuTu;
        private System.Windows.Forms.Button button1;
    }
}