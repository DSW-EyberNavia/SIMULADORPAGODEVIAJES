using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMULADOR_PAGO_DE_VIAJES
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void b_Click(object sender, EventArgs e)
        {
            FBG form = new FBG();
            form.Show();
        }

        private void m_Click(object sender, EventArgs e)
        {
            FMD form = new FMD();
            form.Show();
        }

        private void p_Click(object sender, EventArgs e)
        {
            FPT form = new FPT();
            form.Show();
        }

        private void f_Click(object sender, EventArgs e)
        {
            FFA form = new FFA();
            form.Show();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }
    }
}
