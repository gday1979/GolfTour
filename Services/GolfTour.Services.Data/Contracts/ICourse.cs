namespace GolfTour.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using GolfTour.Data.Models;

    public interface ICourse
    {
        Task<IEnumerable<Course>> GetAllCourses<T>();

        Task<T> GetCourseById<T>(int id);
    }
}
