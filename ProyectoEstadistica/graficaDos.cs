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
    public partial class GraficaDos : MaterialForm
    {
        public GraficaDos()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green700, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

        }

        private void GraficaDos_Load(object sender, EventArgs e)
        {
            Buscar.Visible = false;
            recibir.Visible = false;

            IntervaloDe.Text = recibir.Text;
            double BuscarPosicion = double.Parse(Buscar.Text);
            double ComprovanteD = double.Parse(IntervaloDe.Text);

            if (BuscarPosicion > ComprovanteD)
            {
                ValorTRechazoD.Text = Buscar.Text;
                ValorTAceptacion.Visible = false;
                Aceptcion.Visible = false;
                conclusion.Text = "Se Rechaza la Hipotesis Nula y Se Acepta la Hipotesis Alternativa";
            }
            else if (BuscarPosicion <= ComprovanteD) {
                ValorTAceptacion.Text = Buscar.Text;
                ValorTRechazoD.Visible = false;
                FlechaAfueraD.Visible = false;
                conclusion.Text = "Se acepta la Hipotesis Nula y Se Rechaza la Hipotesis Alternativa";

            }
        }

        private void GraficaDos_FormClosed(object sender, FormClosedEventArgs e)
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
