/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 05
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CharacterCreator
{
    public class Character : IValidatableObject
    {
        public const int MinStat = 1;
        public const int MaxStat = 100;
        [StringLength(30)]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Job { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Race { get; set; }

        public int Id { get; set; }
        [Range(MinStat, MaxStat)]
        public int Brawn { get; set; }
        [Range(MinStat, MaxStat)]
        public int Brains { get; set; }
        [Range(MinStat, MaxStat)]
        public int Luck { get; set; }
        [Range(MinStat, MaxStat)]
        public int Sanity { get; set; }
        [Range(MinStat, MaxStat)]
        public int Moxie { get; set; }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required!", new[] { nameof(Name) });
            if (Name.Length > 30)
                yield return new ValidationResult("Name is too long!", new[] { nameof(Name) });
            if (!String.IsNullOrEmpty(Description))
                if (Description.Length > 500)
                    yield return new ValidationResult("Description is too long!", new[] { nameof(Description) });
            if (!ValidateStat(Brawn))
                yield return new ValidationResult("Brawn out of bounds!", new[] { nameof(Brawn) });
            if (!ValidateStat(Brains))
                yield return new ValidationResult("Brains out of bounds!", new[] { nameof(Brains) });
            if (!ValidateStat(Moxie))
                yield return new ValidationResult("Moxie out of bounds!", new[] { nameof(Moxie) });
            if (!ValidateStat(Luck))
                yield return new ValidationResult("Luck out of bounds!", new[] { nameof(Luck) });
            if (!ValidateStat(Sanity))
                yield return new ValidationResult("Sanity out of bounds!", new[] { nameof(Sanity)} );
            if (String.IsNullOrEmpty(Job))
                yield return new ValidationResult("Get a job!", new[] { nameof(Job) } );
            if (String.IsNullOrEmpty(Race))
                yield return new ValidationResult("Can't leave race empty!", new[] { nameof(Race) } );
        }

        public bool ValidateStat ( int stat )
        {
            return stat >= 1 && stat <= 100;
        }


        public override string ToString ()
        {
            return Name;
        }
    }
}
