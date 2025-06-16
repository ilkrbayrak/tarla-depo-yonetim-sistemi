namespace TarlaDepoSistemi
{
    partial class FrmTarlaEkle
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
            txtTarlaAdi = new TextBox();
            txtKonum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbCiftci = new ComboBox();
            btnEkle = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtTarlaAdi
            // 
            txtTarlaAdi.BorderStyle = BorderStyle.None;
            txtTarlaAdi.Location = new Point(200, 132);
            txtTarlaAdi.Name = "txtTarlaAdi";
            txtTarlaAdi.Size = new Size(170, 23);
            txtTarlaAdi.TabIndex = 0;
            txtTarlaAdi.TextChanged += txtTarlaAdi_TextChanged;
            // 
            // txtKonum
            // 
            txtKonum.BackColor = Color.AliceBlue;
            txtKonum.BorderStyle = BorderStyle.None;
            txtKonum.Location = new Point(201, 208);
            txtKonum.Name = "txtKonum";
            txtKonum.Size = new Size(169, 23);
            txtKonum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 135);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 2;
            label1.Text = "Tarla Adı";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 211);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 3;
            label2.Text = "Konum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 287);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 4;
            label3.Text = "Çiftçi seçmek için";
            // 
            // cmbCiftci
            // 
            cmbCiftci.BackColor = Color.AliceBlue;
            cmbCiftci.FormattingEnabled = true;
            cmbCiftci.Location = new Point(201, 287);
            cmbCiftci.Name = "cmbCiftci";
            cmbCiftci.Size = new Size(169, 31);
            cmbCiftci.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Cursor = Cursors.IBeam;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(200, 374);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(170, 73);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "➕ Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(29, 30);
            label4.Name = "label4";
            label4.Size = new Size(350, 50);
            label4.TabIndex = 7;
            label4.Text = "🌾 Yeni Tarla Ekle";
            // 
            // FrmTarlaEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(420, 518);
            Controls.Add(label4);
            Controls.Add(btnEkle);
            Controls.Add(cmbCiftci);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKonum);
            Controls.Add(txtTarlaAdi);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmTarlaEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmTarlaEkle";
            Load += FrmTarlaEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarlaAdi;
        private TextBox txtKonum;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbCiftci;
        private Button btnEkle;
        private Label label4;
    }
}