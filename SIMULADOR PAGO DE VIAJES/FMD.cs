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
    public partial class FMD : Form
    {
        public FMD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totaldescuento = 0;
            int pagar = 0;
            double des1 = 0;
            double des2 = 0;
            double TOTALPAGAR = 0;

            if (radioButtonhombre.Checked == true)
            {
                gn.Text = radioButtonhombre.Text;

            }
            else

                if (radioButtonmujer.Checked == true)
            {
                gn.Text = radioButtonmujer.Text;
            }

            if (BoxClassA.Checked == true)
                pagar += pagar + 420000;
            V.Text = pagar.ToString();


            if (BoxClassB.Checked == true)
                pagar += pagar + 315000;
            V.Text = pagar.ToString();


            if (BoxClassC.Checked == true)
                pagar += pagar + 210000;
            V.Text = pagar.ToString();


            //////////////////////////EStrato Descuento////////////////////////////////////////




            if (BoxEst2.Checked == true || BoxEst1.Checked == true)
                des1 = Math.Round(pagar * 0.1);


            if (BoxEst3.Checked == true || BoxEst4.Checked == true)
                des1 = Math.Round(pagar * 0.07);

            if (BoxEst5.Checked == true || BoxEst6.Checked == true)
                des1 = Math.Round(pagar * 0.05);


            desc1.Text = des1.ToString();
            totaldescuento = pagar - des1;

            // Dias descuento


            if (BoxDia1.Checked == true || BoxDia2.Checked == true || BoxDia3.Checked == true)
                des2 = Math.Round(totaldescuento * 0.10);

            if (BoxDia4.Checked == true || BoxDia5.Checked == true)
                des2 = Math.Round(totaldescuento * 0.05);

            if (BoxDia6.Checked == true || BoxDia7.Checked == true)
                des2 = Math.Round(totaldescuento * 0);




            TOTALPAGAR = totaldescuento - des2;
            desc2.Text = des2.ToString();
            TAP.Text = TOTALPAGAR.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FACTURAMEDELLIN form = new FACTURAMEDELLIN();

            form.labelN.Text = this.textBox1.Text;
            form.labelI.Text = this.textBox2.Text;
            form.label8.Text = this.gn.Text;
            form.label9.Text = this.V.Text;
            form.label10.Text = this.desc1.Text;
            form.label11.Text = this.desc2.Text;
            form.label12.Text = this.TAP.Text;

            form.Show();
        }
    }
}
