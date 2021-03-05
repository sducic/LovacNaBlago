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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Blago.Entiteti.Lokacija p = s.Load<Blago.Entiteti.Lokacija>(3);

                MessageBox.Show(p.Naziv, "Lokacija");




                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)                //dodavanje nove lokacije i zastite!
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Lokacija l = new Entiteti.Lokacija();



                l.Naziv = "Atina";
                l.Drzava = "Grcka";
                l.Tip = "Ostrvo";



                Entiteti.Zastita z = new Entiteti.Zastita();

                z.Naziv = "Ukleti Holandjanin";
                z.Tip = "Duh";

                s.Save(z);

                l.PripadaLokaciji = z;
                s.Save(l);

                z.Lokacije.Add(l);

                s.Save(z);

                //s.SaveOrUpdate(p);

                //   s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManytoOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Lokacija o = s.Load<Lokacija>(5);

                MessageBox.Show(o.Tip);
                MessageBox.Show(o.PripadaLokaciji.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void cmdOneToMany_Click(object sender, EventArgs e)             //za datu zastitu prikazuje naziv i tip lokacije
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Blago.Entiteti.Zastita p = s.Load<Blago.Entiteti.Zastita>(1);

                foreach (Lokacija o in p.Lokacije)
                {
                    MessageBox.Show("naziv lokacije: " + o.Naziv + "     tip lokacije: " + o.Tip);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();


                Blago.Entiteti.IzgubljenoBlago p = s.Load<Blago.Entiteti.IzgubljenoBlago>(3);

                MessageBox.Show("naziv: " + p.Naziv + Environment.NewLine + "poreklo: " + p.Poreklo, "Izgubljeno Blago");




                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)   //na osnovu  zadatog predmeta prikazuje informacije o izgubljenom blagu i naziv lokacije na kome se blago nalazi
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Blago.Entiteti.Predmet p = s.Load<Blago.Entiteti.Predmet>(3);

                foreach (IzgubljenoBlago o in p.Blaga)
                {
                    MessageBox.Show("blago: " + o.Naziv + " " + Environment.NewLine + "predmet: " + o.Lokacija.Naziv);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)          //obicno nalaziste zlata i njegov pronallazac
        {

            try
            {
                ISession s = DataLayer.GetSession();


                Blago.Entiteti.ObicnoNalaziste p = s.Load<Blago.Entiteti.ObicnoNalaziste>(2);

                MessageBox.Show("naziv: " + p.Naziv + Environment.NewLine + "pronalazac: " + p.Nalazac);




                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Blago.Entiteti.Legenda p = s.Load<Blago.Entiteti.Legenda>(1);

                MessageBox.Show(p.Legend, "Legenda");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Blago.Entiteti.Lovac p = s.Load<Blago.Entiteti.Lovac>(1);

                MessageBox.Show(p.Ime + " " + p.Prezime, "Lovac");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IzgubljenoBlago r1 = s.Load<IzgubljenoBlago>(3);

                foreach (Entiteti.Lovac p1 in r1.LovciTrazili)
                {
                    MessageBox.Show(r1.Naziv);
                }


                Entiteti.Lovac r2 = s.Load<Entiteti.Lovac>(3);

                foreach (Entiteti.IzgubljenoBlago p2 in r2.IzgubljenaBlaga)
                {
                    MessageBox.Show(r2.Ime + " " + r2.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija o = s.Get<Lokacija>(200);

                if (o != null)
                {
                    MessageBox.Show(o.PripadaLokaciji.Naziv);
                }
                else
                {
                    MessageBox.Show("Ne postoji lokacija sa zadatim identifikatorom");
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Lokacija");

                IList<Lokacija> lok = q.List<Lokacija>();

                foreach (Lokacija o in lok)
                {
                    MessageBox.Show(o.Naziv);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from IzgubljenoBlago");

                IList<IzgubljenoBlago> bl = q.List<IzgubljenoBlago>();

                foreach (IzgubljenoBlago o in bl)
                {
                    MessageBox.Show(o.Naziv);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               
                IQuery q = s.CreateQuery("from Lokacija as o where o.PripadaLokaciji = '3'");

                IList<Lokacija> lok = q.List<Lokacija>();

                foreach (Lokacija o in lok)
                {
                    MessageBox.Show(o.Id + " " + o.Naziv);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit
                IQuery q = s.CreateQuery("from Predmet as o where o.Materijal = :tip ");
                q.SetParameter("tip", "Zlato");
                

                IList<Predmet> pred = q.List<Predmet>();

                foreach (Predmet o in pred)
                {
                    MessageBox.Show(o.Id + " " + o.Naziv+ Environment.NewLine+ "tip: "+o.Tip);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zastita o = s.Load<Zastita>(4);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(o);


                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet o = s.Load<Predmet>(5);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(o);
               

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            PrikaziLok forma = new PrikaziLok();

            forma.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            prikaziTabele f = new prikaziTabele();

            f.Show();
        }

        
    }
 }


