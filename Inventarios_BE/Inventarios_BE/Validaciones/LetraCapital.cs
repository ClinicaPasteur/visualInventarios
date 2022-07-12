using System.ComponentModel.DataAnnotations;

namespace Inventarios_BE.Validaciones
{
    public class LetraCapital: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return ValidationResult.Success;

            var letra = value.ToString()[0].ToString();
            if(letra != letra.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayuscula.");
            }
            return ValidationResult.Success;
        }
    }
}
