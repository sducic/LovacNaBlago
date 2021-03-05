using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class LegendaMapiranja : ClassMap<Blago.Entiteti.Legenda>
    {
        public LegendaMapiranja()
        {
            Table("LEGENDA");

            Id(x => x.Id, "IDLEG").GeneratedBy.TriggerIdentity();

            Map(x => x.Legend).Column("LEGENDA");

           References(x => x.ImaLegendu).Column("IDB").LazyLoad();

        }
    }
}
