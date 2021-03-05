using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blago.Entiteti
{
    public class TrazioId
    {
        public virtual Lovac TrazioLovac { get; set; }
        public virtual IzgubljenoBlago NekoBlago { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(Trazio))
                return false;

            Trazio recievedObject = (Trazio)obj;

            if ((TrazioLovac.Id == recievedObject.TrazioLovac.Id) &&
                (NekoBlago.Id == recievedObject.NekoBlago.Id))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}