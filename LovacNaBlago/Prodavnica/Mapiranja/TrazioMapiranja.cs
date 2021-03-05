using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class TrazioMapiranja : ClassMap<Blago.Entiteti.Trazio>
    {
        public TrazioMapiranja()
        {

            Table("TRAZIO");

            CompositeId(x => x.Id)
                .KeyReference(x => x.TrazioLovac, "IDLOV")
                .KeyReference(x => x.NekoBlago, "IDBLAGA1");
        }


    }
}