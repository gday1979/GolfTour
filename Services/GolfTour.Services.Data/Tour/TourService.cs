namespace GolfTour.Services.Data.Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TourService : ITourService
    {
        public Task<int> CreateAsync(string name, string country, string city, string image, string designer, int typeOfTour, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, string name, string country, string city, string image, string designer, int typeOfTour, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
