
namespace MyTour
{
    partial class MyTour
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
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDiemTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewDiadiem = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTest = new System.Windows.Forms.DataGridView();
            this.cbLoaiTour = new System.Windows.Forms.ComboBox();
            this.txtDatDiemTour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenTour = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.updateTour = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.myTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiadiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenTour,
            this.loaiTour,
            this.datDiemTour});
            this.dtgvData.Location = new System.Drawing.Point(28, 8);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.Size = new System.Drawing.Size(1480, 280);
            this.dtgvData.TabIndex = 0;
            this.dtgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellClick);
            // 
            // tenTour
            // 
            this.tenTour.HeaderText = "Tên Tour";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.Width = 250;
            // 
            // loaiTour
            // 
            this.loaiTour.HeaderText = "Loại Tour";
            this.loaiTour.MinimumWidth = 6;
            this.loaiTour.Name = "loaiTour";
            this.loaiTour.Width = 250;
            // 
            // datDiemTour
            // 
            this.datDiemTour.HeaderText = "Đặt ĐIểm Tour";
            this.datDiemTour.MinimumWidth = 6;
            this.datDiemTour.Name = "datDiemTour";
            this.datDiemTour.Width = 750;
            // 
            // myTab
            // 
            this.myTab.AllowDrop = true;
            this.myTab.Controls.Add(this.tabPage1);
            this.myTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTab.Location = new System.Drawing.Point(13, 13);
            this.myTab.Margin = new System.Windows.Forms.Padding(4);
            this.myTab.Multiline = true;
            this.myTab.Name = "myTab";
            this.myTab.SelectedIndex = 0;
            this.myTab.Size = new System.Drawing.Size(1640, 1121);
            this.myTab.TabIndex = 2;
            this.myTab.Click += new System.EventHandler(this.myTab_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dataGridViewDiadiem);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridViewTest);
            this.tabPage1.Controls.Add(this.cbLoaiTour);
            this.tabPage1.Controls.Add(this.txtDatDiemTour);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txbTenTour);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.updateTour);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dtgvData);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1632, 1079);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tour";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(33, 554);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Giá Tour";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(1361, 537);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 46);
            this.button6.TabIndex = 19;
            this.button6.Text = "Xem Địa Điểm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(549, 537);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 46);
            this.button5.TabIndex = 18;
            this.button5.Text = "Xem Giá Tour";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(1388, 411);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 54);
            this.button3.TabIndex = 17;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(846, 554);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Địa Điểm Tour";
            // 
            // dataGridViewDiadiem
            // 
            this.dataGridViewDiadiem.AllowUserToAddRows = false;
            this.dataGridViewDiadiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiadiem.Location = new System.Drawing.Point(851, 591);
            this.dataGridViewDiadiem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDiadiem.Name = "dataGridViewDiadiem";
            this.dataGridViewDiadiem.RowHeadersWidth = 51;
            this.dataGridViewDiadiem.Size = new System.Drawing.Size(657, 231);
            this.dataGridViewDiadiem.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1310, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.AllowUserToAddRows = false;
            this.dataGridViewTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Location = new System.Drawing.Point(38, 591);
            this.dataGridViewTest.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.RowHeadersWidth = 51;
            this.dataGridViewTest.Size = new System.Drawing.Size(657, 231);
            this.dataGridViewTest.TabIndex = 12;
            // 
            // cbLoaiTour
            // 
            this.cbLoaiTour.FormattingEnabled = true;
            this.cbLoaiTour.Location = new System.Drawing.Point(911, 310);
            this.cbLoaiTour.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiTour.Name = "cbLoaiTour";
            this.cbLoaiTour.Size = new System.Drawing.Size(391, 28);
            this.cbLoaiTour.TabIndex = 11;
            // 
            // txtDatDiemTour
            // 
            this.txtDatDiemTour.Location = new System.Drawing.Point(203, 363);
            this.txtDatDiemTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatDiemTour.Name = "txtDatDiemTour";
            this.txtDatDiemTour.Size = new System.Drawing.Size(1152, 26);
            this.txtDatDiemTour.TabIndex = 10;
            this.txtDatDiemTour.TextChanged += new System.EventHandler(this.txtDatDiemTour_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đặt Điểm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại Tour";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Tour";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbTenTour
            // 
            this.txbTenTour.Location = new System.Drawing.Point(203, 310);
            this.txbTenTour.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenTour.Name = "txbTenTour";
            this.txbTenTour.Size = new System.Drawing.Size(352, 26);
            this.txbTenTour.TabIndex = 5;
            this.txbTenTour.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(1242, 411);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // updateTour
            // 
            this.updateTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.updateTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updateTour.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateTour.Location = new System.Drawing.Point(1094, 411);
            this.updateTour.Margin = new System.Windows.Forms.Padding(4);
            this.updateTour.Name = "updateTour";
            this.updateTour.Size = new System.Drawing.Size(113, 55);
            this.updateTour.TabIndex = 3;
            this.updateTour.Text = "Sửa";
            this.updateTour.UseVisualStyleBackColor = false;
            this.updateTour.Click += new System.EventHandler(this.updateTour_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(943, 411);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 919);
            this.Controls.Add(this.myTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyTour";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.myTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiadiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.TabControl myTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button updateTour;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenTour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatDiemTour;
        private System.Windows.Forms.ComboBox cbLoaiTour;
        private System.Windows.Forms.DataGridView dataGridViewTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDiemTour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewDiadiem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}

