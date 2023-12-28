using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Point oncekiKonum= Point.Empty;
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
                if (oncekiKonum!= Point.Empty)
                {
                    Pen p = new Pen(seciliRenk, 5);
                    Graphics gr = pCizimAlani.CreateGraphics();
                    gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    gr.DrawLine(p, oncekiKonum, e.Location);
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
            ciziyorMu=true;
            oncekiKonum = e.Location;

            var gr= pCizimAlani.CreateGraphics();
        //    gr.DrawRectangle(Pens.Red, new Rectangle(e.X, e.Y, 10, 10)); ;
        gr.FillRectangle(Brushes.Red,new Rectangle(e.X,e.Y,10,10));
        }

        private void tGreen_ValueChanged(object sender, EventArgs e)
        {
           seciliRenk=Color.FromArgb(tRed.Value,tGreen.Value,tBlue.Value);
           pSeciliRenk.BackColor=seciliRenk;
        }

    }
}
