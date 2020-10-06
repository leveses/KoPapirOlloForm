using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoPapirOlloForm
{
    public partial class frm_fo : Form
    {
        public int Jatekos { get; private set; }
        public int Szgep { get; private set; }
        public frm_fo()
        {
            InitializeComponent();
            KezdetiBeallitas();
        }

        private void btn_uj_Click(object sender, EventArgs e)
        {
            KezdetiBeallitas();
        }

        private void KezdetiBeallitas()
        {
            lbl_jatekos.Text = "";
            lbl_gep.Text = "";
            lbl_gyoztes.Text = "";
            Szgep = 0;
            Jatekos = 0;
        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ko_Click(object sender, EventArgs e)
        {
            pb_jatekos.Image = Image.FromFile("ko.jpg");
        }

        private void btn_papir_Click(object sender, EventArgs e)
        {
            pb_jatekos.Image = Image.FromFile("papir.jpg");
        }

        private void btn_ollo_Click(object sender, EventArgs e)
        {
            pb_jatekos.Image = Image.FromFile("ollo.jpg");
        }
        private void Fordulo(int jatekos)
        {
            Random rnd = new Random();
            int gep = rnd.Next(1,4);
            switch (gep)
            {
                case 1:
                    pb_gep.Image = Image.FromFile("ko.jpg");
                    break;
                case 2:
                    pb_gep.Image = Image.FromFile("papir.jpg");
                    break;
                case 3:
                    pb_gep.Image = Image.FromFile("ollo.jpg");
                    break;
            }

            if (gep == Jatekos)
            {
                Jatekos++;
                Szgep++;
                lbl_gyoztes.Text = "Döntetlen";
            }
            else
            {
                //kő 1, papír 2, olló 3
                if ((jatekos == 1 && gep == 3) || (jatekos == 2 && gep == 1) || (jatekos == 3 && gep == 2))
                {
                    Jatekos++;
                    lbl_gyoztes.Text = "Játékos";
                }
                else
                {
                    Szgep++;
                    lbl_gyoztes.Text = "Számítógép";
                }
            }
        }
    }
}
