using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blago.Entiteti
{
    public class Legenda 
    {
        public virtual int Id { get; set; }
        public virtual string Legend { get; set; }

        public virtual IzgubljenoBlago ImaLegendu { get; set; }

    }
}