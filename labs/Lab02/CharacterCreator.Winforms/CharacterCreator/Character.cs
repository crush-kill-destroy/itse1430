/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 02
 */

using System;

namespace CharacterCreator
{
    /// <summary> Standard RPG character creator for your general Roll20 purposes. </summary>
    /// <remarks>
    /// Characters have a name, a job, a race, and stats.
    /// Optionally, they may have a description.
    /// Stats are Brawn, Brains, Moxie, Luck, and Sanity.
    /// Stats can be between 1 and 100, except Brains, which can be between -2,000,000 and 100.
    /// Genius goes a long way, but stupidity is truly infinite.
    /// </remarks>
    public class Character
    {
        public const int MaxNameLength = 20;
        public const int MaxDescriptionLength = 250;
        public const int MaxStat = 100;
        public const int MinStat = 1;
        public const int MinBrains = -2000000;

        private string _name;
        public int Brawn { get; set; }
        public int Brains { get; set; }
        public int Moxie { get; set; }
        public int Luck { get; set; }
        public int Sanity { get; set; }
        private string _description;
        private string _profession;
        private string _race;

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }

        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        /// <summary> Validates the character outside of the UI. </summary>
        /// <remarks>
        /// Checks if the name is empty and the appropriate size.
        /// Checks if the description is smaller than the max size.
        /// Checks all of the stats to see if they're in range.
        /// Checks if you have a race and a profession.
        /// </remarks>
        /// <returns> Returns the type of error or null if it passes. </returns>
        public string Validate()
        {
            if (String.IsNullOrEmpty(Name))
                return "Name is required!";

            else if (Name.Length > MaxNameLength)
                return "Name is too long!";

            else if (Description.Length > MaxDescriptionLength)
                return "Description is too long!";

            else if (!ValidateStat("Brawn", Brawn, out var error))
                return error;

            else if (!ValidateStat("Moxie", Moxie, out error))
                return error;

            else if (!ValidateStat("Luck", Luck, out error))
                return error;

            else if (!ValidateStat("Sanity", Sanity, out error))
                return error;

            else if (!ValidateStat("Brains", Brains, MinBrains, out error))
                return error;

            else if (String.IsNullOrEmpty(Profession))
                return "Get a job!";

            else  if (String.IsNullOrEmpty(Race))
                return "Can't leave race empty!";

            return null;
        }

        /// <summary>This is a pass-through for the overloaded Validate Stat./// </summary>
        private bool ValidateStat(string name, int stat, out string error)
        {
            return ValidateStat(name, stat, MinStat, out error);
        }

        ///<summary>This checks if the stats you have are in range.</summary>
        ///<param name="min">Minimum bound.</param>
        ///<param name="name">Name of the stat</param>
        ///<param name="error">Returns whether it was too high or too low. Null on success.</param>
        ///<param name="stat">The number getting checked</param>
        ///<returns>Returns true if valid, false if invalid, and the string error with the problem, or null if it passes.</returns>
        private bool ValidateStat(string name, int stat, int min, out string error)
        {
            if (stat < min)
            {
                error = $"{name} must be at least {min}";
                return false;
            }

            if (stat > MaxStat)
            {
                error = $"{name} can't be higher than {MaxStat}";
                return false;
            }

            error = null;
            return true;
        }
    }
}