/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 05
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public class Roster : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            character.Id = _characters.Count() + 1;
            var validationResults = ObjectValidator.TryValidateFullObject(character);
            var error = ObjectValidator.GetValidationResults(validationResults);
            error += NameCheck(character.Name, character.Id);

            if (!String.IsNullOrEmpty(error))
                return null;

            character.Id = s_id++;
            _characters.Add(character);
            SetID();
            return character;
        }

        /// <summary>Deletes a character</summary>
        public void Delete ( int id )
        {
            var character = IdMatch(id);
            _characters.Remove(character);
            SetID();
        }

        /// <summary>Edits a character</summary>
        public Character Get ( int id )
        {
            var character = IdMatch(id);
            return (character == null) ? null : CopyCharacter(character);
        }

        /// <summary>Grabs the entire roster</summary>
        public IEnumerable<Character> GetAll ()
        {
            foreach (var character in _characters)
                yield return CopyCharacter(character);
        }

        /// <summary>Edits a character</summary>
        /// <param name="id">ID of the character to update</param>
        /// <param name="update">The character you are updating it with.</param>
        public void Update ( int id, Character update )
        {
            var validationResults = ObjectValidator.TryValidateFullObject(update);
            var error = ObjectValidator.GetValidationResults(validationResults);
            error += NameCheck(update.Name, update.Id);
            var original = IdMatch(id);

            if (original == null)
                error += "Character not found!";
            else
            {
                validationResults = ObjectValidator.TryValidateFullObject(original);
                error += ObjectValidator.GetValidationResults(validationResults);
            }

            if (!String.IsNullOrEmpty(error))
                return;

            CloneCharacter(update, original);
            SetID();
        }

        /// <summary>Returns characters by their ID</summary>
        private Character IdMatch ( int id )
        {
            foreach (var character in _characters)
            {
                if (character?.Id == id)
                    return character;
            }

            return null;
        }

        /// <summary>Feeds things through CloneCharacter</summary>
        /// <param name="original">The base you are copying from/</param>
        /// <returns>A copy of the original.</returns>
        private Character CopyCharacter(Character original)
        {
                var copy = new Character();
                CloneCharacter(original, copy);
                return copy;
        }

        /// <summary>Copies one character's attirbutes to another.</summary>
        /// <param name="original">Base character to be copied.</param>
        /// <param name="copy">The character to be copied to.</param>
        private void CloneCharacter ( Character original, Character copy )
        {
            copy.Id = original.Id;
            copy.Name = original.Name;
            copy.Job = original.Job;
            copy.Race = original.Race;
            copy.Description = original.Description;
            copy.Luck = original.Luck;
            copy.Moxie = original.Moxie;
            copy.Brawn = original.Brawn;
            copy.Brains = original.Brains;
            copy.Sanity = original.Sanity;
        }

        private string NameCheck(string name, int id)
        {
            foreach (var character in GetAll())
                if (character.Name == name && character.Id != id)
                    return "You're already using that name!";

            return null;
        }

        private void SetID ()
        {
            for (var i = 1; i <= _characters.Count(); i++)
                _characters[i - 1].Id = i;
        }

        private static int s_id = 1;
        private List<Character> _characters = new List<Character>();
    }
}