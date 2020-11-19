/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 04
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary>This class just helps make validating objects easier.</summary>
    public static class ObjectValidator
    {
        /// <summary>Automates validating objects.</summary>
        public static IEnumerable<ValidationResult> TryValidateFullObject ( IValidatableObject value )
        {
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), validationResults, true);

            return validationResults;
        }

        /// <summary>Turns errors into a list.</summary>
        public static string GetValidationResults ( IEnumerable<ValidationResult> errors )
        {
            var builder = new StringBuilder();
            foreach (var error in errors)
                builder.AppendLine(error.ToString());

            return builder.ToString();
        }

        /// <summary>Wraps up all the validation.</summary>
        public static string CompletelyValidate ( IValidatableObject value )
        {
            var passThrough = ObjectValidator.TryValidateFullObject(value);
            var passedTo = ObjectValidator.GetValidationResults(passThrough);
            return passedTo;
        }
    }
}
