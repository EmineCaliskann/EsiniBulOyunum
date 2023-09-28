namespace EsiniBulOyunum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlKartlar = new Panel();
            gboYeniOyun = new GroupBox();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            btnOyunuBaslat = new Button();
            menuStrip1 = new MenuStrip();
            oyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.Location = new Point(12, 40);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(632, 572);
            pnlKartlar.TabIndex = 0;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.Anchor = AnchorStyles.None;
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Location = new Point(171, 208);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(314, 325);
            gboYeniOyun.TabIndex = 0;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "Yeni Oyun";
            // 
            // rb5
            // 
            rb5.Anchor = AnchorStyles.None;
            rb5.AutoSize = true;
            rb5.Font = new Font("Ink Free", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb5.ForeColor = Color.Maroon;
            rb5.Location = new Point(99, 193);
            rb5.Name = "rb5";
            rb5.Size = new Size(127, 38);
            rb5.TabIndex = 5;
            rb5.TabStop = true;
            rb5.Text = "Çok Zor";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.Anchor = AnchorStyles.None;
            rb4.AutoSize = true;
            rb4.Font = new Font("Ink Free", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb4.ForeColor = Color.Maroon;
            rb4.Location = new Point(99, 151);
            rb4.Name = "rb4";
            rb4.Size = new Size(75, 38);
            rb4.TabIndex = 4;
            rb4.TabStop = true;
            rb4.Text = "Zor";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.Anchor = AnchorStyles.None;
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.Font = new Font("Ink Free", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb3.ForeColor = Color.Maroon;
            rb3.Location = new Point(99, 109);
            rb3.Name = "rb3";
            rb3.Size = new Size(94, 38);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.Anchor = AnchorStyles.None;
            rb2.AutoSize = true;
            rb2.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rb2.ForeColor = Color.Maroon;
            rb2.Location = new Point(99, 65);
            rb2.Name = "rb2";
            rb2.Size = new Size(96, 38);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.Anchor = AnchorStyles.None;
            rb1.AutoSize = true;
            rb1.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rb1.ForeColor = Color.Maroon;
            rb1.Location = new Point(99, 22);
            rb1.Name = "rb1";
            rb1.Size = new Size(148, 38);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Çok Kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOyunuBaslat.Font = new Font("NSimSun", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnOyunuBaslat.ForeColor = Color.FromArgb(128, 64, 64);
            btnOyunuBaslat.Location = new Point(40, 250);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(221, 47);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { oyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(696, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            oyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            oyunToolStripMenuItem.Size = new Size(48, 20);
            oyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(147, 22);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 631);
            Controls.Add(gboYeniOyun);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul Oyunu ";
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox gboYeniOyun;
        private Button btnOyunuBaslat;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}