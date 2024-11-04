/* Title :Race.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to Contain the classes of the character
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3D_D.Classes
{
    /// <summary>
    /// Represents a character class with associated attributes and abilities.
    /// </summary>
    public class Classes
    {
        // <summary>
        /// Gets or sets the name of the class.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the hit dice for the class, determining health.
        /// </summary>
        public int HpDice { get; set; }
        /// <summary>
        /// Gets or sets the primary ability associated with the class.
        /// </summary>
        public string PrimaryAbility{ get; set; }
        /// <summary>
        /// Gets or sets the strength attribute of the class.
        /// </summary>
        public int Strength { get; set; }
        /// <summary>
        /// Gets or sets the dexterity attribute of the class.
        /// </summary>
        public int Dexterity { get; set; }
        /// <summary>
        /// Gets or sets the constitution attribute of the class.
        /// </summary>
        public int Constitution { get; set; }
        /// <summary>
        /// Gets or sets the intelligence attribute of the class.
        /// </summary>
        public int Intelligence { get; set; }
        /// <summary>
        /// Gets or sets the wisdom attribute of the class.
        /// </summary>
        public int Wisdom { get; set; }
        /// <summary>
        /// Gets or sets the charisma attribute of the class.
        /// </summary>
        public int Charisma { get; set; }
        /// <summary>
        /// Gets or sets the description of the class.
        /// </summary>
        public string Description {  get; set; }
        /// <summary>
        /// A static list of available classes with their attributes and descriptions.
        /// </summary>
        public static List<Classes> classList = new List<Classes>()
        {
            new Classes{Name= "Barbarian",HpDice = 12,PrimaryAbility = "Strength",Strength = 2,Constitution = 1,Description = "A Fierce Warrior of Primal Rage" },
            new Classes{Name= "Bard",HpDice = 8,PrimaryAbility = "Dexterity",Dexterity = 2,Charisma = 1,Description = "An inspiring performer of Music Dance and Magic" },
            new Classes{Name="Cleric",HpDice = 8,PrimaryAbility = "Wisdom",Wisdom = 2, Charisma = 1, Description = "A Miraculour of Divine Power" },
            new Classes{Name="Druid",HpDice = 8,PrimaryAbility= "Intelligence", Intelligence = 2, Wisdom = 1, Description = "A Master of All Arms and Armor" },
            new Classes{Name="Fighter",HpDice = 10,PrimaryAbility= "Strength", Strength = 2, Constitution = 1, Description = "A Master of All Arms and Armor" },
            new Classes{Name ="Monk",HpDice = 8, PrimaryAbility="Dexterity", Dexterity = 2, Strength = 1, Description = "A Martial Artist of Supernatural Focus" },
            new Classes{Name ="Paladin", HpDice = 10, PrimaryAbility = "Strength", Wisdom = 2, Charisma = 1, Description = "A Devout Warrior of Sacred Oaths" },
            new Classes{Name="Ranger", HpDice= 10, PrimaryAbility = "Dexterity", Strength = 2, Dexterity = 1,Description = "A Wandering Warrior Imbued with Primal Magic" },
            new Classes{Name = "Rogue", HpDice = 8,PrimaryAbility = "Dexterity", Intelligence = 2, Dexterity = 1, Description = "A Dexterous Expert in Stealth and Subterfuge" },
            new Classes{Name = "Sorcerer",HpDice= 6, PrimaryAbility = "Charishma", Constitution = 2, Charisma = 1, Description = "A Dazzling Mage Filled with Innate Magic" },
            new Classes{Name ="Warlock",HpDice= 8, PrimaryAbility = "Charishma", Wisdom = 2, Charisma = 1 , Description = "An Occultist Empowered by Otherwordly Pacts " },
            new Classes{Name = "Wizard", HpDice = 6, PrimaryAbility = "Intelligence", Intelligence = 2, Wisdom =1,Description = "A Schoraly Magic-User of Arcance Power" }
        };
        /// <summary>
        /// Finds a class by its name.
        /// </summary>
        /// <param name="className">The name of the class to find.</param>
        /// <returns>The <see cref="Classes"/> object if found; otherwise, null.</returns>
        public static Classes FindClass(string className)
        {
            foreach (Classes singleClass in classList)
            {
                if(singleClass.Name == className) return singleClass;
            }
            return null;
        }
       

    }
   
}
