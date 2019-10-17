namespace timmer_calisma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_panel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_panel2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_panel3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_süre = new System.Windows.Forms.Label();
            this.lbl_yorum = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_cikis = new System.Windows.Forms.Button();
            this.button_yeniden = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_panel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_panel1
            // 
            this.lbl_panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_panel1.Location = new System.Drawing.Point(865, 3);
            this.lbl_panel1.Name = "lbl_panel1";
            this.lbl_panel1.Size = new System.Drawing.Size(10, 94);
            this.lbl_panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_panel2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_panel2
            // 
            this.lbl_panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_panel2.Location = new System.Drawing.Point(865, 0);
            this.lbl_panel2.Name = "lbl_panel2";
            this.lbl_panel2.Size = new System.Drawing.Size(10, 97);
            this.lbl_panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_panel3);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(3, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_panel3
            // 
            this.lbl_panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_panel3.Location = new System.Drawing.Point(865, 6);
            this.lbl_panel3.Name = "lbl_panel3";
            this.lbl_panel3.Size = new System.Drawing.Size(10, 94);
            this.lbl_panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_süre
            // 
            this.label_süre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label_süre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_süre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_süre.ForeColor = System.Drawing.Color.Yellow;
            this.label_süre.Location = new System.Drawing.Point(130, 341);
            this.label_süre.Name = "label_süre";
            this.label_süre.Size = new System.Drawing.Size(100, 58);
            this.label_süre.TabIndex = 4;
            this.label_süre.Text = "00";
            this.label_süre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_yorum
            // 
            this.lbl_yorum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_yorum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_yorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yorum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_yorum.Location = new System.Drawing.Point(257, 341);
            this.lbl_yorum.Name = "lbl_yorum";
            this.lbl_yorum.Size = new System.Drawing.Size(696, 58);
            this.lbl_yorum.TabIndex = 4;
            this.lbl_yorum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_cikis
            // 
            this.button_cikis.BackColor = System.Drawing.Color.Lime;
            this.button_cikis.Location = new System.Drawing.Point(6, 366);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(94, 33);
            this.button_cikis.TabIndex = 5;
            this.button_cikis.Text = "ÇIKIŞ";
            this.button_cikis.UseVisualStyleBackColor = false;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // button_yeniden
            // 
            this.button_yeniden.BackColor = System.Drawing.Color.Lime;
            this.button_yeniden.Location = new System.Drawing.Point(6, 327);
            this.button_yeniden.Name = "button_yeniden";
            this.button_yeniden.Size = new System.Drawing.Size(94, 34);
            this.button_yeniden.TabIndex = 6;
            this.button_yeniden.Text = "YENİDEN BAŞLA";
            this.button_yeniden.UseVisualStyleBackColor = false;
            this.button_yeniden.Click += new System.EventHandler(this.button_yeniden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(954, 420);
            this.Controls.Add(this.button_yeniden);
            this.Controls.Add(this.button_cikis);
            this.Controls.Add(this.lbl_yorum);
            this.Controls.Add(this.label_süre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AT YARIŞI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_süre;
        private System.Windows.Forms.Label lbl_yorum;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_panel1;
        private System.Windows.Forms.Label lbl_panel2;
        private System.Windows.Forms.Label lbl_panel3;
        private System.Windows.Forms.Button button_cikis;
        private System.Windows.Forms.Button button_yeniden;
    }
}

