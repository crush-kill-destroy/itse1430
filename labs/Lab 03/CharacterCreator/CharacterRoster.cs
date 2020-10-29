using System;
using System.Collections.Generic;
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
            return character;
        }

        public List<Character> GetAll ()
        {
            var characters = new List<Character>();
            return characters;
        }
        public void Update ( int id, Character character )
        {
            //TODO: Character = invalid
            //TODO: Existing character cannot be found or is invalid
            //TODO: The character's name is changed and another character has that name.
            return null;
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

        private Character CopyMachine(Character original)
        {
            var copy = new Character();
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
            return copy;
        }

        private int _id = 1;
        private List<Character> _characters = new List<Character>();
    }
}