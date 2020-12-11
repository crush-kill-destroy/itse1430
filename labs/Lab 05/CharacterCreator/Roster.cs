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
using System.Windows.Forms;

namespace CharacterCreator
{
    public class Roster : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            var validation = new ObjectValidator();
            var validationResults = validation.TryValidateFullObject(character);
            var error = validation.GetValidationResults(validationResults);
            error += NameCheck(character.Name, character.Id);

            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Addition Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            character.Id = s_id++;
            _characters.Add(character);
            return character;
        }

        /// <summary>Deletes a character</summary>
        public void Delete ( int id )
        {
            var error = IdLessThanZero(id);
            if (error == true)
                return;

            var character = IdMatch(id);
            _characters.Remove(character);
        }

        private bool IdLessThanZero (int id)
        {
            if (id <= 0)
            {
                MessageBox.Show("ID is out of range!", "Delete Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
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
            var validation = new ObjectValidator();
            var validationResults = validation.TryValidateFullObject(update);
            var error = validation.GetValidationResults(validationResults);
            error += NameCheck(update.Name, update.Id);
            var original = IdMatch(id);

            if (original == null)
                error += "Character not found!";
            else
            {
                validationResults = validation.TryValidateFullObject(original);
                error += validation.GetValidationResults(validationResults);
            }

            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Update Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CloneCharacter(update, original);
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

        private static int s_id = 1;
        private List<Character> _characters = new List<Character>();
    }
}