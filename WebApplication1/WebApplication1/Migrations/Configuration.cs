namespace WebApplication1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;
    using static System.Data.Entity.Infrastructure.Design.Executor;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Data.WebApplication1Context>
      
    {
        public Configuration()
        {
            
            AutomaticMigrationsEnabled = true;
            ContextKey = "WebApplication1.Data.WebApplication1Context";
        }
        protected override void Seed(WebApplication1.Data.WebApplication1Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var categories = new List<Category> {
            new Category { Name="Lamps"},
            new Category { Name = "Dining Table" },
            new Category { Name = "Decorative picture" },
            new Category { Name = "Sofa" },
            new Category { Name = "Chair" },
            new Category { Name = "Beds" },
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            var products = new List<Product>
            {
                new Product{Name="Table Lamp",Description="Low lights are good for reading before bed",Price=20,CategoryID=categories.Single(c=>c.Name=="Lamps").ID},
                new Product{Name="Ceiling Lamp",Description="The decoration style is more brilliant",Price=80,CategoryID=categories.Single(c=>c.Name=="Lamps").ID},
                new Product{Name="Floor Lamp",Description="Placed in the living room",Price=40,CategoryID=categories.Single(c=>c.Name=="Lamps").ID},
                new Product{Name="Round Dining Table",Description="Suitable for families of 5-6 people",Price=50,CategoryID=categories.Single(c=>c.Name=="Dining Table").ID},
                new Product{Name="Rectangular Dining Table",Description="Suitable for families of 3-4 people",Price=40,CategoryID=categories.Single(c=>c.Name=="Dining Table").ID},
                new Product{Name="Landscape Decorative Painting",Description="The main body of the picture is the landscape",Price=40,CategoryID=categories.Single(c=>c.Name=="Decorative picture").ID},
                new Product{Name="Figure Decorative Painting",Description="The main body of the picture is the human",Price=40,CategoryID=categories.Single(c=>c.Name=="Decorative picture").ID},
                new Product{Name="Tall Stool",Description="It's more convenient next to the bar",Price=35,CategoryID=categories.Single(c=>c.Name=="Chair").ID},
                new Product{Name="Deck Chair",Description="Enjoy your sunbathing",Price=50,CategoryID=categories.Single(c=>c.Name=="Chair").ID},
                new Product{Name="Fabric Sofa",Description="The fabric is soft and skin-friendly",Price=90,CategoryID=categories.Single(c=>c.Name=="Sofa").ID},
                new Product{Name="Wooden Sofa",Description="marvelous,gorgeous,splendid and posh",Price=90,CategoryID=categories.Single(c=>c.Name=="Sofa").ID},
                new Product{Name="Child's Cot",Description="For infants up to 5 years old",Price=60,CategoryID=categories.Single(c=>c.Name=="Beds").ID},
                new Product{Name="Single Bed",Description="Length 2.5m, width 1.8m",Price=90,CategoryID=categories.Single(c=>c.Name=="Beds").ID},
                new Product{Name="Double Bed",Description="Length 2.5m, width 2.5m",Price=100,CategoryID=categories.Single(c=>c.Name=="Beds").ID},
                new Product{Name="Bunk Bed",Description="Children close in age can share the bed, saving bedroom space",Price=100,CategoryID=categories.Single(c=>c.Name=="Beds").ID},
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
        
    }
    
}
