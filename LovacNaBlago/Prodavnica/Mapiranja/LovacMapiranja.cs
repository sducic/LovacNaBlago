using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class LovacMapiranja : ClassMap<Blago.Entiteti.Lovac>
    {
        public LovacMapiranja()
        {


            Table("LOVAC_NA_BLAGO");

            Id(x => x.Id, "IDLOVAC").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");

            HasMany(x => x.Lovci).KeyColumn("IDL").LazyLoad();
            //M:N
            HasManyToMany(x => x.IzgubljenaBlaga)
               .Table("TRAZIO")
               .ParentKeyColumn("IDLOV")
               .ChildKeyColumn("IDBLAGA1");
              

        }


    }
}