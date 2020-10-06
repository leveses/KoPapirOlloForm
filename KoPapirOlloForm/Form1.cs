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
        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
