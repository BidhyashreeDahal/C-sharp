/* Title :Constants.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to Contain the constants used throughout the program
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3D_D.Classes
{
    public static class Constants
    {
        public enum Alignments
        {
            Lawfulgood, Neutralgood, Chaoticgood, LawfulNeutral, Neutral, Chaoticneutral, Lawfulevel, Neutralevil, Chaoticevil
        };
        /// <summary>
        /// Defines the different attributes a character can possess.
        /// </summary>
        public enum Attributes
        {
            Strength , Dexterity, Constitution, Intelligence, Wisdom, Charisma 
        }
        /// <summary>
        /// Defines the different genders a character can identify with.
        /// </summary>
        public enum Gender
        {
            Male, Female, Diverse
        };
    }
}
