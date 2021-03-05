using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class LokacijaMapiranja : ClassMap<Blago.Entiteti.Lokacija>
    {
        public LokacijaMapiranja()
        {
            Table("LOKACIJA");

            Id(x => x.Id, "IDLOK").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Drzava, "DRZAVA");
            Map(x => x.Tip, "TIP");

            //1:N
            References(x => x.PripadaLokaciji).Column("ID_ZASTITA").LazyLoad();
            //1:1
            HasOne(x => x.IzgubljenoBlago).PropertyRef(x => x.Lokacija);
           
        }
    }
}
