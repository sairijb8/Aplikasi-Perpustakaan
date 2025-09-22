namespace LatihanXIIRPL1
{
    partial class FormBuku
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtISBN = new TextBox();
            txtJudul = new TextBox();
            txtPengarang = new TextBox();
            txtPenerbit = new TextBox();
            txtTahunTerbit = new TextBox();
            btnSimpan = new Button();
            btnHapus = new Button();
            btnTutup = new Button();
            dgvBuku = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBuku).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "DATA BUKU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 65);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 92);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Judul Buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 124);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Pengarang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 154);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Penerbit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 186);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 5;
            label6.Text = "Tahun Terbit";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(167, 57);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 6;
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(167, 86);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(223, 23);
            txtJudul.TabIndex = 7;
            // 
            // txtPengarang
            // 
            txtPengarang.Location = new Point(167, 116);
            txtPengarang.Name = "txtPengarang";
            txtPengarang.Size = new Size(137, 23);
            txtPengarang.TabIndex = 8;
            // 
            // txtPenerbit
            // 
            txtPenerbit.Location = new Point(167, 146);
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.Size = new Size(182, 23);
            txtPenerbit.TabIndex = 9;
            // 
            // txtTahunTerbit
            // 
            txtTahunTerbit.Location = new Point(167, 178);
            txtTahunTerbit.Name = "txtTahunTerbit";
            txtTahunTerbit.Size = new Size(55, 23);
            txtTahunTerbit.TabIndex = 10;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(104, 222);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(198, 222);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnTutup
            // 
            btnTutup.Location = new Point(292, 222);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(75, 23);
            btnTutup.TabIndex = 13;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = true;
            // 
            // dgvBuku
            // 
            dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuku.Location = new Point(12, 271);
            dgvBuku.Name = "dgvBuku";
            dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuku.Size = new Size(472, 150);
            dgvBuku.TabIndex = 14;
            dgvBuku.CellClick += dgvBuku_CellClick;
            // 
            // FormBuku
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 450);
            Controls.Add(dgvBuku);
            Controls.Add(btnTutup);
            Controls.Add(btnHapus);
            Controls.Add(btnSimpan);
            Controls.Add(txtTahunTerbit);
            Controls.Add(txtPenerbit);
            Controls.Add(txtPengarang);
            Controls.Add(txtJudul);
            Controls.Add(txtISBN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBuku";
            Text = "Form Buku";
            Load += FormBuku_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtISBN;
        private TextBox txtJudul;
        private TextBox txtPengarang;
        private TextBox txtPenerbit;
        private TextBox txtTahunTerbit;
        private Button btnSimpan;
        private Button btnHapus;
        private Button btnTutup;
        private DataGridView dgvBuku;
    }
}
