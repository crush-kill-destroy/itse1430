/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nile
{
    /// <summary>Represents a product.</summary>
    public class Product : IValidatableObject
    {
        /// <summary>Gets or sets the unique identifier.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>Never returns null.</value>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value?.Trim(); }
        }
        
        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary>Gets or sets the price.</summary>
        public decimal Price { get; set; } = 0;      

        /// <summary>Determines if discontinued.</summary>
        public bool IsDiscontinued { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 0)
                yield return new ValidationResult("ID must be greater than 0!", new[] { nameof(Id) });

            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name cannot be empty!", new[] { nameof(Name) });

            if (Price < 0)
                yield return new ValidationResult("Prices cannot be empty!", new[] { nameof(Price) });
        }

        public override string ToString()
        {
            return Name;
        }

        #region Private Members

        private string _name;
        private string _description;
        #endregion
    }
}
