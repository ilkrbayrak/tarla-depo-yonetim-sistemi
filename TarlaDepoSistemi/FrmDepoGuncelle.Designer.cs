namespace TarlaDepoSistemi
{
    partial class FrmDepoGuncelle
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDepoAdi = new TextBox();
            txtKonum = new TextBox();
            nudKapasite = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudKapasite).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(157, 380);
            button1.Name = "button1";
            button1.Size = new Size(169, 76);
            button1.TabIndex = 0;
            button1.Text = "💾 Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 145);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 1;
            label1.Text = "Depo Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 218);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 2;
            label2.Text = "Konum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 296);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 3;
            label3.Text = "Kapasite";
            label3.Click += label3_Click;
            // 
            // txtDepoAdi
            // 
            txtDepoAdi.BackColor = Color.AliceBlue;
            txtDepoAdi.Location = new Point(157, 142);
            txtDepoAdi.Name = "txtDepoAdi";
            txtDepoAdi.Size = new Size(169, 30);
            txtDepoAdi.TabIndex = 4;
            // 
            // txtKonum
            // 
            txtKonum.BackColor = Color.AliceBlue;
            txtKonum.Location = new Point(157, 215);
            txtKonum.Name = "txtKonum";
            txtKonum.Size = new Size(169, 30);
            txtKonum.TabIndex = 5;
            // 
            // nudKapasite
            // 
            nudKapasite.BackColor = Color.AliceBlue;
            nudKapasite.Location = new Point(157, 289);
            nudKapasite.Name = "nudKapasite";
            nudKapasite.Size = new Size(169, 30);
            nudKapasite.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(36, 43);
            label4.Name = "label4";
            label4.Size = new Size(321, 31);
            label4.TabIndex = 7;
            label4.Text = "✏️ Depo Bilgilerini Güncelle";
            // 
            // FrmDepoGuncelle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(378, 518);
            Controls.Add(label4);
            Controls.Add(nudKapasite);
            Controls.Add(txtKonum);
            Controls.Add(txtDepoAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "FrmDepoGuncelle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmDepoGuncelle";
            ((System.ComponentModel.ISupportInitialize)nudKapasite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDepoAdi;
        private TextBox txtKonum;
        private NumericUpDown nudKapasite;
        private Label label4;
    }
}