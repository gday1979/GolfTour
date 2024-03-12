namespace GolfTour.Services.Data.Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITourService
    {
        Task<int> CreateAsync(string name, string country, string city, string image, string designer, int typeOfTour, DateTime startDate, DateTime endDate);

        IEnumerable<T> GetAll<T>(int? count = null);

        T GetById<T>(int id);

        Task UpdateAsync(int id, string name, string country, string city, string image, string designer, int typeOfTour, DateTime startDate, DateTime endDate);

        Task DeleteAsync(int id);
    }
}
