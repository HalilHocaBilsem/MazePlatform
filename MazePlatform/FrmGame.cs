using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazePlatform
{
    public partial class FrmGame : Form
    {
        Color seciliRenk = Color.Black;
        bool ciziyorMu = false;
        Point oncekiKonum = Point.Empty;
       
        public FrmGame()
        {
            InitializeComponent();

            pCizimAlani.MouseDown += PCizimAlani_MouseDown;
            pCizimAlani.MouseUp += PCizimAlani_MouseUp;
            pCizimAlani.MouseMove += PCizimAlani_MouseMove;
        }

        private void PCizimAlani_MouseMove(object sender, MouseEventArgs e)
        {
            if (ciziyorMu)
            {
                if (oncekiKonum != Point.Empty)
                {   var penSize = tPen.Value;
                    Pen p = new Pen(seciliRenk, penSize);
                 
                    Graphics gr = pCizimAlani.CreateGraphics();
                    gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    

                    gr.DrawLine(p, oncekiKonum, e.Location);
                    gr.FillEllipse(new SolidBrush(seciliRenk), new Rectangle(e.Location.X - penSize / 2, e.Location.Y - penSize / 2, penSize, penSize));

                    oncekiKonum = e.Location;
                }
            }
        }

        private void PCizimAlani_MouseUp(object sender, MouseEventArgs e)
        {
            ciziyorMu = false;
        }

        private void PCizimAlani_MouseDown(object sender, MouseEventArgs e)
        {
            ciziyorMu = true;
            oncekiKonum = e.Location;

        }

        private void tGreen_ValueChanged(object sender, EventArgs e)
        {
            seciliRenk = Color.FromArgb(tRed.Value, tGreen.Value, tBlue.Value);
            pSeciliRenk.BackColor = seciliRenk;
        }

    }
}
