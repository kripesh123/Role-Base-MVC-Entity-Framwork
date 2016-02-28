namespace Security.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Security.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Security.Models.ApplicationDbContext";
        }

        protected override void Seed(Security.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Product> pList = new List<Product>()
            {
                new Product()
                {
                    Name="Banana",Picture="Banana"
                },
                new Product()
                {
                    Name="Apple",Picture="Apple"
                },
                new Product()
                {
                    Name="Orange",Picture="Orange"
                },
                new Product()
                {
                    Name="Picture",Picture="Picture"
                }

            };
            pList.ForEach(p =>
            {
                context.Products.Add(p);
                context.SaveChanges();
            });
        }
    }
}
