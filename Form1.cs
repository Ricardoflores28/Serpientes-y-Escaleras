using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serpintes_y_escaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = "";

            dado b = new dado();
            jugador a = new jugador(1);
            jugador c = new jugador(2);

            int x, y;

            do
            {
                x = a.adelante(b.num_random());
                y = c.adelante(b.num_random());

                txt1.Text =txt1.Text + "Jugador #1: " + x.ToString() + "  <---->  Jugador #2: " + y.ToString()+ "\r\n";
            } while (x <= 100 && y <= 100);

            if (x >= 100)
                marcador.Text = "Win Jugador 1";
            else
                marcador.Text = "Win Jugador 2";

        }
    }
}
