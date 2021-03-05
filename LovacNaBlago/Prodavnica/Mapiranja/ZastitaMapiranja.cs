using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class ZastitaMapiranja : ClassMap<Blago.Entiteti.Zastita>
    {
       
          public ZastitaMapiranja()
        {
            Table("ZASTITA");

            Id(x => x.Id, "IDZ").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Tip, "TIP");

            HasMany(x => x.Lokacije).KeyColumn("ID_ZASTITA").LazyLoad();
        }
    
    }
}