namespace PlatformSerivces.Data
{
    public static  class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder application)
        {
            using (var servicescope = application.ApplicationServices.CreateScope())
            {
                SeedData(servicescope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext dbContext)
        {
            if (!dbContext.Platforms.Any())
            {
                dbContext.Platforms.Add(new Models.Platform()
                {
                    Id = 1,
                    Name = "Test",
                    Publisher = "Microsoft",
                    Cost = "12.69"
                });
                dbContext.Platforms.Add(new Models.Platform()
                {
                    Id = 2,
                    Name = "Test2",
                    Publisher = "Linux",
                    Cost = "22.69"
                });
                dbContext.Platforms.Add(new Models.Platform()
                {
                    Id = 3,
                    Name = "Test3",
                    Publisher = "Red Hat",
                    Cost = "42.69"
                });

                dbContext.SaveChanges();
            } else
            {
                Console.WriteLine("There is already have some data");
            }
        }
    }
}
