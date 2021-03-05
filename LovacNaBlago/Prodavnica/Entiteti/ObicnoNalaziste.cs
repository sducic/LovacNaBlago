using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blago.Entiteti
{
    public class ObicnoNalaziste : NalazisteZlata
    {
        public virtual string Drzava { get; set; }
        public virtual DateTime DatumOtkrica { get; set; }
        public virtual string Nalazac { get; set; }
        public virtual string NazivReke { get; set; }
    }
    public class ZlatonosnaReka : ObicnoNalaziste
    {
       
    }
    public class ZlatnaZila : ObicnoNalaziste
    {
        
    }

}
