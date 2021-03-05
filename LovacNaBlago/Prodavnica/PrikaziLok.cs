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
    public partial class PrikaziLok : Form
    {
        public PrikaziLok()
        {
            InitializeComponent();
        }

        private void prikaziInformacije()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Lokacija");

                IList<Lokacija> list = q.List<Lokacija>();

                foreach (Lokacija p in list)
                {
                    ListViewItem item =new ListViewItem(p.Id.ToString());
                    item.SubItems.Add(p.Naziv);
                    item.SubItems.Add(p.Drzava);
                    item.SubItems.Add(p.Tip);
                    listView1.Items.Add(item);
                }
               
                s.Close();


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PrikaziLok_Load(object sender, EventArgs e)
        {
            this.prikaziInformacije();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddLok f = new AddLok();

            f.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.prikaziInformacije();
        }

        private void button3_Click(object sender, EventArgs e)          //ne brise lokacije id 1-5 zbog kljuca
        {

            string pom = listView1.SelectedItems[0].Text;
            int x = Int32.Parse(pom);
            this.obrisi(x);
        }

        private void obrisi(int pom)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija o = s.Load<Lokacija>(pom);

               
                s.Delete(o);


                s.Flush();
                s.Close();
                this.refresuj();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void refresuj()
        {
            listView1.Items.Clear();
            this.prikaziInformacije();
        }
    }
}
