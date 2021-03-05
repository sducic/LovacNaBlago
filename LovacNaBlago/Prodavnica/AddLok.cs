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
    public partial class AddLok : Form
    {
        public AddLok()
        {
            InitializeComponent();
        }

        private void AddLok_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dodajLokaciju();
            this.Close();
        }
        private void dodajLokaciju()
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Lokacija l = new Entiteti.Lokacija();
               
                l.Naziv = textBox1.Text;
                l.Drzava = textBox2.Text;
                l.Tip = textBox3.Text;

                s.Save(l);


                //s.SaveOrUpdate(p);

                //   s.Flush();
                s.Close();
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
