using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blago.Entiteti
{
   public class Lokacija
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Tip { get; set; }

        public virtual Zastita PripadaLokaciji { get; set; }

        public virtual IzgubljenoBlago IzgubljenoBlago { get; set; }



    }
}