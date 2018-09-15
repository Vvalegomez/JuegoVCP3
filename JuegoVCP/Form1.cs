using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoVCP
{
    public partial class Form1 : Form
    {
        List<PictureBox> ListaObstaculos = new List<PictureBox>();
        Random RnTipoObstaculo = new Random();
        int Velocidad = 3;
        int MovimientoAuto1 = 0;

        public Form1()
        {
            InitializeComponent();
            NuevoObstaculo(ListaObstaculos, this, 10, 80);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            auto1.Image = (MovimientoAuto1 == 0) ? Properties.Resources.autito1 : Properties.Resources.autito1_;
            MovimientoAuto1 = (MovimientoAuto1 == 0) ? 1 : 0;

        }

        public void NuevoObstaculo(List<PictureBox> ListaElementos, Form panelJuego, int DistanciaUno, int DistanciaDos)
        {
            int NumeroCarro = 1;
            int TipoObstaculo = RnTipoObstaculo.Next(1, 3);
            int UbicacionObstaculo = RnTipoObstaculo.Next(1, 3);

            int DistanciaObstaculo = (UbicacionObstaculo == 1) ? DistanciaUno : DistanciaDos;

            PictureBox pb = new PictureBox
            {
                Location = new Point(DistanciaObstaculo, 0),
                Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("punto" + NumeroCarro + TipoObstaculo),
                BackColor = Color.Transparent,
                Tag = NumeroCarro + "_" + TipoObstaculo,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            ListaElementos.Add(pb);
            panelJuego.Controls.Add(pb);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int CambioCoche = (auto1.Location.X == 80) ? 10 : 80;
            auto1.Location = new Point(CambioCoche, auto1.Location.Y);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pbox1 in ListaObstaculos);
            {
                int MovimientoY;
                MovimientoY = pBox1.Location.Y;
                MovimientoY = MovimientoY + Velocidad;
                pBox1.Location = new Point(pBox1.Location.X, MovimientoY);

                int MovimientoX;
                MovimientoX = pBox2.Location.X;
                MovimientoX = MovimientoX + Velocidad;
                pBox2.Location = new Point(pBox2.Location.X, MovimientoY);



            }

            if (ListaObstaculos.Count > 0);
            {
                if (ListaObstaculos[(ListaObstaculos.Count) - 1].Location.Y > 250)
                {
                    NuevoObstaculo(ListaObstaculos, this, 10, 80);
                }
            }

            if (ListaObstaculos.Count > 0)
            {

                for (int i = 0; i < ListaObstaculos.Count; i++)

                {
                    if (ListaObstaculos[i].Location.Y > 400)
                    {

                        if (ListaObstaculos[i].Tag.ToString() == "1_1")
                        {
                            Reiniciar();
                        }
                        this.Controls.Remove(ListaObstaculos[i]);
                        ListaObstaculos.Remove(ListaObstaculos[i]);

                    }

                    if (ListaObstaculos[i].Bounds.IntersectsWith(auto1.Bounds))
                    {
                        if (ListaObstaculos[i].Tag.ToString() == "1_1")

                        {
                            this.Controls.Remove(ListaObstaculos[i]);
                            int TotalPuntos = Convert.ToInt32(lblPuntos.Text) + 1;
                            if (TotalPuntos % 2 == 0)
                            {
                                Velocidad++;
                            }
                            lblPuntos.Text = TotalPuntos.ToString();
                            ListaObstaculos.Remove(ListaObstaculos[i]);


                        }

                        else
                        {
                            this.Controls.Remove(ListaObstaculos[i]);
                            ListaObstaculos.Remove(ListaObstaculos[i]);
                            Reiniciar();
                        }

                    }


                }

            }

        }
        public void Reiniciar()
        {
            pBox1.Text = "0";
            Velocidad = 3;
        }
    }
   
}

         
            




