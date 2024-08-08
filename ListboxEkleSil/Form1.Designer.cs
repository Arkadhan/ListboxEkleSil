
namespace ListboxEkleSil
{
    partial class Form1
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
            this.lbSayiİsim = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblElemanSayisi = new System.Windows.Forms.Label();
            this.tbIsim = new System.Windows.Forms.TextBox();
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.btnİsimEkle = new System.Windows.Forms.Button();
            this.btnTumSil = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnSayiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSayiİsim
            // 
            this.lbSayiİsim.FormattingEnabled = true;
            this.lbSayiİsim.Location = new System.Drawing.Point(22, 27);
            this.lbSayiİsim.Name = "lbSayiİsim";
            this.lbSayiİsim.Size = new System.Drawing.Size(120, 238);
            this.lbSayiİsim.TabIndex = 0;
            this.lbSayiİsim.SelectedIndexChanged += new System.EventHandler(this.lbSayiİsim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim Gir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı Gir";
            // 
            // lblElemanSayisi
            // 
            this.lblElemanSayisi.AutoSize = true;
            this.lblElemanSayisi.Location = new System.Drawing.Point(186, 252);
            this.lblElemanSayisi.Name = "lblElemanSayisi";
            this.lblElemanSayisi.Size = new System.Drawing.Size(75, 13);
            this.lblElemanSayisi.TabIndex = 3;
            this.lblElemanSayisi.Text = "Eleman Sayısı:";
            // 
            // tbIsim
            // 
            this.tbIsim.Location = new System.Drawing.Point(186, 72);
            this.tbIsim.Name = "tbIsim";
            this.tbIsim.Size = new System.Drawing.Size(100, 20);
            this.tbIsim.TabIndex = 4;
            // 
            // tbSayi
            // 
            this.tbSayi.Location = new System.Drawing.Point(188, 135);
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(100, 20);
            this.tbSayi.TabIndex = 5;
            // 
            // btnİsimEkle
            // 
            this.btnİsimEkle.Location = new System.Drawing.Point(292, 70);
            this.btnİsimEkle.Name = "btnİsimEkle";
            this.btnİsimEkle.Size = new System.Drawing.Size(75, 23);
            this.btnİsimEkle.TabIndex = 6;
            this.btnİsimEkle.Text = "Ekle";
            this.btnİsimEkle.UseVisualStyleBackColor = true;
            this.btnİsimEkle.Click += new System.EventHandler(this.btnİsimEkle_Click);
            // 
            // btnTumSil
            // 
            this.btnTumSil.Location = new System.Drawing.Point(189, 161);
            this.btnTumSil.Name = "btnTumSil";
            this.btnTumSil.Size = new System.Drawing.Size(75, 69);
            this.btnTumSil.TabIndex = 8;
            this.btnTumSil.Text = "Tümünü Sil";
            this.btnTumSil.UseVisualStyleBackColor = true;
            this.btnTumSil.Click += new System.EventHandler(this.btnTumSil_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.Location = new System.Drawing.Point(294, 161);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(75, 69);
            this.btnSecSil.TabIndex = 9;
            this.btnSecSil.Text = "Seçili Olanı Sil";
            this.btnSecSil.UseVisualStyleBackColor = true;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnSayiEkle
            // 
            this.btnSayiEkle.Location = new System.Drawing.Point(294, 132);
            this.btnSayiEkle.Name = "btnSayiEkle";
            this.btnSayiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSayiEkle.TabIndex = 10;
            this.btnSayiEkle.Text = "Ekle";
            this.btnSayiEkle.UseVisualStyleBackColor = true;
            this.btnSayiEkle.Click += new System.EventHandler(this.btnSayiEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 293);
            this.Controls.Add(this.btnSayiEkle);
            this.Controls.Add(this.btnSecSil);
            this.Controls.Add(this.btnTumSil);
            this.Controls.Add(this.btnİsimEkle);
            this.Controls.Add(this.tbSayi);
            this.Controls.Add(this.tbIsim);
            this.Controls.Add(this.lblElemanSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSayiİsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayiİsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblElemanSayisi;
        private System.Windows.Forms.TextBox tbIsim;
        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.Button btnİsimEkle;
        private System.Windows.Forms.Button btnTumSil;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnSayiEkle;
    }
}

