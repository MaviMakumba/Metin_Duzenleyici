/****************************************************************************
**				SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				B�LG�SAYAR M�HEND�SL��� B�L�M�
**				NESNEYE DAYALI PROGRAMLAMA DERS�
**				2023-2024 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........: 1.�DEV
**				��RENC� ADI............: EREN KARTAL   
**				��RENC� NUMARASI.......: B231210065
**              DERS�N ALINDI�I GRUP...: 1.��RET�M B GRUBU
****************************************************************************/

//TAKIP - T�rk�e Anla��l�r Kelime ��lem Program� 
//Projede kullan�lan ikonlar kaynak koduna eklenmi�tir.


using Microsoft.Office.Interop.Word;            //Eklenmi� Word K�t�phanesini Kullanma
using word = Microsoft.Office.Interop.Word;     //Kullan�m Kolayl���

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

        //DOSYA MEN�S�

        //Yeni
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Yeni ��lemlere Ge�meden �nce Kaydetmek �ster Misiniz ?","UYARI",MessageBoxButtons.YesNoCancel);
            if (result==DialogResult.Yes)
            {
                saveFileDialog1.Title = "TXT Olarak Kaydetme";                                          //Kaydetme penceresinde yazacak mesaj.
                saveFileDialog1.FileName = "�simsiz Metin Belgesi";                                     //Metin belgesinin default ismi.
                saveFileDialog1.Filter = "Metin Dosyas�(*.txt)|*.txt";                                  //Kaydetme t�r�

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);   //Kaydetme ��lemi
                    MessageBox.Show("Kay�t i�lemi ba�ar�yla ger�ekle�ti.");                             //Kay�t i�lemi ger�ekle�ti mesaj�.
                    richTextBox1.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Kay�t i�lemi ger�ekle�medi.");                                     //Kay�t i�lemi ger�ekle�medi mesaj�.
                }
            }

            else if (result==DialogResult.No) 
            {
                richTextBox1.Text= string.Empty;
            }
        }

        //Word'le A�
        private void worddeA�ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            word.Application WordAc = new word.Application();
            WordAc.Visible = true;
            word.Document aktar;
            aktar = WordAc.Documents.Add(System.Reflection.Missing.Value);
            WordAc.Selection.TypeText(richTextBox1.Text);

        }

        //Dosya A�
        private void dosyaA�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();                                                           //Kullan�c�ya dosya se�tirme
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);       //Se�ilen dosyadaki metni Richtextbox' a aktarma
        }

        //Dosya Kaydet
        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "TXT Olarak Kaydetme";                                          //Kaydetme penceresinde yazacak mesaj.
            saveFileDialog1.FileName = "�simsiz Metin Belgesi";                                     //Metin belgesinin default ismi.
            saveFileDialog1.Filter = "Metin Dosyas�(*.txt)|*.txt";                                  //Kaydetme t�r�

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);   //Kaydetme ��lemi
                MessageBox.Show("Kay�t i�lemi ba�ar�yla ger�ekle�ti.");                             //Kay�t i�lemi ger�ekle�ti mesaj�.
            }

            else
            {
                MessageBox.Show("Kay�t i�lemi ger�ekle�medi.");                                     //Kay�t i�lemi ger�ekle�medi mesaj�.
            }
        }

        //��k��
        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result=MessageBox.Show("Programdan ��k�� Yapmak �stedi�inize Emin Misiniz ?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.No==result)
            {
                MessageBox.Show("Yanl�� Alarm, Devam Edebilirsiniz", "Yeniden Ho�geldiniz");
            }

            else
            {
                this.Close();                 //Program� kapat�r.
            }
                                                                                
        }

        //AYARLAR MEN�S�

        //Font 
        private void yaz��e�itiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();                                                               //Kullan�c�ya font men�s� d�nd�r�r.     
            richTextBox1.SelectionFont = fontDialog1.Font;                                          //Se�ilen fontu uygular.
        }

        //Yaz� Rengi
        private void yaz�RengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();                                                              //Kullan�c�ya renk men�s� d�nd�r�r.
            richTextBox1.SelectionColor = colorDialog1.Color;                                       //Se�ilen rengi uygular.
        }

        //Zemin Rengi
        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        //B���M MEN�S�

        //Kes (Men�)
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //Kopyala (Men�)
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //Yap��t�r (Men�)
        private void yap��t�rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //FARE MEN�LER�

        //Kes (Sa� T�k)
        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //Kopyala (Sa� T�k)
        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //Yap��t�r (Sa� T�k)
        private void yap��t�rToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


        //G�R�N�M MEN�S�

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
