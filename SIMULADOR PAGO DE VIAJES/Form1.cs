namespace SIMULADOR_PAGO_DE_VIAJES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bing_Click(object sender, EventArgs e)
        {
           
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (pass.Text == "123")
            {
                
                INICIO form = new INICIO();
                pass.Text = "";
                form.Show();
            }

            else
            {
                MessageBox.Show("Contraseña incorrecta");
                pass.Text = "";
                pass.Focus();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}