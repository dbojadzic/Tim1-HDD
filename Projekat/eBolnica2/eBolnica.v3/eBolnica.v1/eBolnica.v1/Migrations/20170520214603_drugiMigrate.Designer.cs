using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using eBolnica.v1;

namespace eBolnicav1Migrations
{
    [ContextType(typeof(AdminDB))]
    partial class drugiMigrate
    {
        public override string Id
        {
            get { return "20170520214603_drugiMigrate"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("eBolnica.v1.Pacijent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdresaStanovanja");

                    b.Property<string>("BrojTelefona");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<string>("Prezime");

                    b.Property<bool>("Prioritet");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.Key("id");
                });
        }
    }
}
