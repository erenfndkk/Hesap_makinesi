namespace hesap_makinesi
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
            this.label1_ekran = new System.Windows.Forms.Label();
            this.button1Rakam = new System.Windows.Forms.Button();
            this.button2Rakam = new System.Windows.Forms.Button();
            this.button3Rakam = new System.Windows.Forms.Button();
            this.button13_toplama = new System.Windows.Forms.Button();
            this.button14_cikarma = new System.Windows.Forms.Button();
            this.button6Rakam = new System.Windows.Forms.Button();
            this.button5Rakam = new System.Windows.Forms.Button();
            this.button4Rakam = new System.Windows.Forms.Button();
            this.button15_carpma = new System.Windows.Forms.Button();
            this.button9Rakam = new System.Windows.Forms.Button();
            this.button8Rakam = new System.Windows.Forms.Button();
            this.button7Rakam = new System.Windows.Forms.Button();
            this.button16_bolme = new System.Windows.Forms.Button();
            this.button12_esittir = new System.Windows.Forms.Button();
            this.button11_0_Rakamı = new System.Windows.Forms.Button();
            this.button10_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_ekran
            // 
            this.label1_ekran.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1_ekran.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_ekran.Location = new System.Drawing.Point(12, 9);
            this.label1_ekran.Name = "label1_ekran";
            this.label1_ekran.Size = new System.Drawing.Size(201, 55);
            this.label1_ekran.TabIndex = 0;
            this.label1_ekran.Text = "0";
            this.label1_ekran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1_ekran.Click += new System.EventHandler(this.label1_ekran_Click);
            // 
            // button1Rakam
            // 
            this.button1Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1Rakam.Location = new System.Drawing.Point(12, 67);
            this.button1Rakam.Name = "button1Rakam";
            this.button1Rakam.Size = new System.Drawing.Size(46, 43);
            this.button1Rakam.TabIndex = 1;
            this.button1Rakam.Text = "1";
            this.button1Rakam.UseVisualStyleBackColor = false;
            this.button1Rakam.Click += new System.EventHandler(this.button1Rakam_Click);
            // 
            // button2Rakam
            // 
            this.button2Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2Rakam.Location = new System.Drawing.Point(64, 67);
            this.button2Rakam.Name = "button2Rakam";
            this.button2Rakam.Size = new System.Drawing.Size(46, 43);
            this.button2Rakam.TabIndex = 2;
            this.button2Rakam.Text = "2";
            this.button2Rakam.UseVisualStyleBackColor = false;
            this.button2Rakam.Click += new System.EventHandler(this.button2Rakam_Click);
            // 
            // button3Rakam
            // 
            this.button3Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3Rakam.Location = new System.Drawing.Point(116, 67);
            this.button3Rakam.Name = "button3Rakam";
            this.button3Rakam.Size = new System.Drawing.Size(46, 43);
            this.button3Rakam.TabIndex = 3;
            this.button3Rakam.Text = "3";
            this.button3Rakam.UseVisualStyleBackColor = false;
            this.button3Rakam.Click += new System.EventHandler(this.button3_Click);
            // 
            // button13_toplama
            // 
            this.button13_toplama.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button13_toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13_toplama.Location = new System.Drawing.Point(168, 67);
            this.button13_toplama.Name = "button13_toplama";
            this.button13_toplama.Size = new System.Drawing.Size(46, 43);
            this.button13_toplama.TabIndex = 4;
            this.button13_toplama.Text = "+";
            this.button13_toplama.UseVisualStyleBackColor = false;
            this.button13_toplama.Click += new System.EventHandler(this.button13_toplama_Click);
            // 
            // button14_cikarma
            // 
            this.button14_cikarma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button14_cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14_cikarma.Location = new System.Drawing.Point(168, 116);
            this.button14_cikarma.Name = "button14_cikarma";
            this.button14_cikarma.Size = new System.Drawing.Size(46, 43);
            this.button14_cikarma.TabIndex = 8;
            this.button14_cikarma.Text = "-";
            this.button14_cikarma.UseVisualStyleBackColor = false;
            this.button14_cikarma.Click += new System.EventHandler(this.button14_cikarma_Click);
            // 
            // button6Rakam
            // 
            this.button6Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6Rakam.Location = new System.Drawing.Point(116, 116);
            this.button6Rakam.Name = "button6Rakam";
            this.button6Rakam.Size = new System.Drawing.Size(46, 43);
            this.button6Rakam.TabIndex = 7;
            this.button6Rakam.Text = "6";
            this.button6Rakam.UseVisualStyleBackColor = false;
            this.button6Rakam.Click += new System.EventHandler(this.button6Rakam_Click);
            // 
            // button5Rakam
            // 
            this.button5Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5Rakam.Location = new System.Drawing.Point(64, 116);
            this.button5Rakam.Name = "button5Rakam";
            this.button5Rakam.Size = new System.Drawing.Size(46, 43);
            this.button5Rakam.TabIndex = 6;
            this.button5Rakam.Text = "5";
            this.button5Rakam.UseVisualStyleBackColor = false;
            this.button5Rakam.Click += new System.EventHandler(this.button5Rakam_Click);
            // 
            // button4Rakam
            // 
            this.button4Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4Rakam.Location = new System.Drawing.Point(12, 116);
            this.button4Rakam.Name = "button4Rakam";
            this.button4Rakam.Size = new System.Drawing.Size(46, 43);
            this.button4Rakam.TabIndex = 5;
            this.button4Rakam.Text = "4";
            this.button4Rakam.UseVisualStyleBackColor = false;
            this.button4Rakam.Click += new System.EventHandler(this.button4Rakam_Click);
            // 
            // button15_carpma
            // 
            this.button15_carpma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button15_carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15_carpma.Location = new System.Drawing.Point(168, 165);
            this.button15_carpma.Name = "button15_carpma";
            this.button15_carpma.Size = new System.Drawing.Size(46, 43);
            this.button15_carpma.TabIndex = 12;
            this.button15_carpma.Text = "*";
            this.button15_carpma.UseVisualStyleBackColor = false;
            this.button15_carpma.Click += new System.EventHandler(this.button15_carpma_Click);
            // 
            // button9Rakam
            // 
            this.button9Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button9Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9Rakam.Location = new System.Drawing.Point(116, 165);
            this.button9Rakam.Name = "button9Rakam";
            this.button9Rakam.Size = new System.Drawing.Size(46, 43);
            this.button9Rakam.TabIndex = 11;
            this.button9Rakam.Text = "9";
            this.button9Rakam.UseVisualStyleBackColor = false;
            this.button9Rakam.Click += new System.EventHandler(this.button9Rakam_Click);
            // 
            // button8Rakam
            // 
            this.button8Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button8Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8Rakam.Location = new System.Drawing.Point(64, 165);
            this.button8Rakam.Name = "button8Rakam";
            this.button8Rakam.Size = new System.Drawing.Size(46, 43);
            this.button8Rakam.TabIndex = 10;
            this.button8Rakam.Text = "8";
            this.button8Rakam.UseVisualStyleBackColor = false;
            this.button8Rakam.Click += new System.EventHandler(this.button8Rakam_Click);
            // 
            // button7Rakam
            // 
            this.button7Rakam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button7Rakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7Rakam.Location = new System.Drawing.Point(12, 165);
            this.button7Rakam.Name = "button7Rakam";
            this.button7Rakam.Size = new System.Drawing.Size(46, 43);
            this.button7Rakam.TabIndex = 9;
            this.button7Rakam.Text = "7";
            this.button7Rakam.UseVisualStyleBackColor = false;
            this.button7Rakam.Click += new System.EventHandler(this.button7Rakam_Click);
            // 
            // button16_bolme
            // 
            this.button16_bolme.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button16_bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16_bolme.Location = new System.Drawing.Point(168, 214);
            this.button16_bolme.Name = "button16_bolme";
            this.button16_bolme.Size = new System.Drawing.Size(46, 43);
            this.button16_bolme.TabIndex = 16;
            this.button16_bolme.Text = "/";
            this.button16_bolme.UseVisualStyleBackColor = false;
            this.button16_bolme.Click += new System.EventHandler(this.button16_bolme_Click);
            // 
            // button12_esittir
            // 
            this.button12_esittir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button12_esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12_esittir.Location = new System.Drawing.Point(116, 214);
            this.button12_esittir.Name = "button12_esittir";
            this.button12_esittir.Size = new System.Drawing.Size(46, 43);
            this.button12_esittir.TabIndex = 15;
            this.button12_esittir.Text = "=";
            this.button12_esittir.UseVisualStyleBackColor = false;
            this.button12_esittir.Click += new System.EventHandler(this.button14_Click);
            // 
            // button11_0_Rakamı
            // 
            this.button11_0_Rakamı.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button11_0_Rakamı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11_0_Rakamı.Location = new System.Drawing.Point(64, 214);
            this.button11_0_Rakamı.Name = "button11_0_Rakamı";
            this.button11_0_Rakamı.Size = new System.Drawing.Size(46, 43);
            this.button11_0_Rakamı.TabIndex = 14;
            this.button11_0_Rakamı.Text = "0";
            this.button11_0_Rakamı.UseVisualStyleBackColor = false;
            this.button11_0_Rakamı.Click += new System.EventHandler(this.button11_0_Rakamı_Click);
            // 
            // button10_clear
            // 
            this.button10_clear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button10_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10_clear.Location = new System.Drawing.Point(12, 214);
            this.button10_clear.Name = "button10_clear";
            this.button10_clear.Size = new System.Drawing.Size(46, 43);
            this.button10_clear.TabIndex = 13;
            this.button10_clear.Text = "C";
            this.button10_clear.UseVisualStyleBackColor = false;
            this.button10_clear.Click += new System.EventHandler(this.button10_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(225, 278);
            this.Controls.Add(this.button16_bolme);
            this.Controls.Add(this.button12_esittir);
            this.Controls.Add(this.button11_0_Rakamı);
            this.Controls.Add(this.button10_clear);
            this.Controls.Add(this.button15_carpma);
            this.Controls.Add(this.button9Rakam);
            this.Controls.Add(this.button8Rakam);
            this.Controls.Add(this.button7Rakam);
            this.Controls.Add(this.button14_cikarma);
            this.Controls.Add(this.button6Rakam);
            this.Controls.Add(this.button5Rakam);
            this.Controls.Add(this.button4Rakam);
            this.Controls.Add(this.button13_toplama);
            this.Controls.Add(this.button3Rakam);
            this.Controls.Add(this.button2Rakam);
            this.Controls.Add(this.button1Rakam);
            this.Controls.Add(this.label1_ekran);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "hesap makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1_ekran;
        private System.Windows.Forms.Button button1Rakam;
        private System.Windows.Forms.Button button2Rakam;
        private System.Windows.Forms.Button button3Rakam;
        private System.Windows.Forms.Button button13_toplama;
        private System.Windows.Forms.Button button14_cikarma;
        private System.Windows.Forms.Button button6Rakam;
        private System.Windows.Forms.Button button5Rakam;
        private System.Windows.Forms.Button button4Rakam;
        private System.Windows.Forms.Button button15_carpma;
        private System.Windows.Forms.Button button9Rakam;
        private System.Windows.Forms.Button button8Rakam;
        private System.Windows.Forms.Button button7Rakam;
        private System.Windows.Forms.Button button16_bolme;
        private System.Windows.Forms.Button button12_esittir;
        private System.Windows.Forms.Button button11_0_Rakamı;
        private System.Windows.Forms.Button button10_clear;
    }
}

