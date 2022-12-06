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
            if (!context.TrailPoints.Any())
            {
                context.TrailPoints.AddRange(
                    new Models.TrailPoint()
                    {
                        TrailId = 0,
                        TrailName = "Seeded trail",
                        TrailOwner = "Mark Peacock",
                        CommentId = "cm_0",
                        PointId = 1,
                        Longitude = (decimal)-4.04030000,
                        Latitude = (decimal)50.46449000,
                        Elevation = (decimal)232.0
                    },
                    new Models.TrailPoint()
                    {
                        TrailId = 0,
                        TrailName = "Seeded trail",
                        TrailOwner = "Mark Peacock",
                        CommentId = "No comment",
                        PointId = 2,
                        Longitude = (decimal)-4.24030000,
                        Latitude = (decimal)50.46449000,
                        Elevation = (decimal)234.0
                    },
                    new Models.TrailPoint()
                    {
                        TrailId = 0,
                        TrailName = "Seeded trail",
                        TrailOwner = "Mark Peacock",
                        CommentId = "No comment",
                        PointId = 3,
                        Longitude = (decimal)-4.25030000,
                        Latitude = (decimal)51.13309000,
                        Elevation = (decimal)232.0
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