namespace GolfTour.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(GolfTourDbContext dbContext, IServiceProvider serviceProvider);
    }
}
