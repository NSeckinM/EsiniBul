
namespace EsiniBul
{
    partial class YeniOyunForm
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
            this.gboSeviyesi = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOyunuBaşlat = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.gboSeviyesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSeviyesi
            // 
            this.gboSeviyesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboSeviyesi.Controls.Add(this.label3);
            this.gboSeviyesi.Controls.Add(this.label2);
            this.gboSeviyesi.Controls.Add(this.label1);
            this.gboSeviyesi.Controls.Add(this.rbZor);
            this.gboSeviyesi.Controls.Add(this.rbOrta);
            this.gboSeviyesi.Controls.Add(this.rbKolay);
            this.gboSeviyesi.Location = new System.Drawing.Point(77, 55);
            this.gboSeviyesi.Margin = new System.Windows.Forms.Padding(4);
            this.gboSeviyesi.Name = "gboSeviyesi";
            this.gboSeviyesi.Padding = new System.Windows.Forms.Padding(4);
            this.gboSeviyesi.Size = new System.Drawing.Size(331, 301);
            this.gboSeviyesi.TabIndex = 0;
            this.gboSeviyesi.TabStop = false;
            this.gboSeviyesi.Text = "Zorluk Seviyesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "(8 x 8)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "(6 x 6)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "(4 x 4)";
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Location = new System.Drawing.Point(66, 202);
            this.rbZor.Margin = new System.Windows.Forms.Padding(4);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(57, 24);
            this.rbZor.TabIndex = 2;
            this.rbZor.Text = "Zor";
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(66, 128);
            this.rbOrta.Margin = new System.Windows.Forms.Padding(4);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(67, 24);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Checked = true;
            this.rbKolay.Location = new System.Drawing.Point(66, 60);
            this.rbKolay.Margin = new System.Windows.Forms.Padding(4);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(76, 24);
            this.rbKolay.TabIndex = 0;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay";
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaşlat
            // 
            this.btnOyunuBaşlat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOyunuBaşlat.Location = new System.Drawing.Point(77, 380);
            this.btnOyunuBaşlat.Margin = new System.Windows.Forms.Padding(4);
            this.btnOyunuBaşlat.Name = "btnOyunuBaşlat";
            this.btnOyunuBaşlat.Size = new System.Drawing.Size(331, 50);
            this.btnOyunuBaşlat.TabIndex = 1;
            this.btnOyunuBaşlat.Text = "Oyunu Başlat";
            this.btnOyunuBaşlat.UseVisualStyleBackColor = true;
            this.btnOyunuBaşlat.Click += new System.EventHandler(this.btnOyunuBaşlat_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(77, 437);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(331, 47);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Oyunu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // YeniOyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 496);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnOyunuBaşlat);
            this.Controls.Add(this.gboSeviyesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YeniOyunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşini Bul";
            this.gboSeviyesi.ResumeLayout(false);
            this.gboSeviyesi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSeviyesi;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOyunuBaşlat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
    }
}