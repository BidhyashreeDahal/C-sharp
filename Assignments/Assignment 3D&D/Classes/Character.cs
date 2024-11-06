/* Title :Race.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to Contain Sample character and the properties of the character.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3D_D.Classes
{
    /// <summary>
    /// Represents a character with various attributes, including class, race, alignment, gender, 
    /// and ability scores such as strength and dexterity. The character also includes properties
    /// for experience points, armor class, initiative, speed, and hit points.
    /// </summary>
    public class Character
    {
        #region Character Properties
        /// <summary>
        /// Gets or sets the name of the character.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Get or sets the Class for the character
        /// </summary>
        public Classes CharacterClass { get; set; }
        /// <summary>
        /// Get or sets the Race for the character
        /// </summary>
        public Race CharacterRace { get; set; }
        /// <summary>
        /// Get or sets the Alignment for the character
        /// </summary>
        public Constants.Alignments Alignments { get; set; }
        /// <summary>
        /// Get or sets the Gender of the character
        /// </summary>
        public Constants.Gender Gender { get; set; }
        // <summary>
        /// The character's Strength attribute. Determines physical power,
        /// impacting abilities like melee attacks and carrying capacity.
        /// </summary> 
        public Constants.Attributes Strength { get; set; }
        /// <summary>
        /// The character's Dexterity attribute. Represents agility and reflexes,
        /// influencing actions like ranged attacks and armor class.
        /// </summary>
        public Constants.Attributes Dexterity { get; set; }
        /// <summary>
        /// The character's Constitution attribute. Measures health and endurance,
        /// affecting hit points and resistance to physical damage.
        /// </summary>
        public Constants.Attributes Constitution { get; set; }
        /// <summary>
        /// The character's Intelligence attribute. Reflects mental acuity and
        /// reasoning skills, impacting spellcasting abilities for some classes.
        /// </summary>
        public Constants.Attributes Intelligence { get; set; }
        /// <summary>
        /// The character's Wisdom attribute. Represents perceptiveness and insight,
        /// often used in spellcasting and skill checks for awareness.
        /// </summary>
        public Constants.Attributes Wisdom { get; set; }
        /// <summary>
        /// The character's Charisma attribute. Represents personal magnetism and
        /// charm, which affects social interactions and spellcasting for certain classes.
        /// </summary>
        public Constants.Attributes Charisma { get; set; }

        public int ExperiencePoint { get; set; }
        public int ArmourCLass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int HitPoints { get; set; }
        
        public int remainingPoints = 27;
        private int totalPoints = 27;
        private int allocatedPoints = 0;
        private const int BaseAttributeValue = 8;
        private const int MaxAttributeValue = 20;
       
        // List to store the all created characters
        public static List<Character> Characters = new List<Character>();
       #endregion
        #region Constructors
        /// <summary>
        /// Initializes the new instance of the character clas with default value.
        /// </summary>
        public Character()
        { 
            Name= this.Name;
            CharacterClass = this.CharacterClass;
            CharacterRace = this.CharacterRace;
            Constants.Alignments Alignments = this.Alignments;
            Constants.Gender Gender = this.Gender;
            

        }
        /// <summary>
        /// Initializes a new instance of the character class with specified values.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="characterClass">The character's class.</param>
        /// <param name="characterRace">The character's race.</param>
        /// <param name="alignment">The character's alignment.</param>
        /// <param name="gender">The character's gender.</param>
        public Character(String name, Classes characterClass, Race characterRace, Constants.Alignments alignment, Constants.Gender gender)
        {
            Name = name;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
            Constants.Alignments Alignments = alignment;
            Constants.Gender Gender = gender;
            totalPoints = 27; 
            allocatedPoints = 0; 
            remainingPoints = totalPoints; 
            InitializeBaseStats();
            ApplyDefaultRaceBonuses();
            ApplyDefaultGenderBonuses();
            ApplyDefaultClassBonuses();
            CalculateRemainingPoints();

           
        }
        #endregion
        #region SampleCharacter
        // <summary>
        /// Populates the <see cref="Characters"/> list with sample characters.
        /// </summary>

        public static void PopulateSampleCharacters()
        {
            Classes barbarianClass = Classes.FindClass("Barbarian");
            Race dwarfRace = Race.FindRace("Dwarf");
            Character character = new Character("Aragorn", barbarianClass, dwarfRace, Constants.Alignments.Neutral, Constants.Gender.Female);
            Characters.Add(character);
            Characters.Add(new Character("Legolas", Classes.FindClass("Bard"), Race.FindRace("Human"), Constants.Alignments.LawfulNeutral, Constants.Gender.Male));
            Characters.Add(new Character("Megola", Classes.FindClass("Cleric"), Race.FindRace("Gnome"), Constants.Alignments.Chaoticevil, Constants.Gender.Diverse));
            Characters.Add(new Character("Gandalf", Classes.FindClass("Druid"), Race.FindRace("Dragonborn"), Constants.Alignments.Neutralgood, Constants.Gender.Male));
            Characters.Add(new Character("Saruman", Classes.FindClass("Fighter"), Race.FindRace("Githyanki"), Constants.Alignments.Lawfulgood, Constants.Gender.Female));
            Characters.Add(new Character("Solaman", Classes.FindClass("Wizard"), Race.FindRace("Halfing"), Constants.Alignments.Chaoticneutral, Constants.Gender.Diverse));
        }
        #endregion
        #region Attributs Initialization and Apply Default Bonuses
        /// <summary>
        /// Initializes the character's base stats to a specified default value.
        /// </summary>
        public void InitializeBaseStats()
        {
            Strength = (Constants.Attributes)BaseAttributeValue;
            Dexterity = (Constants.Attributes)BaseAttributeValue;
            Wisdom = (Constants.Attributes)BaseAttributeValue;
            Charisma = (Constants.Attributes)BaseAttributeValue;
            Intelligence = (Constants.Attributes)BaseAttributeValue;
            Constitution = (Constants.Attributes)BaseAttributeValue;
           
        }
        /// <summary>
        /// Applies default bonuses to the character based on their race.
        /// </summary>
        public void ApplyDefaultRaceBonuses()
        {
            
            Strength += CharacterRace.Strength;
            Dexterity += CharacterRace.Dexterity;
            Constitution += CharacterRace.Constitution;
            Intelligence += CharacterRace.Intelligence;
            Wisdom += CharacterRace.Wisdom;
            Charisma += CharacterRace.Charisma;
            
        }
       
        /// <summary>
        /// Applies default bonuses to the character based on their gender.
        /// </summary>
        public void ApplyDefaultGenderBonuses()
        {
            if (Gender == Constants.Gender.Male)
            {
                Strength += 1;
                Wisdom += 1;
            }
            else if (Gender == Constants.Gender.Female)
            {
                Dexterity += 1;
                Intelligence += 1;
            }
            else
            {
                Constitution += 1;
                Charisma += 1;
            }
        }
        /// <summary>
        /// Applies default bonuses to the character based on their class.
        /// </summary>
        public void ApplyDefaultClassBonuses()
        {
            if(CharacterClass!= null)
            {
                Strength += CharacterClass.Strength;
                Dexterity += CharacterClass.Dexterity;
                Constitution += CharacterClass.Constitution;
                Intelligence += CharacterClass.Intelligence;
                Wisdom += CharacterClass.Wisdom;
                Charisma += CharacterClass.Charisma;
            }
        }
        #endregion
        #region Point Allocation
        /// <summary>
        /// Allocates points to a specified attribute, updating the remaining points accordingly.
        /// </summary>
        /// <param name="attribute">The attribute to allocate points to.</param>
        /// <param name="points">The number of points to allocate.</param>
        /// <returns>The cost in points for the allocation.</returns>
        public int AllocatePoints(Constants.Attributes attribute, int points)
        {
            int currentBaseValue = GetBaseAttributeValue(attribute);
            int newValue = currentBaseValue + points;
            if (newValue > MaxAttributeValue)
            {
                MessageBox.Show($"Attribute cannot exceed {MaxAttributeValue} after bonuses.");
                
            }
            int cost =  CalculateCost(newValue);
            if (cost > remainingPoints)
            {
                MessageBox.Show("Not enough remaining points.");
            }
            SetBaseAttributeValue(attribute, newValue);
            allocatedPoints += cost;
            remainingPoints -= cost;
            return cost;
            
        }
        // <summary>
        /// Calculates the remaining points available for allocation after accounting for allocated points.
        /// </summary>
        /// <returns>The remaining points available for allocation.</returns>
        public int CalculateRemainingPoints()
        {
            remainingPoints = totalPoints - allocatedPoints;// Calculate remaining points  
            if (remainingPoints <= 0)
            {
                MessageBox.Show("All points have been finished");
                remainingPoints = 0;

            }
            return remainingPoints;
        }

        #endregion
        #region Getters and Setters 
        /// <summary>
        /// Gets the base value of a specified attribute.
        /// </summary>
        /// <param name="attribute">The attribute to retrieve.</param>
        /// <returns>The base value of the specified attribute.</returns>
        public int GetBaseAttributeValue(Constants.Attributes attribute)
        {
            switch (attribute)
            {
                case Constants.Attributes.Strength:
                    return (int)Strength;
                case Constants.Attributes.Dexterity:
                    return (int)Dexterity;
                case Constants.Attributes.Constitution:
                    return (int)Constitution;
                case Constants.Attributes.Intelligence:
                    return (int)Intelligence;
                case Constants.Attributes.Wisdom:
                    return (int)Wisdom;
                case Constants.Attributes.Charisma:
                    return (int)Charisma;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Sets the base value of a specified attribute.
        /// </summary>
        /// <param name="attribute">The attribute to set.</param>
        /// <param name="value">The value to assign to the attribute.</param>

        public void SetBaseAttributeValue(Constants.Attributes attribute, int value)
        {
            switch (attribute)
            {
                case Constants.Attributes.Strength: Strength = (Constants.Attributes)value; break;
                case Constants.Attributes.Dexterity: Dexterity = (Constants.Attributes)value; break;
                case Constants.Attributes.Constitution: Constitution = (Constants.Attributes)value; break;
                case Constants.Attributes.Intelligence: Intelligence = (Constants.Attributes)value; break;
                case Constants.Attributes.Wisdom: Wisdom = (Constants.Attributes)value; break;
                case Constants.Attributes.Charisma: Charisma = (Constants.Attributes)value; break;
            }
        }
        #endregion
        #region Helper Methods
        /// Calculates the cost in points for increasing an attribute to a specified value.
        /// </summary>
        /// <param name="newValue">The new attribute value.</param>
        /// <returns>The cost in points for the specified value.</returns
        private int CalculateCost(int newValue)
        {
            if (newValue < 8 || newValue > 20)
                MessageBox.Show("Attribute value must be between 8 and 20.");

            if (newValue <= 13 && newValue >= 8) return 1;
            if (newValue <= 18 && newValue >= 14) return 2;
            else return 3; // 19-20  
        }
        /// <summary>
        /// Finds a character in the <see cref="Characters"/> list by name.
        /// </summary>
        /// <param name="Charactername">The name of the character to find.</param>
        /// <returns>The character with the specified name, or <c>null</c> if not found.</returns>
        public static Character FindCharacter(String Charactername)
        {
            foreach (Character character in Characters)
            {
                if (character.Name == Charactername) return character;
            }
            return null;
        }
        #endregion
    }
}