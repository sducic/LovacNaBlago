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
    public partial class PredmetForm : Form
    {
        public PredmetForm()
        {
            InitializeComponent();
        }

        private void PredmetForm_Load(object sender, EventArgs e)
        {
            this.prikaziInformacije();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void prikaziInformacije()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Predmet");

                IList<Predmet> list = q.List<Predmet>();

                foreach (Predmet p in list)
                {
                    ListViewItem item = new ListViewItem(p.Id.ToString());
                    item.SubItems.Add(p.Naziv);
                    item.SubItems.Add(p.Tip);
                    item.SubItems.Add(p.Materijal);
                    listView1.Items.Add(item);
                }

                s.Close();


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
