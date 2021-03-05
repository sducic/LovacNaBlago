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
    public partial class IzgubljenoBlagoForm : Form
    {
        public IzgubljenoBlagoForm()
        {
            InitializeComponent();
        }

        private void IzgubljenoBlagoForm_Load(object sender, EventArgs e)
        {
            this.prikaziInformacije();
        }
        private void prikaziInformacije()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from IzgubljenoBlago");

                IList<IzgubljenoBlago> list = q.List<IzgubljenoBlago>();

                foreach (IzgubljenoBlago p in list)
                {
                    ListViewItem item = new ListViewItem(p.Id.ToString());
                    item.SubItems.Add(p.Naziv);
                    item.SubItems.Add(p.Poreklo);
                    listView1.Items.Add(item);
                }

                s.Close();


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
