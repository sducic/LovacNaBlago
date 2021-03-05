using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class PredmetMapiranja : ClassMap<Blago.Entiteti.Predmet>
    {
        
             public PredmetMapiranja()
        {
            Table("PREDMET");


            Id(x => x.Id, "IDPR").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Tip, "TIP");
            Map(x => x.Materijal, "MATERIJAL");

            HasMany(x => x.Blaga).KeyColumn("IDPRED").LazyLoad();

        }
    }
}
