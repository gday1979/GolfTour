namespace GolfTour.Services.Data.Course
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using GolfTour.Data.Common.Repositories;
    using GolfTour.Data.Models;
    using GolfTour.Services.Mapping;
    using GolfTour.Web.ViewModels.Course;
    using Microsoft.EntityFrameworkCore;

    public class CourseService : ICourseService
    {
        private readonly IDeletableEntityRepository<Course> courseRepository;

        public CourseService(IDeletableEntityRepository<Course> courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public async Task<CourseEditViewModel> CreateAsync(CourseViewModel courseViewModel)
        {
           var course = new Course
           {
                Name = courseViewModel.Name,
                Country = courseViewModel.Country,
                City = courseViewModel.City,
                Designer = courseViewModel.Designer,
                ImageCourse = courseViewModel.ImageUrl,
           };
           await this.courseRepository.AddAsync(course);
           await this.courseRepository.SaveChangesAsync();

           var viewModel=await this.courseRepository.All().To<CourseEditViewModel>().FirstOrDefaultAsync(x => x.Id == course.Id);

           return viewModel;
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetAllCoursesAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetViewModelByIdAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, CourseViewModel courseViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
