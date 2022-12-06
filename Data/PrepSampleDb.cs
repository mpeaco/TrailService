namespace TrailService.Data
{
    public static class PrepSampleDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<TrailDbContext>());
            }
        }

        /// <summary>
        /// This will only be used for testing the microservice using InMemory, can be removed when connected to MSSQL 
        /// </summary>
        /// <param name="context"></param>
        private static void SeedData(TrailDbContext context)
        {
            if (!context.TrailViews.Any())
            {
                context.TrailViews.AddRange(
                    new Models.TrailView()
                    {
                        TrailName = "Cadover Bridge to Shaugh Bridge Circular",
                        TrailOwner = "Grace Hopper",

                    },
                    new Models.TrailView()
                    {
                        //TrailId = 2
                        TrailName = "Combe Martin Circular",
                        TrailOwner = "Tim Berners-Lee",

                    },
                    new Models.TrailView()
                    {
                        //TrailId = 3
                        TrailName = "Lyton, Watersmeet and Valley of the Rocks",
                        TrailOwner = "Ada Lovelace",

                    }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Seed data: already have data ");
            }
        }
    }
}