using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Blago.Entiteti
{
    public class Zastita
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Tip { get; set; }

       

        public virtual IList<Lokacija> Lokacije { get; set; }

        public Zastita()
        {
            Lokacije = new List<Lokacija>();
        }
    }
}
