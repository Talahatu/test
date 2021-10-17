
namespace _160420014_MichaelTalahatu_JualBeliForm
{
    partial class formDaftarKategoriView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKategori = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAFTAR KATEGORI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.textBoxCari);
            this.panel1.Controls.Add(this.comboBoxCari);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 56);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(401, 14);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(363, 26);
            this.textBoxCari.TabIndex = 3;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "Kode Katageri",
            "Nama Kategori"});
            this.comboBoxCari.Location = new System.Drawing.Point(180, 14);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(206, 28);
            this.comboBoxCari.TabIndex = 2;
            this.comboBoxCari.SelectedIndexChanged += new System.EventHandler(this.comboBoxCari_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewKategori
            // 
            this.dataGridViewKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategori.Location = new System.Drawing.Point(12, 160);
            this.dataGridViewKategori.Name = "dataGridViewKategori";
            this.dataGridViewKategori.RowHeadersWidth = 62;
            this.dataGridViewKategori.RowTemplate.Height = 28;
            this.dataGridViewKategori.Size = new System.Drawing.Size(776, 220);
            this.dataGridViewKategori.TabIndex = 2;
            this.dataGridViewKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(72, 390);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(151, 52);
            this.buttonTambah.TabIndex = 3;
            this.buttonTambah.Text = "&Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Navy;
            this.buttonUbah.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.White;
            this.buttonUbah.Location = new System.Drawing.Point(229, 390);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(138, 52);
            this.buttonUbah.TabIndex = 4;
            this.buttonUbah.Text = "&Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Navy;
            this.buttonHapus.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.Location = new System.Drawing.Point(387, 390);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(138, 52);
            this.buttonHapus.TabIndex = 5;
            this.buttonHapus.Text = "&Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(650, 390);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(138, 52);
            this.buttonKeluar.TabIndex = 6;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // formDaftarKategoriView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewKategori);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "formDaftarKategoriView";
            this.Text = "Daftar Kategori";
            this.Load += new System.EventHandler(this.formDaftarKategoriView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewKategori;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonKeluar;
    }
}

