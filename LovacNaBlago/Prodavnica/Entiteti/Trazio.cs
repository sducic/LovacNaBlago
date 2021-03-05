using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blago.Entiteti
{
    public class Trazio
    {
        public virtual TrazioId Id { get; set; }
        public virtual Lovac TrazioLovac { get; set; }
        public virtual IzgubljenoBlago NekoBlago { get; set; }

        public Trazio()
        {
            Id = new TrazioId();
        }

    }
}