namespace WindowsFormsApp1
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
            this.dizin = new System.Windows.Forms.TextBox();
            this.calistir_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dsAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dizin
            // 
            this.dizin.Location = new System.Drawing.Point(104, 53);
            this.dizin.Name = "dizin";
            this.dizin.Size = new System.Drawing.Size(271, 20);
            this.dizin.TabIndex = 0;
            // 
            // calistir_btn
            // 
            this.calistir_btn.Location = new System.Drawing.Point(381, 9);
            this.calistir_btn.Name = "calistir_btn";
            this.calistir_btn.Size = new System.Drawing.Size(111, 64);
            this.calistir_btn.TabIndex = 1;
            this.calistir_btn.Text = "Siteleri Çalıştır";
            this.calistir_btn.UseVisualStyleBackColor = true;
            this.calistir_btn.Click += new System.EventHandler(this.calistir_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dosya Adı Giriniz";
            // 
            // dsAd
            // 
            this.dsAd.Location = new System.Drawing.Point(104, 9);
            this.dsAd.Name = "dsAd";
            this.dsAd.Size = new System.Drawing.Size(271, 20);
            this.dsAd.TabIndex = 3;
            this.dsAd.Text = "index.html";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(149, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bulunan Dizindeki dosyalardan başlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dizin:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dizin Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 85);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dsAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calistir_btn);
            this.Controls.Add(this.dizin);
            this.Name = "Form1";
            this.Text = "Toplu Site Çalıştırma  **** 4 Klasöre kadar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dizin;
        private System.Windows.Forms.Button calistir_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dsAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

