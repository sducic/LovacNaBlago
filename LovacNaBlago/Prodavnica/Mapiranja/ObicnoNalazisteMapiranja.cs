using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class ObicnoNalazisteMapiranja : SubclassMap<ObicnoNalaziste>
    {
        public ObicnoNalazisteMapiranja()
        {
            Table("OBICNO_NALAZISTE");

            KeyColumn("ID1");

            Map(x => x.Drzava).Column("DRZAVA");
            Map(x => x.DatumOtkrica).Column("DATUM_OTKRICA");
            Map(x => x.Nalazac).Column("NALAZAC");
            Map(x => x.NazivReke).Column("NAZIV_REKE");

        }


    }
}
