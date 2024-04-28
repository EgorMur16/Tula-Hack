using System.ComponentModel.DataAnnotations;
using WebAppAutorization.Data;

namespace WebAppAutorization.Models.Validators
{
    public class NameAxistAttribut : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || validationContext == null) return null;
            if(validationContext.ObjectInstance == null 
                ||
                !(validationContext.ObjectInstance is  StudentModel))
            {
                throw new ArgumentException("NameAxistAttribut contains wrong object");
            }
            var student = validationContext.ObjectInstance as StudentModel;
            var ctx = validationContext.GetService<ApplicationDbContext>();
            if(ctx.Students.Any(s => s.Id != student.Id &&  s.Name == value.ToString()))
            {
                new ValidationResult("Name exists");
            }
            return ValidationResult.Success;
        }
    }
}
