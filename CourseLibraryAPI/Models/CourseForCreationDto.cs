using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CourseLibraryAPI.ValidationAttributes;

namespace CourseLibraryAPI.Models
{
    [CourseTitleMustBeDifferentFromDescription(
        ErrorMessage = "Title must be different from description.")]
    public class CourseForCreationDto : CourseForManipulationDto //: IValidatableObject
    {

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Title == Description)
        //    {
        //        yield return new ValidationResult(
        //            "The provided description should be different from the title.",
        //            new [] { "CourseForCreationDto" });
        //    }
        //}
    }
}