/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 03
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    /// <summary>This class just helps make validating objects easier.</summary>
    public class ObjectValidator
    {
        /// <summary>Automates validating objects.</summary>
        public IEnumerable<ValidationResult> TryValidateFullObject ( IValidatableObject value )
        {
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), validationResults, true);

            return validationResults;
        }

        /// <summary>Turns errors into a list.</summary>
        public string GetValidationResults ( IEnumerable<ValidationResult> errors )
        {
            if (!errors.Any())
                return null;
            var builder = new StringBuilder();
            foreach (var error in errors)
                builder.AppendLine(error.ToString());

            return builder.ToString();
        }
    }

}
