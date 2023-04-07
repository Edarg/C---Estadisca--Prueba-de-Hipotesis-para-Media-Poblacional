using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProyectoEstadistica
{
    public partial class graficaUno : MaterialForm
    {
        public graficaUno()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green700, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

        }

        private void graficaUno_Load(object sender, EventArgs e)
        {
            RechazoIz.Text = R.Text;
            RechazoDe.Text = R.Text;
            R.Visible = false;
            Establecer.Visible = false;


            double BuscarPosición = double.Parse(Establecer.Text);


            double ComprovatedePosicionD = double.Parse(IntervaloDe.Text);
            double ComprovatedePosicionI = double.Parse(IntervaloIz.Text)*-1;

            if (BuscarPosición < ComprovatedePosicionI)
            {
                ValorTRechazoI.Text = Establecer.Text;

                ValorTAceptacion.Visible = false;
                FlechaDentro.Visible = false;
                ValorTRechazoD.Visible = false;
                FlechaAfueraD.Visible = false;
                conclusion.Text = "Se Rechaza la Hipotesis Nula y Se Acepta la Hipotesis Alternativa";
            }
            else if (BuscarPosición > ComprovatedePosicionD)
            {
                ValorTRechazoD.Text = Establecer.Text;

                ValorTRechazoI.Visible = false;
                FlechaAfueraI.Visible = false;
                ValorTAceptacion.Visible = false;
                FlechaDentro.Visible = false;
                conclusion.Text = "Se Rechaza la Hipotesis Nula y Se Acepta la Hipotesis Alternativa";


            }
            else{
                ValorTAceptacion.Text = Establecer.Text;
                ValorTRechazoI.Visible = false;
                ValorTRechazoD.Visible = false;
                FlechaAfueraD.Visible = false;
                FlechaAfueraI.Visible = false;
                conclusion.Text = "Se acepta la Hipotesis Nula y Se Rechaza la Hipotesis Alternativa";
            }
            
            


        }

        private void graficaUno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ValorTRechazo_Click(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void conclusion_Click(object sender, EventArgs e)
        {

        }
    }
}
