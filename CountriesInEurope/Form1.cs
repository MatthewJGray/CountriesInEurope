using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesInEurope
{
    public partial class frmEuropeanCountries : Form
    {
        public frmEuropeanCountries()
        {
            InitializeComponent();
        }

        private void lblPopulation_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblLanguage_Click(object sender, EventArgs e)
        {

        }

        private void ptbGermany_MouseEnter(object sender, EventArgs e)
        {
            lblName.Text = "Germany";
            txtCapital.Text = "Berlin";
            txtLanguage.Text = "German";
            txtCurrency.Text = "Euro";
            txtPopulation.Text = "83.24 million as of 2020";
            txtGeneral.Text = "Test";
            ptbFlag.Image = imageList1.Images[0];
        }

        private void ptbFrance_MouseEnter(object sender, EventArgs e)
        {
            lblName.Text = "France";
            txtCapital.Text = "Paris";
            txtLanguage.Text = "French";
            txtCurrency.Text = "Euro";
            txtPopulation.Text = "65.42 million as of 2021";
            txtGeneral.Text = "Test";
            ptbFlag.Image = imageList1.Images[1];
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            lblName.Text = "Spain";
            txtCapital.Text = "Madrid";
            txtLanguage.Text = "Spanish";
            txtCurrency.Text = "Euro";
            txtPopulation.Text = "46.78 million as of 2021";
            txtGeneral.Text = "Test";

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            lblName.Text = "Italy";
            txtCapital.Text = "Rome";
            txtLanguage.Text = "Italian";
            txtCurrency.Text = "Euro";
            txtPopulation.Text = "60.34 million as of 2021";
            txtGeneral.Text = "Test";
        }


    }
}
