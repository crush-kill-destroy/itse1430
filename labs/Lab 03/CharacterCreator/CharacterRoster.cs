using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class CharacterRoster : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            //TODO: ERROR: Character is invalid
            //TODO: ERROR: Check ID

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
            //TODO: ERROR ID <= 0
            var character = IdMatch(id);
            return (character == null) ? null : CopyCharacter(character);
        }

        public IEnumerable<Character> GetAll ()
        {
            foreach (var character in _characters)
                yield return CopyCharacter(character);
        }

        public void Update ( int id, Character replacement )
        {
            //TODO: validate ID, validate name, validate character, check for null
            var original = IdMatch(id);
            CloneCharacter(original, replacement);
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
                var replacement = new Character();
                CloneCharacter(original, replacement);
                return original;
        }

        private void CloneCharacter ( Character original, Character replacement )
        {
            original.Id = replacement.Id;
            original.Name = replacement.Name;
            original.Profession = replacement.Profession;
            original.Race = replacement.Race;
            original.Biography = replacement.Biography;
            original.Agility = replacement.Agility;
            original.Charisma = replacement.Charisma;
            original.Strength = replacement.Strength;
            original.Intelligence = replacement.Intelligence;
            original.Constitution = replacement.Constitution;
        }

        private static int _id = 1;
        private List<Character> _characters = new List<Character>();
    }
}