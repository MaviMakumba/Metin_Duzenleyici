/****************************************************************************
**				SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSÝ
**				2023-2024 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: 1.ÖDEV
**				ÖÐRENCÝ ADI............: EREN KARTAL   
**				ÖÐRENCÝ NUMARASI.......: B231210065
**              DERSÝN ALINDIÐI GRUP...: 1.ÖÐRETÝM B GRUBU
****************************************************************************/

//TAKIP - Türkçe Anlaþýlýr Kelime Ýþlem Programý 
//Projede kullanýlan ikonlar kaynak koduna eklenmiþtir.


using Microsoft.Office.Interop.Word;            //Eklenmiþ Word Kütüphanesini Kullanma
using word = Microsoft.Office.Interop.Word;     //Kullaným Kolaylýðý

namespace Nesneye_Dayali_Programlama_Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //DOSYA MENÜSÜ

        //Yeni
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Yeni Ýþlemlere Geçmeden Önce Kaydetmek Ýster Misiniz ?","UYARI",MessageBoxButtons.YesNoCancel);
            if (result==DialogResult.Yes)
            {
                saveFileDialog1.Title = "TXT Olarak Kaydetme";                                          //Kaydetme penceresinde yazacak mesaj.
                saveFileDialog1.FileName = "Ýsimsiz Metin Belgesi";                                     //Metin belgesinin default ismi.
                saveFileDialog1.Filter = "Metin Dosyasý(*.txt)|*.txt";                                  //Kaydetme türü

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);   //Kaydetme Ýþlemi
                    MessageBox.Show("Kayýt iþlemi baþarýyla gerçekleþti.");                             //Kayýt iþlemi gerçekleþti mesajý.
                    richTextBox1.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Kayýt iþlemi gerçekleþmedi.");                                     //Kayýt iþlemi gerçekleþmedi mesajý.
                }
            }

            else if (result==DialogResult.No) 
            {
                richTextBox1.Text= string.Empty;
            }
        }

        //Word'le Aç
        private void worddeAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

            word.Application WordAc = new word.Application();
            WordAc.Visible = true;
            word.Document aktar;
            aktar = WordAc.Documents.Add(System.Reflection.Missing.Value);
            WordAc.Selection.TypeText(richTextBox1.Text);

        }

        //Dosya Aç
        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();                                                           //Kullanýcýya dosya seçtirme
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);       //Seçilen dosyadaki metni Richtextbox' a aktarma
        }

        //Dosya Kaydet
        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "TXT Olarak Kaydetme";                                          //Kaydetme penceresinde yazacak mesaj.
            saveFileDialog1.FileName = "Ýsimsiz Metin Belgesi";                                     //Metin belgesinin default ismi.
            saveFileDialog1.Filter = "Metin Dosyasý(*.txt)|*.txt";                                  //Kaydetme türü

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);   //Kaydetme Ýþlemi
                MessageBox.Show("Kayýt iþlemi baþarýyla gerçekleþti.");                             //Kayýt iþlemi gerçekleþti mesajý.
            }

            else
            {
                MessageBox.Show("Kayýt iþlemi gerçekleþmedi.");                                     //Kayýt iþlemi gerçekleþmedi mesajý.
            }
        }

        //Çýkýþ
        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result=MessageBox.Show("Programdan Çýkýþ Yapmak Ýstediðinize Emin Misiniz ?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.No==result)
            {
                MessageBox.Show("Yanlýþ Alarm, Devam Edebilirsiniz", "Yeniden Hoþgeldiniz");
            }

            else
            {
                this.Close();                 //Programý kapatýr.
            }
                                                                                
        }

        //AYARLAR MENÜSÜ

        //Font 
        private void yazýÇeþitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();                                                               //Kullanýcýya font menüsü döndürür.     
            richTextBox1.SelectionFont = fontDialog1.Font;                                          //Seçilen fontu uygular.
        }

        //Yazý Rengi
        private void yazýRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();                                                              //Kullanýcýya renk menüsü döndürür.
            richTextBox1.SelectionColor = colorDialog1.Color;                                       //Seçilen rengi uygular.
        }

        //Zemin Rengi
        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        //BÝÇÝM MENÜSÜ

        //Kes (Menü)
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //Kopyala (Menü)
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //Yapýþtýr (Menü)
        private void yapýþtýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //FARE MENÜLERÝ

        //Kes (Sað Týk)
        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //Kopyala (Sað Týk)
        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //Yapýþtýr (Sað Týk)
        private void yapýþtýrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


        //GÖRÜNÜM MENÜSÜ

        //Tam Ekran
        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        //Pencereli
        private void pencereliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
