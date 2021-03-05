using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blago.Entiteti
{
    public abstract class NalazisteZlata
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }

      //  public virtual IList<Legenda> Legende { get; set; }
/*
        public NalazisteZlata()
        {
            Legende = new List<Legenda>();
        }*/
    }
}