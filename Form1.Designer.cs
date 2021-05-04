namespace Udemy.TopluMail.Goruntule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd_musteri = new System.Windows.Forms.DataGridView();
            this.btn_ornekdata = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_musteri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd_musteri);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kayıt Listesi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grd_musteri
            // 
            this.grd_musteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_musteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_musteri.Location = new System.Drawing.Point(3, 16);
            this.grd_musteri.Name = "grd_musteri";
            this.grd_musteri.Size = new System.Drawing.Size(913, 378);
            this.grd_musteri.TabIndex = 0;
            // 
            // btn_ornekdata
            // 
            this.btn_ornekdata.Location = new System.Drawing.Point(13, 415);
            this.btn_ornekdata.Name = "btn_ornekdata";
            this.btn_ornekdata.Size = new System.Drawing.Size(832, 23);
            this.btn_ornekdata.TabIndex = 1;
            this.btn_ornekdata.Text = "Örnek Data Oluştur";
            this.btn_ornekdata.UseVisualStyleBackColor = true;
            this.btn_ornekdata.Click += new System.EventHandler(this.btn_ornekdata_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(852, 415);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(80, 23);
            this.btn_yenile.TabIndex = 2;
            this.btn_yenile.Text = "yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_ornekdata);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Görüntüleme Ekranı ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_musteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd_musteri;
        private System.Windows.Forms.Button btn_ornekdata;
        private System.Windows.Forms.Button btn_yenile;
    }
}

