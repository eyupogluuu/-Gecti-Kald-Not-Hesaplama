
namespace SınavOrtalamaHesaplama_Gecti_Kaldı_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.texts1 = new System.Windows.Forms.TextBox();
            this.texts2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texts3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texts4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonhesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelortalama = new System.Windows.Forms.Label();
            this.labeldurum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınav 1:";
            // 
            // texts1
            // 
            this.texts1.Location = new System.Drawing.Point(120, 48);
            this.texts1.Name = "texts1";
            this.texts1.Size = new System.Drawing.Size(100, 29);
            this.texts1.TabIndex = 1;
            // 
            // texts2
            // 
            this.texts2.Location = new System.Drawing.Point(120, 97);
            this.texts2.Name = "texts2";
            this.texts2.Size = new System.Drawing.Size(100, 29);
            this.texts2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sınav 2:";
            // 
            // texts3
            // 
            this.texts3.Location = new System.Drawing.Point(120, 146);
            this.texts3.Name = "texts3";
            this.texts3.Size = new System.Drawing.Size(100, 29);
            this.texts3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sınav 3:";
            // 
            // texts4
            // 
            this.texts4.Location = new System.Drawing.Point(120, 195);
            this.texts4.Name = "texts4";
            this.texts4.Size = new System.Drawing.Size(100, 29);
            this.texts4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proje:";
            // 
            // buttonhesapla
            // 
            this.buttonhesapla.Location = new System.Drawing.Point(114, 242);
            this.buttonhesapla.Name = "buttonhesapla";
            this.buttonhesapla.Size = new System.Drawing.Size(96, 37);
            this.buttonhesapla.TabIndex = 8;
            this.buttonhesapla.Text = "Hesapla";
            this.buttonhesapla.UseVisualStyleBackColor = true;
            this.buttonhesapla.Click += new System.EventHandler(this.buttonhesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ortalamanız:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum:";
            // 
            // labelortalama
            // 
            this.labelortalama.AutoSize = true;
            this.labelortalama.Location = new System.Drawing.Point(126, 37);
            this.labelortalama.Name = "labelortalama";
            this.labelortalama.Size = new System.Drawing.Size(0, 24);
            this.labelortalama.TabIndex = 11;
            // 
            // labeldurum
            // 
            this.labeldurum.AutoSize = true;
            this.labeldurum.Location = new System.Drawing.Point(115, 66);
            this.labeldurum.Name = "labeldurum";
            this.labeldurum.Size = new System.Drawing.Size(0, 24);
            this.labeldurum.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labeldurum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelortalama);
            this.groupBox1.Location = new System.Drawing.Point(258, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 122);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuçlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(533, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonhesapla);
            this.Controls.Add(this.texts4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texts3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texts2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texts1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texts1;
        private System.Windows.Forms.TextBox texts2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texts3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texts4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonhesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelortalama;
        private System.Windows.Forms.Label labeldurum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

