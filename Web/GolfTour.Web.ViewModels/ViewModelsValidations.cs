namespace GolfTour.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ViewModelsValidations
    {
        public const string NameLengthError = "Name must be between {2} and {1} symols";

        public const string EmptyFieldLengthError = "Please enter the field";

        public static class Tour
        {
            public const int NameTourMinLength = 3;
            public const int NameTourMaxLength = 50;
        }

        public static class Course
        {
            public const int NameCourseMinLength = 3;
            public const int NameCourseMaxLength = 20;

            public const int CountryMinLength = 3;
            public const int CountryMaxLength = 15;

            public const int CityMinLength = 3;
            public const int CityMaxLength = 15;

            public const int DesignerMinLength = 3;
            public const int DesignerMaxLength = 15;
        }
    }
}
