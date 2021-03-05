using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blago.Entiteti
{
    public class Lovac
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }


        public virtual IList<IzgubljenoBlago> Lovci { get; set; }
        public virtual IList<IzgubljenoBlago> IzgubljenaBlaga { get; set; }

        public Lovac()
        {
            Lovci = new List<IzgubljenoBlago>();
            IzgubljenaBlaga = new List<IzgubljenoBlago>();
        }

    }
}