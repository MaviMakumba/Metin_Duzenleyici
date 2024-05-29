namespace Nesneye_Dayali_Programlama_Odev1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            kesToolStripMenuItem1 = new ToolStripMenuItem();
            kopyalaToolStripMenuItem1 = new ToolStripMenuItem();
            yapıştırToolStripMenuItem1 = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            worddeAçToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            dosyaAçToolStripMenuItem = new ToolStripMenuItem();
            dosyaKaydetToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            biçimToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            renkToolStripMenuItem = new ToolStripMenuItem();
            yazıRengiToolStripMenuItem = new ToolStripMenuItem();
            zeminRengiToolStripMenuItem = new ToolStripMenuItem();
            yazıÇeşitiToolStripMenuItem = new ToolStripMenuItem();
            kalemToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            tamEkranToolStripMenuItem = new ToolStripMenuItem();
            pencereliToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Gainsboro;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1014, 422);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { kesToolStripMenuItem1, kopyalaToolStripMenuItem1, yapıştırToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(137, 82);
            // 
            // kesToolStripMenuItem1
            // 
            kesToolStripMenuItem1.Image = (Image)resources.GetObject("kesToolStripMenuItem1.Image");
            kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            kesToolStripMenuItem1.Size = new Size(136, 26);
            kesToolStripMenuItem1.Text = "Kes";
            kesToolStripMenuItem1.Click += kesToolStripMenuItem1_Click;
            // 
            // kopyalaToolStripMenuItem1
            // 
            kopyalaToolStripMenuItem1.Image = (Image)resources.GetObject("kopyalaToolStripMenuItem1.Image");
            kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            kopyalaToolStripMenuItem1.Size = new Size(136, 26);
            kopyalaToolStripMenuItem1.Text = "Kopyala";
            kopyalaToolStripMenuItem1.Click += kopyalaToolStripMenuItem1_Click;
            // 
            // yapıştırToolStripMenuItem1
            // 
            yapıştırToolStripMenuItem1.Image = (Image)resources.GetObject("yapıştırToolStripMenuItem1.Image");
            yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            yapıştırToolStripMenuItem1.Size = new Size(136, 26);
            yapıştırToolStripMenuItem1.Text = "Yapıştır";
            yapıştırToolStripMenuItem1.Click += yapıştırToolStripMenuItem1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, biçimToolStripMenuItem, ayarlarToolStripMenuItem, görünümToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1014, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, worddeAçToolStripMenuItem, toolStripSeparator1, dosyaAçToolStripMenuItem, dosyaKaydetToolStripMenuItem, toolStripSeparator2, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Image = (Image)resources.GetObject("yeniToolStripMenuItem.Image");
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            yeniToolStripMenuItem.Size = new Size(233, 26);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // worddeAçToolStripMenuItem
            // 
            worddeAçToolStripMenuItem.Image = (Image)resources.GetObject("worddeAçToolStripMenuItem.Image");
            worddeAçToolStripMenuItem.Name = "worddeAçToolStripMenuItem";
            worddeAçToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            worddeAçToolStripMenuItem.Size = new Size(233, 26);
            worddeAçToolStripMenuItem.Text = "Word'de Aç";
            worddeAçToolStripMenuItem.Click += worddeAçToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(230, 6);
            // 
            // dosyaAçToolStripMenuItem
            // 
            dosyaAçToolStripMenuItem.Image = (Image)resources.GetObject("dosyaAçToolStripMenuItem.Image");
            dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            dosyaAçToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            dosyaAçToolStripMenuItem.Size = new Size(233, 26);
            dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            dosyaAçToolStripMenuItem.Click += dosyaAçToolStripMenuItem_Click;
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            dosyaKaydetToolStripMenuItem.Image = (Image)resources.GetObject("dosyaKaydetToolStripMenuItem.Image");
            dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            dosyaKaydetToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            dosyaKaydetToolStripMenuItem.Size = new Size(233, 26);
            dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            dosyaKaydetToolStripMenuItem.Click += dosyaKaydetToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(230, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Image = (Image)resources.GetObject("çıkışToolStripMenuItem.Image");
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            çıkışToolStripMenuItem.Size = new Size(233, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // biçimToolStripMenuItem
            // 
            biçimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem });
            biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            biçimToolStripMenuItem.Size = new Size(60, 24);
            biçimToolStripMenuItem.Text = "Biçim";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Image = (Image)resources.GetObject("kesToolStripMenuItem.Image");
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            kesToolStripMenuItem.Size = new Size(197, 26);
            kesToolStripMenuItem.Text = "Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Image = (Image)resources.GetObject("kopyalaToolStripMenuItem.Image");
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopyalaToolStripMenuItem.Size = new Size(197, 26);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            kopyalaToolStripMenuItem.Click += kopyalaToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Image = (Image)resources.GetObject("yapıştırToolStripMenuItem.Image");
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            yapıştırToolStripMenuItem.Size = new Size(197, 26);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            yapıştırToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { renkToolStripMenuItem, yazıÇeşitiToolStripMenuItem, kalemToolStripMenuItem });
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(70, 24);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkToolStripMenuItem
            // 
            renkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yazıRengiToolStripMenuItem, zeminRengiToolStripMenuItem });
            renkToolStripMenuItem.Image = (Image)resources.GetObject("renkToolStripMenuItem.Image");
            renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            renkToolStripMenuItem.Size = new Size(158, 26);
            renkToolStripMenuItem.Text = "Renk";
            // 
            // yazıRengiToolStripMenuItem
            // 
            yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            yazıRengiToolStripMenuItem.Size = new Size(176, 26);
            yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            yazıRengiToolStripMenuItem.Click += yazıRengiToolStripMenuItem_Click;
            // 
            // zeminRengiToolStripMenuItem
            // 
            zeminRengiToolStripMenuItem.Name = "zeminRengiToolStripMenuItem";
            zeminRengiToolStripMenuItem.Size = new Size(176, 26);
            zeminRengiToolStripMenuItem.Text = "Zemin Rengi";
            zeminRengiToolStripMenuItem.Click += zeminRengiToolStripMenuItem_Click;
            // 
            // yazıÇeşitiToolStripMenuItem
            // 
            yazıÇeşitiToolStripMenuItem.Image = (Image)resources.GetObject("yazıÇeşitiToolStripMenuItem.Image");
            yazıÇeşitiToolStripMenuItem.Name = "yazıÇeşitiToolStripMenuItem";
            yazıÇeşitiToolStripMenuItem.Size = new Size(158, 26);
            yazıÇeşitiToolStripMenuItem.Text = "Yazı Çeşiti";
            yazıÇeşitiToolStripMenuItem.Click += yazıÇeşitiToolStripMenuItem_Click;
            // 
            // kalemToolStripMenuItem
            // 
            kalemToolStripMenuItem.Name = "kalemToolStripMenuItem";
            kalemToolStripMenuItem.Size = new Size(158, 26);
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tamEkranToolStripMenuItem, pencereliToolStripMenuItem });
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(84, 24);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // tamEkranToolStripMenuItem
            // 
            tamEkranToolStripMenuItem.Name = "tamEkranToolStripMenuItem";
            tamEkranToolStripMenuItem.ShortcutKeys = Keys.F11;
            tamEkranToolStripMenuItem.Size = new Size(224, 26);
            tamEkranToolStripMenuItem.Text = "Tam Ekran";
            tamEkranToolStripMenuItem.Click += tamEkranToolStripMenuItem_Click;
            // 
            // pencereliToolStripMenuItem
            // 
            pencereliToolStripMenuItem.Name = "pencereliToolStripMenuItem";
            pencereliToolStripMenuItem.ShortcutKeys = Keys.F12;
            pencereliToolStripMenuItem.Size = new Size(224, 26);
            pencereliToolStripMenuItem.Text = "Pencereli";
            pencereliToolStripMenuItem.Click += pencereliToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1014, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TAKIP";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem dosyaAçToolStripMenuItem;
        private ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem biçimToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem renkToolStripMenuItem;
        private ToolStripMenuItem yazıRengiToolStripMenuItem;
        private ToolStripMenuItem zeminRengiToolStripMenuItem;
        private ToolStripMenuItem yazıÇeşitiToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem kesToolStripMenuItem1;
        private ToolStripMenuItem kopyalaToolStripMenuItem1;
        private ToolStripMenuItem yapıştırToolStripMenuItem1;
        private ToolStripMenuItem kalemToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem worddeAçToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem tamEkranToolStripMenuItem;
        private ToolStripMenuItem pencereliToolStripMenuItem;
    }
}
