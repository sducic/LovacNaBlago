using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Blago.Entiteti;

namespace Blago
{
    public partial class prikaziTabele : Form
    {
        public prikaziTabele()
        {
            InitializeComponent();
        }

        private void prikaziTabele_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("IzgubljenoBlago");
            comboBox1.Items.Add("Legenda");
            comboBox1.Items.Add("Lovac");
            comboBox1.Items.Add("Predmet");
            comboBox1.Items.Add("Zastita");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var;
            var = comboBox1.Text;
            if (var == "Lovac")
                this.pozoviLovac();
            else if (var == "IzgubljenoBlago")
                this.pozoviIzgubljenoBlago();
            else if (var == "Legenda")
                this.pozoviLegenda();
            else if (var == "Predmet")
                this.pozoviPredmet();
            else if (var == "Zastita")
                this.pozoviZastita();
            else
                MessageBox.Show("Niste izabrali tabelu","Greska");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void pozoviLovac()
        {
            LovacForm f = new LovacForm();

            f.Show();
        }
        private void pozoviIzgubljenoBlago()
        {
            IzgubljenoBlagoForm f = new IzgubljenoBlagoForm();

            f.Show();
        }
        private void pozoviLegenda()
        {
            LegendaForm f = new LegendaForm();

            f.Show();
        }
        private void pozoviPredmet()
        {
            PredmetForm f = new PredmetForm();

            f.Show();
        }
        private void pozoviZastita()
        {
            ZastitaForm f = new ZastitaForm();

            f.Show();
        }
    }
}
