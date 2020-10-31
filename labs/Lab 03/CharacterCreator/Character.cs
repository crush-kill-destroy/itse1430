/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 03
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CharacterCreator
{
    /// <summary>Represents a character.</summary>
    public class Character : IValidatableObject
    {
        /// <summary>Gets the maximum attribute value.</summary>
        public const int MaximumAttributeValue = 100;

        /// <summary>Gets the minimum attribute value.</summary>
        public const int MinimumAttributeValue = 1;

        /// <summary> A unique identifier for the character. </summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        /// <summary>Gets or sets the biography.</summary>
        public string Biography
        {
            get { return _bio ?? ""; }
            set { _bio = value; }
        }

        /// <summary>Gets or sets the profession.</summary>
        public Profession Profession { get; set; }

        /// <summary>Gets or sets the race.</summary>
        public Race Race { get; set; }

        /// <summary>Gets or sets the strength.</summary>
        public int Strength { get; set; }

        /// <summary>Gets or sets the intelligence.</summary>
        public int Intelligence { get; set; }

        /// <summary>Gets or sets the agility.</summary>
        public int Agility { get; set; }

        /// <summary>Gets or sets the constitution.</summary>
        public int Constitution { get; set; }

        /// <summary>Gets or sets the charisma.</summary>
        public int Charisma { get; set; }

        private bool ValidateAttribute ( int value )
        {
            return (value >= MinimumAttributeValue) && (value <= MaximumAttributeValue);
        }

        /// <summary>Represents the name and bio, respectively.</summary>
        private string _name, _bio;

        /// <summary>Validates the results</summary>
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required", new[] { nameof(Name) });

            if (Profession == null)
                yield return new ValidationResult("Profession is required", new[] { nameof(Profession) });

            if (Race == null)
                yield return new ValidationResult("Race is required", new[] { nameof(Race) });

            if (!ValidateAttribute(Strength))
                yield return new ValidationResult($"Strength must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Strength) });
            if (!ValidateAttribute(Intelligence))
                yield return new ValidationResult($"Intelligence must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Intelligence) });
            if (!ValidateAttribute(Agility))
                yield return new ValidationResult($"Agility must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Agility) });
            if (!ValidateAttribute(Constitution))
                yield return new ValidationResult($"Constitution must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Constitution) });
            if (!ValidateAttribute(Charisma))
                yield return new ValidationResult($"Charisma must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Charisma) });
        }

        public override string ToString ()
        {
            return Name;
        }
    }
}
