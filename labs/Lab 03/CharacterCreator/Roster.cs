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
    public class Roster : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            //TODO: ERROR: Character is invalid
            //TODO: ERROR: Check ID

            //if (NameCheck(character.Name) != true)
            //    return null;

            character.Id = _id++;
            _characters.Add(character);
            return character;
        }

        public void Delete ( int id )
        {
            //TODO: ERROR ID <= 0
            var character = IdMatch(id);
            _characters.Remove(character);
        }

        public Character Get ( int id )
        {
            var character = IdMatch(id);
            return (character == null) ? null : CopyCharacter(character);
        }

        public IEnumerable<Character> GetAll ()
        {
            foreach (var character in _characters)
                yield return CopyCharacter(character);
        }

        public void Update ( int id, Character update )
        {
            //TODO: validate ID, validate name, validate character
            var original = IdMatch(id);
            CloneCharacter(update, original);
        }

        private Character IdMatch ( int id )
        {
            foreach (var character in _characters)
            {
                if (character?.Id == id)
                    return character;
            }

            return null;
        }

        private Character CopyCharacter(Character original)
        {
                var copy = new Character();
                CloneCharacter(original, copy);
                return copy;
        }

        private void CloneCharacter ( Character original, Character copy )
        {
            copy.Id = original.Id;
            copy.Name = original.Name;
            copy.Profession = original.Profession;
            copy.Race = original.Race;
            copy.Biography = original.Biography;
            copy.Agility = original.Agility;
            copy.Charisma = original.Charisma;
            copy.Strength = original.Strength;
            copy.Intelligence = original.Intelligence;
            copy.Constitution = original.Constitution;
        }

        private bool NameCheck(string name)
        {
            foreach (var character in GetAll())
                if (character.Name == name)
                    return false;

            return true;
        }

        private static int _id = 1;
        private List<Character> _characters = new List<Character>();
    }
}