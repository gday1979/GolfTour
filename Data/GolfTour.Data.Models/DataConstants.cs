namespace GolfTour.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DataConstants
    {
        public static class Player
        {
            public const int PlayerFirstNameMinLength = 2;
            public const int PlayerFirstNameMaxLength = 12;
            public const int PlayerLastNameMinLength = 2;
            public const int PlayerLastNameMaxLength = 12;

            public const int PlayerCountryMinLength = 3;
            public const int PlayerCountryMaxLength = 15;

            public const int PlayerCityMinLength = 3;
            public const int PlayerCityMaxLength = 15;

            public const int PlayerAgeMinValue = 18;
            public const int PlayerAgeMaxValue = 60;
        }

        public static class Course
        {
            public const int CourseNameMinLength = 3;
            public const int CourseNameMaxLength = 20;

            public const int CourseCountryMinLength = 3;
            public const int CourseCountryMaxLength = 15;

            public const int CourseCityMinLength = 3;
            public const int CourseCityMaxLength = 15;

            public const int CourseHolesMinValue = 9;
            public const int CourseHolesMaxValue = 18;

        }
    }
}