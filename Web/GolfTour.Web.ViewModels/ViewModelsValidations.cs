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
    }
}
