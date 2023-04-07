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
    public partial class GraficaTres : MaterialForm
    {
        public GraficaTres()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green700, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

        }

        private void GraficaTres_Load(object sender, EventArgs e)
        {
            asignar.Visible = false;
            dato_proporcionado.Visible = false;
            IntervaloIz.Text = dato_proporcionado.Text;

            double buscarposicion = double.Parse(asignar.Text);
            double comprobanteizq = double.Parse(dato_proporcionado.Text)*-1;

            if (buscarposicion > comprobanteizq)
            {
                ValorTAceptacionD.Text = asignar.Text;
                Rechazo.Visible = false;
                ValorTRechazo.Visible = false;
                conclusion.Text = "Se acepta la Hipotesis Nula y Se Rechaza la Hipotesis Alternativa";

            }
            else if (buscarposicion <= comprobanteizq) {
                ValorTRechazo.Text = asignar.Text;
                ValorTAceptacionD.Visible = false;
                FlechaAfueraD.Visible = false;
                conclusion.Text = "Se Rechaza la Hipotesis Nula y Se Acepta la Hipotesis Alternativa";
            }

        }

        private void FlechaAfueraD_Click(object sender, EventArgs e)
        {

        }

        private void GraficaTres_FontChanged(object sender, EventArgs e)
        {
           
        }

        private void GraficaTres_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
