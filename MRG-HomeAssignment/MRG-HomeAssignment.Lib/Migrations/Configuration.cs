namespace MRG_HomeAssignment.Lib.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using MRG_HomeAssignment.Lib.DomainClass;
    using MRG_HomeAssignment.Lib;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserContext context)
        {
            //  This method will be called after migrating to the latest version.

            List<mrgreenCustomer> mrgreenList = new List<mrgreenCustomer>();
            List<redbetCustomer> redbetList = new List<redbetCustomer>();

            mrgreenList.Add(new mrgreenCustomer()
            {
                Id = 1,
                Firstname = "Test",
                Lastname = "Testsson",
                Street = "Exempelvägen 1",
                PostalCode = 11111,
                City = "Stockholm",
                PersonalNumber = 199211302345
            });
            mrgreenList.Add(new mrgreenCustomer()
            {
                Id = 2,
                Firstname = "Testaren",
                Lastname = "Testarsson",
                Street = "Exempelvägen 1",
                PostalCode = 11111,
                City = "Stockholm",
                PersonalNumber = 199211301234
            });
            redbetList.Add(new redbetCustomer()
            {
                Id = 1,
                Firstname = "Test",
                Lastname = "Testsson",
                Street = "Exempelvägen 1",
                PostalCode = 11111,
                City = "Stockholm",
                FavoriteTeam = "Barcelona"
            });
            redbetList.Add(new redbetCustomer()
            {
                Id = 2,
                Firstname = "Testaren",
                Lastname = "Testarsson",
                Street = "Exempelvägen 1",
                PostalCode = 11111,
                City = "Stockholm",
                FavoriteTeam = "Real Madrid"
            });

            foreach (var cust in mrgreenList)
                context.MrgreenCustomers.Add(cust);

            foreach (var cust in redbetList)
                context.RedbetCustomers.Add(cust);
            {

            }
            {

            }
        }
    }
}
