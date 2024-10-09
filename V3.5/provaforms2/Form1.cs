using System;
using System.Windows.Forms;

namespace provaforms2
{
    public partial class Form1 : Form
    {
        private Lampadina lampadina;

        public Form1()
        {
            InitializeComponent();
            lampadina = new Lampadina();
            lampadina.Posizione = pictureBox1.Top;  // Inizializza la posizione
            lampadina.Accesa = false;  // Inizializza lo stato della lampadina
            AggiornaInterfaccia();
        }

        private void AggiornaInterfaccia()
        {
            if (lampadina.Accesa)
            {
                pictureBox1.Image = Properties.Resources.acceso1;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.spento1;
            }

            pictureBox1.Top = lampadina.Posizione;
        }

        private void buttonAccendi_Click(object sender, EventArgs e)
        {
            lampadina.Accendi();
            AggiornaInterfaccia();
        }

        private void buttonSpegni_Click(object sender, EventArgs e)
        {
            lampadina.Spegni();
            AggiornaInterfaccia();
        }

        private void buttonAlza_Click(object sender, EventArgs e)
        {
            if (lampadina.Posizione > 0)
            {
                lampadina.Alza();
                AggiornaInterfaccia();
            }
        }

        private void buttonAbbassa_Click(object sender, EventArgs e)
        {
            if (lampadina.Posizione < 250)
            {
                lampadina.Abbassa();
                AggiornaInterfaccia();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


    public class Lampadina
    {
        private bool accesa;
        private int posizione;

        public bool Accesa
        {
            get { return accesa; }
            set { accesa = value; }
        }

        public int Posizione
        {
            get { return posizione; }
            set { posizione = value; }
        }

        public void Accendi()
        {
            Accesa = true;
        }

        public void Spegni()
        {
            Accesa = false;
        }

        public void Alza()
        {
            Posizione -= 10; 
        }

        public void Abbassa()
        {
            Posizione += 10; 
        }
    }
}
