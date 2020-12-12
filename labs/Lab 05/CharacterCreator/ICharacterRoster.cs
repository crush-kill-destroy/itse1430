/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 05
 */

using System.Collections.Generic;

namespace CharacterCreator
{
    public interface ICharacterRoster
    {
        Character Add ( Character character );
        void Delete ( int id );
        Character Get ( int id );
        IEnumerable<Character> GetAll ();
        void Update ( int id, Character replacement );
    }
}