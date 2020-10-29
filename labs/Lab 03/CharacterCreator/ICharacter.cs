/*
 * ITSE 1430
 * Character Creator
 * 
 * Sample implementation.
 */
namespace CharacterCreator
{
    public interface ICharacter
    {
        int Agility { get; set; }
        string Biography { get; set; }
        int Charisma { get; set; }
        int Constitution { get; set; }
        int Intelligence { get; set; }
        string Name { get; set; }
        Profession Profession { get; set; }
        Race Race { get; set; }
        int Strength { get; set; }

        bool Validate ( out string errorMessage );
    }
}