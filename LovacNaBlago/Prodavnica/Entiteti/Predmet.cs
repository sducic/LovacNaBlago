using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blago.Entiteti
{
    public class Predmet
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Materijal { get; set; }



        public virtual IList<IzgubljenoBlago> Blaga { get; set; }

        public Predmet()
        {
            Blaga = new List<IzgubljenoBlago>();
        }
    }
}
