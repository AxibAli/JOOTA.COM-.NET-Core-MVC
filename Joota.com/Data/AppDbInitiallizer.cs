using Joota.com.Models;

namespace Joota.com.Data
{
    public class AppDbInitiallizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
            }
            if (!context.Shoes.Any())
            {
                context.Shoes.AddRange(new List<Shoes>()
                {
                    new Shoes()
                    {
                        Name = "",
                        Description = "",
                        Price = ,
                        ImageURL = ,
                        Quantity = ,
                        Size = ,
                        MovieCategory = ,
                    }

                });
                context.SaveChanges();

            }
        }

        
    }
}
