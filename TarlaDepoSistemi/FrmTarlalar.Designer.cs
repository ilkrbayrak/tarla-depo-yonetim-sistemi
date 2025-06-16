namespace TarlaDepoSistemi
{
    partial class FrmTarlalar
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
            dgvTarlalar = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTarlalar).BeginInit();
            SuspendLayout();
            // 
            // dgvTarlalar
            // 
            dgvTarlalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarlalar.Location = new Point(12, 114);
            dgvTarlalar.Name = "dgvTarlalar";
            dgvTarlalar.RowHeadersWidth = 51;
            dgvTarlalar.Size = new Size(601, 324);
            dgvTarlalar.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(631, 114);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 81);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaption;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(631, 233);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(125, 82);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(631, 352);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(125, 86);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(161, 27);
            label1.Name = "label1";
            label1.Size = new Size(344, 50);
            label1.TabIndex = 4;
            label1.Text = "🌾 Tarla İşlemleri";
            // 
            // FrmTarlalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(782, 450);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvTarlalar);
            Name = "FrmTarlalar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmTarlalar";
            Load += FrmTarlalar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTarlalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTarlalar;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label1;
    }
}