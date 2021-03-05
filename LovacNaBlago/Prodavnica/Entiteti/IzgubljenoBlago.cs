using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blago.Entiteti
{
    public class IzgubljenoBlago : NalazisteZlata
    {
        public virtual string Poreklo { get; set; }
        public virtual bool Mapa { get; set; }
        public virtual Lokacija Lokacija { get; set; }

        public virtual Zastita PripadaPredmetu { get; set; }
        public virtual Lovac PripadaLovcu { get; set; }

        public virtual IList<Legenda> Legende { get; set; }

        public virtual IList<Lovac> LovciTrazili { get; set; }

        public IzgubljenoBlago()
        {
            Legende = new List<Legenda>();
            LovciTrazili = new List<Lovac>();
        }

    }
}