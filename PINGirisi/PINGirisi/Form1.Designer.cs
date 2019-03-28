namespace PINGirisi
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
            this.lblHak = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalan Hak: ";
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Location = new System.Drawing.Point(64, 9);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(13, 13);
            this.lblHak.TabIndex = 1;
            this.lblHak.Text = "3";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(9, 25);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(160, 20);
            this.txtPin.TabIndex = 2;
            this.txtPin.Text = "PIN\'i Giriniz";
            this.txtPin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPin_MouseDown);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(45, 51);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(92, 32);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 88);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnGiris;
    }
}

