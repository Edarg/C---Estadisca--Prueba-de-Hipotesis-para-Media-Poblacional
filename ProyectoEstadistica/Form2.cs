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
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green700, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Error.Text = "";
            Central.Text = "";
            calculo.Text = "";

            receptor.Visible = false;
            Error.Visible = false;
            Central.Visible = false;
            calculo.Visible = false;


        }

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

            //este metodo me sirve apra ocultar o mostrar el espacio para insertar
            // el intervalo de t
            double Tamanio_M;
            Tamanio_M = double.Parse(materialSingleLineTextField2.Text);
            if (Tamanio_M <= 30)
            {
                Imagen_T.Visible = true;
                Valor_T.Visible = true;
                titulo_T.Visible = true;
            }
            else if (Tamanio_M > 30)
            {
                Imagen_T.Visible = false;
                Valor_T.Visible = false;
                Valor_T.Text = "0";
                titulo_T.Visible = false;
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
            //declaramos varaibles para realizar las operaciones
            double muh, tamanioMuestra, Media, desviacionEstandar, Respuesta, ValorT;
            muh = double.Parse(materialSingleLineTextField1.Text);
            tamanioMuestra = double.Parse(materialSingleLineTextField2.Text);
            Media = double.Parse(materialSingleLineTextField3.Text);
            desviacionEstandar = double.Parse(materialSingleLineTextField4.Text);
            ValorT = double.Parse(Valor_T.Text);


            //pido el tamaño de la muestra para ver que formula se usa
            double espacio = int.Parse(materialSingleLineTextField2.Text);
            if (espacio <= 30)
            {
                Respuesta = (Media - muh) / (desviacionEstandar/(Math.Sqrt(tamanioMuestra)) );
                //imprimo el resultado en un label para mandar el resultado a otro form
                calculo.Text = Respuesta.ToString();

                
            }
            else if (espacio > 30)
            {
                Respuesta = (Media - muh) / (desviacionEstandar / (Math.Sqrt(tamanioMuestra)));
                calculo.Text = Respuesta.ToString();


            }



            //si el formulario tiene impreso el primero abrimos el form GraficaUno
            if (receptor.Text=="Primero") {

                double Tamanio_M;
                Tamanio_M = double.Parse(materialSingleLineTextField2.Text);
                if (Tamanio_M > 30) {
                    ValorT = 1.96;
                }
                    
                graficaUno Gu = new graficaUno();
                //mando el valor del erro a la grafica del from GraficaUno
                Gu.R.Text = Error.Text;
                Gu.ZonaAceptada.Text = Central.Text;
                //transformo el int de nuevo a cadena de texto
                String val = ValorT.ToString();
                Gu.IntervaloIz.Text = val;
                Gu.IntervaloDe.Text = val;
                //el resultado de la formula la mando al form graficaUno
                Gu.Establecer.Text = calculo.Text;
                Gu.Show();
                this.Hide();
                
            }

            if (receptor.Text == "Segundo") {

                double Tamanio_M;
                Tamanio_M = double.Parse(materialSingleLineTextField2.Text);
                if (Tamanio_M > 30)
                {
                    ValorT = 1.64;
                }
                
                GraficaDos g2 = new GraficaDos();
                g2.ZonaAceptada.Text = Central.Text;
                g2.RechazoDe.Text = Error.Text;
                String val = ValorT.ToString();
                g2.recibir.Text = val;
                g2.Buscar.Text = calculo.Text;

                g2.Show();
                this.Hide();

            }

            if (receptor.Text == "Tercero") {

                double Tamanio_M;
                Tamanio_M = double.Parse(materialSingleLineTextField2.Text);
                if (Tamanio_M > 30)
                {
                    ValorT = 1.64;
                }

                GraficaTres g3 = new GraficaTres();
                g3.ZonaAceptada.Text = Central.Text;
                g3.RechazoIz.Text = Error.Text;
                String val = ValorT.ToString();
                g3.dato_proporcionado.Text = val;
                g3.asignar.Text = calculo.Text;

                g3.Show();
                this.Hide();

            }
            


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //metodo para cuando le de a la X Cierre el programa
            Application.Exit();
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //si presionamos el boton de 0.01 asignamos estos valoras para insertarlos
            //en la grafica
            if (receptor.Text == "Primero") {
                Error.Text = "0.025";
                Central.Text = "0.95";
            }

            if (receptor.Text == "Segundo")
            {
                Error.Text = "0.05";
                Central.Text = "0.95";
            }

            if (receptor.Text == "Tercero") {
                Error.Text = "0.05";
                Central.Text = "0.95";
            }





        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //si presionamos el boton de 0.01 asignamos estos valoras para insertarlos
            //en la grafica
            

            if (receptor.Text == "Primero") {
                Error.Text = "0.005";
                Central.Text = "0.99";
            }

            if (receptor.Text == "Segundo") {
                Error.Text = "0.01";
                Central.Text = "0.99";
            }

            if (receptor.Text == "Tercero")
            {
                Error.Text = "0.01";
                Central.Text = "0.99";
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void calculo_Click(object sender, EventArgs e)
        {

        }

        private void Central_Click(object sender, EventArgs e)
        {

        }

        private void Error_Click(object sender, EventArgs e)
        {

        }

        private void receptor_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void Valor_T_Click(object sender, EventArgs e)
        {

        }

        private void titulo_T_Click(object sender, EventArgs e)
        {

        }

        private void Imagen_T_Click(object sender, EventArgs e)
        {

        }
    }
}
