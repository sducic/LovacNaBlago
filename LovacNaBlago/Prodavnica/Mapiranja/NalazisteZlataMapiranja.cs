using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class NalazisteZlataMapiranja : ClassMap<Blago.Entiteti.NalazisteZlata>
    {
        public NalazisteZlataMapiranja()
        {
            Table("NALAZISTE_ZLATA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv).Column("NAZIV");

           
        }
    }
}
