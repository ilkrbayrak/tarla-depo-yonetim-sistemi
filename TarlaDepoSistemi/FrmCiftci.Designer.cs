namespace TarlaDepoSistemi
{
    partial class FrmCiftci
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
            dgvCiftciler = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCiftciler).BeginInit();
            SuspendLayout();
            // 
            // dgvCiftciler
            // 
            dgvCiftciler.BorderStyle = BorderStyle.None;
            dgvCiftciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiftciler.GridColor = SystemColors.ControlDark;
            dgvCiftciler.Location = new Point(12, 57);
            dgvCiftciler.Name = "dgvCiftciler";
            dgvCiftciler.RowHeadersWidth = 51;
            dgvCiftciler.Size = new Size(723, 316);
            dgvCiftciler.TabIndex = 0;
            dgvCiftciler.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = SystemColors.ControlText;
            btnEkle.Location = new Point(755, 57);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(116, 87);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += button1_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaption;
            btnGuncelle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(755, 166);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(116, 92);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(755, 279);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(116, 94);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Image = Properties.Resources.icons8_farmer_48;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(202, 7);
            label1.Name = "label1";
            label1.Size = new Size(287, 41);
            label1.TabIndex = 4;
            label1.Text = "       Çiftçi İşlemleri\r\n";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmCiftci
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(886, 382);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvCiftciler);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCiftci";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCiftci";
            Load += FrmCiftci_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCiftciler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCiftciler;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label1;
    }
}