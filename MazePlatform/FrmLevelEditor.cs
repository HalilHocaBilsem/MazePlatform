using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazePlatform
{
    public partial class FrmLevelEditor : Form
    {
        int blokEbat = 50;
        Image resimCim = null;
        Image resimCimUyari = null;
        Image resimStart = null;
        Image resimFinish = null;
        Image resimSoru = null;
        Image resimTugla = null;

        string blokTag = "G";

        int yatayBlokSayisi = 0;
        int dikeyBlokSayisi = 0;

       
        public FrmLevelEditor()
        {
            InitializeComponent();
     

          
        }

        private void FrmLevelEditor_Load(object sender, EventArgs e)
        {

        


            resimCim = Image.FromFile("grass.png");
            resimCimUyari = Image.FromFile("grassDanger.png");
            resimStart = Image.FromFile("playerStart.png");
            resimFinish = Image.FromFile("playerFinish.png");
            resimSoru = Image.FromFile("question.png");
            resimTugla = Image.FromFile("brick.png");

            panelMap.Size = new Size(1300, 600);

 

         
        }



        private void btnMap_Click(object sender, EventArgs e)
        {
            blokTag = (sender as Button).Tag.ToString();
        }

        void YeniLevelOlustur()
        {

            yatayBlokSayisi = panelMap.Width / blokEbat;
            dikeyBlokSayisi = panelMap.Height / blokEbat;
            panelMap.Controls.Clear();
            int blokSol = 0;
            int blokUst = 0;
            for (int d = 0; d < dikeyBlokSayisi; d++)
            {
                for (int y = 0; y < yatayBlokSayisi; y++)
                {
                    PictureBox p = new PictureBox();
                    p.Tag = "G";
                    p.Image = resimCim;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Size = new Size(blokEbat, blokEbat);
                    p.Location = new Point(blokSol, blokUst);
                    p.BorderStyle = BorderStyle.FixedSingle;
                    panelMap.Controls.Add(p);
                    p.Click += P_Click;
                    blokSol += blokEbat;
                }
                blokUst += blokEbat;
                blokSol = 0;
            }
        }

        

        void ResimDegistir(PictureBox p, string yeniTag)
        {
            if (yeniTag == "G")
            {
                p.Image = resimCim;
            }
            else if (yeniTag == "B")
            {
                p.Image = resimTugla;
            }
            else if (yeniTag == "Q")
            {
                p.Image = resimSoru;
            }
            else if (yeniTag == "D")
            {
                p.Image = resimCimUyari;
            }
            else if (yeniTag == "S")
            {
                if (BuTagVarMi(yeniTag)==true)
                {
                    MessageBox.Show("Başlangıç sadece bir tane olabilir");
                    return;
                }
                p.Image = resimStart;
            }
            else if (yeniTag == "F")
            {
                if (BuTagVarMi(yeniTag))
                {
                    MessageBox.Show("Bitiş sadece bir tane olabilir");
                    return;
                }
                p.Image = resimFinish;
            }
            p.Tag = yeniTag;
        }

        private void P_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            ResimDegistir(p, blokTag);
        }

        bool BuTagVarMi(string tag)
        {

            foreach (var item in panelMap.Controls)
            {
                if (item is PictureBox p)
                {
                    if (p.Tag == tag)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnNewMap_Click(object sender, EventArgs e)
        {
            YeniLevelOlustur();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            string haritaMetin = "";
            int sol = 0;
            int ust = 0;
            for (int d = 0; d < dikeyBlokSayisi; d++)
            {
                for (int y = 0; y < yatayBlokSayisi; y++)
                {
                    var p = KonumaGoreBul(new Point(sol, ust));
                    haritaMetin += p.Tag.ToString();
                    sol += blokEbat;
                }
                haritaMetin += Environment.NewLine;
                sol = 0;
                ust += blokEbat;
            }

            SaveFileDialog sf=new SaveFileDialog();
            sf.DefaultExt = ".map";
            sf.Filter = "Harita Dosyası|*.map";
            if (sf.ShowDialog()== DialogResult.OK)
            {
              File.WriteAllText(sf.FileName, haritaMetin);


                MessageBox.Show("Harita Kaydedildi");
            }

        }
        PictureBox KonumaGoreBul(Point konum)
        {
            foreach (var item in panelMap.Controls)
            {
                if (item is PictureBox p)
                {
                    if (p.Location == konum)
                    {
                        return p;
                    }
                }
            }
            return null;
        }

        private void btnOpenMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog of=new OpenFileDialog();
            of.Filter = "Harita Dosyası|*.map";
            if (of.ShowDialog()== DialogResult.OK)
            {
                var haritaMetinSatirlar = File.ReadAllLines(of.FileName);

               


                panelMap.Controls.Clear();

                int ust = 0;
                int sol = 0;
                foreach (var satir in haritaMetinSatirlar)
                {
                    foreach (var karakter in satir)
                    {
                        PictureBox p = new PictureBox();
                       
                 
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        p.Size = new Size(blokEbat, blokEbat);
                        p.Location = new Point(sol, ust);
                        p.BorderStyle = BorderStyle.FixedSingle;
                        panelMap.Controls.Add(p);
                        p.Click += P_Click;
                        sol += blokEbat;
                        ResimDegistir(p, karakter.ToString());
                    }
                    sol = 0;
                    ust += blokEbat;
                }
               
            }

        }
    }
}
