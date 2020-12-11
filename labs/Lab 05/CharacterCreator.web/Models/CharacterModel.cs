using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharacterCreator.web.Models
{
    public class CharacterModel : IValidatableObject
    {
        public CharacterModel ()
        { }
        public CharacterModel (Character character)
        {
            Id = character.Id;
            Name = character.Name;
            Race = character.Race;
            Job = character.Job;
            Description = character.Description;
            Brawn = character.Brawn;
            Brains = character.Brains;
            Luck = character.Luck;
            Sanity = character.Sanity;
            Moxie = character.Moxie;
        }

        [Required(AllowEmptyStrings = false)]
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Job { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Race { get; set; }
        public int Id { get; set; } = 1;
        [Range(1, 100)]
        public int Brawn { get; set; } = 50;
        [Range(1, 100)]
        public int Brains { get; set; } = 50;
        [Range(1, 100)]
        public int Luck { get; set; } = 50;
        [Range(1, 100)]
        public int Sanity { get; set; } = 50;
        [Range(1, 100)]
        public int Moxie { get; set; } = 50;
        public bool uniqueName = true;
        public bool uniqueId = true;

        

        public Character Convert()
        {
            return new Character {
                Id = Id,
                Name = Name,
                Brawn = Brawn,
                Brains = Brains,
                Luck = Luck,
                Sanity = Sanity,
                Moxie = Moxie,
                Job = Job,
                Race = Race,
                Description = Description,
            };
        }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (!uniqueName)
                yield return new ValidationResult("Names must be unique!", new[] { nameof(Name) });
            if (!uniqueId)
                yield return new ValidationResult("IDs must be unique!", new[] { nameof(Id) });
        }
    }
}
