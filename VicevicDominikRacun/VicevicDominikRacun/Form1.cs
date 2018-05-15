using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VicevicDominikRacun
{
    public partial class Form1 : Form
    {
        RacunControll kontrola = new RacunControll();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxUnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzr_Click(object sender, EventArgs e)
        {
            double iznos = Convert.ToDouble(txtBoxUnos.Text);
            Racun racun = kontrola.kreirajRacun(iznos);
            kontrola.izracunajPopust(racun);
            kontrola.izracunajUkupanIznos(racun);
            richTxtBoxIspis.Text = kontrola.ispisiPodatke(racun);
            txtBoxUnos.Clear();
            txtBoxUnos.Focus();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            richTxtBoxIspis.Text = kontrola.ispisiSvePodatke();
            txtBoxUnos.Clear();
            txtBoxUnos.Focus();
        }
    }
}
