﻿/*
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
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the profession.</summary>
        public Profession Job { get; set; }

        /// <summary>Gets or sets the race.</summary>
        public Race Race { get; set; }

        /// <summary>Gets or sets the strength.</summary>
        public int Brawn { get; set; }

        /// <summary>Gets or sets the intelligence.</summary>
        public int Brains { get; set; }

        /// <summary>Gets or sets the agility.</summary>
        public int Luck { get; set; }

        /// <summary>Gets or sets the constitution.</summary>
        public int Sanity { get; set; }

        /// <summary>Gets or sets the charisma.</summary>
        public int Moxie { get; set; }

        private bool ValidateAttribute ( int value )
        {
            return (value >= MinimumAttributeValue) && (value <= MaximumAttributeValue);
        }

        /// <summary>Represents the name and bio, respectively.</summary>
        private string _name, _description;

        /// <summary>Validates the results</summary>
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required", new[] { nameof(Name) });

            if (Job == null)
                yield return new ValidationResult("Profession is required", new[] { nameof(Job) });

            if (Race == null)
                yield return new ValidationResult("Race is required", new[] { nameof(Race) });

            if (!ValidateAttribute(Brawn))
                yield return new ValidationResult($"Strength must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Brawn) });
            if (!ValidateAttribute(Brains))
                yield return new ValidationResult($"Intelligence must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Brains) });
            if (!ValidateAttribute(Luck))
                yield return new ValidationResult($"Agility must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Luck) });
            if (!ValidateAttribute(Sanity))
                yield return new ValidationResult($"Constitution must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Sanity) });
            if (!ValidateAttribute(Moxie))
                yield return new ValidationResult($"Charisma must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Moxie) });
        }

        public override string ToString ()
        {
            return Name;
        }
    }
}
