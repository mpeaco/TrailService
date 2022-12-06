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
                        //TrailId = 0,
                        TrailName = "Seeded trail1",
                        TrailOwner = "Mack",

                    },
                    new Models.TrailView()
                    {
                        //TrailId = 0,
                        TrailName = "Seeded trail2",
                        TrailOwner = "Marco",

                    },
                    new Models.TrailView()
                    {
                        //TrailId = 0,
                        TrailName = "Seeded trail3",
                        TrailOwner = "Maaock",

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