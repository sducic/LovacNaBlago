using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blago.Entiteti;
using FluentNHibernate.Mapping;

namespace Blago.Mapiranja
{
    class IzgubljenoBlagoMapiranja : SubclassMap<IzgubljenoBlago>
    {
        public IzgubljenoBlagoMapiranja()
        {
            Table("IZGUBLJENO_BLAGO");

            KeyColumn("ID2");

            Map(x => x.Poreklo).Column("POREKLO");
            Map(x => x.Mapa).Column("MAPA");


            References(x => x.PripadaPredmetu).Column("IDPRED").LazyLoad();
            References(x => x.PripadaLovcu).Column("IDL").LazyLoad();



            //1:1
            References(x => x.Lokacija, "IDLOKACIJE").Unique();

            HasMany(x => x.Legende).KeyColumn("IDB").LazyLoad();
            //M:N
            HasManyToMany(x => x.LovciTrazili)
               .Table("TRAZIO")
               .ParentKeyColumn("IDBLAGA1")
               .ChildKeyColumn("IDLOV");
             



        }


    }
}