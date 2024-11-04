/* Title :Race.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to Contain the races of the character
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3D_D.Classes
{
    /// <summary>
    /// Represents a character's race with associated attributes.
    /// </summary>
    public class Race
    {
        //Properities of the class Race
        /// <summary>
        /// Gets or sets the name of the race.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the description of the race.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the strength attribute of the race.
        /// </summary>
        public int Strength {  get; set; }
        /// <summary>
        /// Gets or sets the dexterity attribute of the race.
        /// </summary>
        public int Dexterity {  get; set; }
        /// <summary>
        /// Gets or sets the constitution attribute of the race.
        /// </summary>
        public int Constitution {  get; set; }
        /// <summary>
        /// Gets or sets the intelligence attribute of the race.
        /// </summary>
        public int Intelligence {  get; set; }
        /// <summary>
        /// Gets or sets the wisdom attribute of the race.
        /// </summary>
        public int Wisdom {  get; set; }
        /// <summary>
        /// Gets or sets the charisma attribute of the race.
        /// </summary>
        public int Charisma {  get; set; }
        /// <summary>
        /// A static list of available races with their attributes.
        /// </summary>

        public static List<Race> RaceDetail = new List<Race>()
       {
           new Race{Name = "Dwarf", Description = "Strong, hardy, and skilled in craftsmanship.", Strength = 2 ,Constitution = 2 },
           new Race{Name = "Elf(High)", Description = "Graceful, magical, and wise.", Dexterity = 2 ,Intelligence = 1 },
           new Race{Name = "Elf(Wood)", Description = "Stealthy, agile, and nature-loving.", Dexterity = 2 ,Wisdom = 1 },
           new Race{Name = "Halfing", Description = "Cheerful, lucky, and nimble.", Dexterity = 2 ,Charisma = 1 },
           new Race{Name = "Human", Description = "Versatile, ambitious, and adaptable", Strength = 1, Dexterity = 1, Constitution = 1, Intelligence = 1, Wisdom= 1, Charisma = 1},
           new Race{Name = "Dragonborn", Description = "Proud, strong, and draconic-powered.", Strength = 2 ,Charisma = 1 },
           new Race{Name = "Gnome", Description = "Curious, inventive, and playful.",Dexterity =1, Intelligence = 2 },
           new Race{Name = "Half-Elf", Description = " Charismatic, adaptable, and bridge between races.", Dexterity = 1 ,Intelligence = 1,Charisma = 2 },
           new Race{Name = "Half-Orc", Description = "Fierce, strong, and resilient.", Strength = 2 ,Constitution = 1 },
           new Race{Name = "Tiefling", Description = "Mysterious, magical, and infernal-touched.", Intelligence = 1 ,Charisma = 2 },
           new Race{Name = "Githyanki", Description = "Skilled, psionic, and independent.", Strength = 1 ,Dexterity = 2 },
          
       };
        /// <summary>
        /// Finds a race by its name.
        /// </summary>
        /// <param name="Racename">The name of the race to find.</param>
        /// <returns>The  Race object if found; otherwise, null.</returns>
        public static Race FindRace(String Racename)
        {
            foreach (Race race in RaceDetail)
            {
                if (race.Name == Racename) return race;
            }
            return null;
        }

        
    }
}
