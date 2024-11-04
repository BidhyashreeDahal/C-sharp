/*
 * Title : Spider.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to  define a Spider class that represents various attributes of a spider, 
 * such as species, name, leg count, venom status, web strength, size, and habitats. 
 * It also includes functionality to compare spiders based on their web strength, calculate the average size of spiders, 
 * and manage spider habitats.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
        /// <summary>
        /// Spider class represents spiders with various characteristics such as species,
        /// name, leg count, venom status , web strength and habitats.
        /// </summary>
        public class Spider
        {
        #region Fields
        /// <summary>
        /// Static field to generate unique spiderID for each spider instance 
        /// </summary>
        private static int _autoIncrementID = 1;

            /// <summary>
            /// Gets the unique identifier for the spider. 
            /// This is autoincremented and acts as a primary key.
            /// </summary>
            public int SpiderID { get; private set; }
            /// <summary>
            /// Gets or sets the species(Scientific name) of the spider
            /// </summary>
            public string Species { get; set; }
            /// <summary>
            /// Gets or sets the custom name of the spider.
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// Strores the value of the leg Count.
            /// </summary>
            private int _legCount;
            /// <summary>
            /// Gets or sets the number of legs the spider has. 
            /// Validates that the leg count must be between 0 and 8.
            /// </summary>
            public int LegCount
            {
                get { return _legCount; }
                set
                {
                    // Validation: must be between 0 and 8
                    if (value < 0 || value > 8)
                        throw new ArgumentException("LegCount must be between 0 and 8.");
                    _legCount = value;
                }
            }
            /// <summary>
            /// Gets and sets the value indicating weather the spider is Venomous.
            /// </summary>
            public bool IsVenomous { get; set; }
            /// <summary>
            /// Stores the web strength Value.
            /// </summary>
            private double _webStrength;
            /// <summary>
            /// Gets or sets the webstrength of the Strength of the spider. Validates that the webstrength must be between 0 and 100.
            /// </summary>
            public double WebStrength
            {
                get { return _webStrength; }
                set
                {
                    // Validation: must be between 0 and 100
                    if (value < 0 || value > 100)
                        throw new ArgumentException("WebStrength must be between 0 and 100.");
                    _webStrength = value;
                }
            }
            /// <summary>
            /// Get or set the size of a spider in Centi Meter.
            /// </summary>
            public double SizeInCM { get; set; }
            /// <summary>
            /// Gets or Sets the date and time the spider was discovered.
            /// </summary>
            public DateTime DateDiscovered { get; set; }
            /// <summary>
            /// Get or sets the list of foods that the spider eat.
            /// </summary>
            public List<string> Foods { get; set; }

            /// <summary>
            /// Initializes the new instance of spider class with default value.
            /// </summary>
            public Spider()
            {
                SpiderID = _autoIncrementID++;
                Species = "Unknown";
                Name = "Unnamed";
                LegCount = 8; // Default to 8 legs
                IsVenomous = false; // Default to non-venomous
                WebStrength = 50; // Default web strength
                SizeInCM = 10; // Default size in mm
                DateDiscovered = DateTime.Now; // Set to now
                Foods = new List<string>(); // Initialize the habitats list
            }

            /// <summary>
            /// Initializes the new instances of the spider class with specified value.
            /// </summary>
            /// <param name="species">The species(scientific name ) of spider</param>
            /// <param name="name">The custom name of spider</param>
            /// <param name="legCount">The number of leg that the spider has(must be between 0 and 8)</param>
            /// <param name="isVenomous">Indicate weather the spider is venomous.</param>
            /// <param name="webStrength">The strength of spider web must be between 0 and 100</param>
            /// <param name="sizeInMM">The size of Spider in Centimeter.</param>
            /// <param name="dateDiscovered">The date when the spider was discovered.</param>
            public Spider(string species, string name, int legCount, bool isVenomous, double webStrength, double sizeInMM, DateTime dateDiscovered)
            {
                SpiderID = _autoIncrementID++;
                Species = species;
                Name = name;
                LegCount = legCount;
                IsVenomous = isVenomous;
                WebStrength = webStrength;
                SizeInCM = sizeInMM;
                DateDiscovered = dateDiscovered;
                Foods = new List<string>(); // List of the food.
            }

            /// <summary>
            /// Returns the description of the spiders including species, name, venome status, web strength and size.
            /// </summary>
            /// <returns></returns>
            public string GetSpiderDescription()
            {
                return $"Species: {Species}, Name: {Name}, Venomous: {IsVenomous}, Web Strength: {WebStrength}, Size: {SizeInCM} cm";
            }
            /// <summary>
            /// Add the food to the spiders list of food.
            /// </summary>
            /// <param name="food">The food to add</param>
            public void AddFood(string food)
            {
                Foods.Add(food);
            }

            /// <summary>
            /// Compare the strength of the two spiders.
            /// </summary>
            /// <param name="spiderOne">The first Spider</param>
            /// <param name="spiderTwo">The second spider</param>
            /// <returns>Returns an integer reperenting the result of the comparision. 
            /// -1 if spiderOne has weaker strength. 0 if both have equal strength , 1 if stronger
            /// </returns>
            public static int CompareWebStrength(Spider spiderOne, Spider spiderTwo)
            {
                return spiderOne.WebStrength.CompareTo(spiderTwo.WebStrength);
            }
            /// <summary>
            /// Calculates the average size of the spider in CM.
            /// </summary>
            /// <param name="spiders">The list of spiders</param>
            /// <returns>Average size of the spiders. </returns>
            public static double AverageSize(List<Spider> spiders)
            {
                double totalSize = 0;
                foreach (var spider in spiders)
                {
                    totalSize += spider.SizeInCM;
                }
                return totalSize / spiders.Count;
            }

            /// <summary>
            /// A method the spiders leg count and web strength to default value.
            /// </summary>
            public void SetDefaults()
            {
                LegCount = 8;
                WebStrength = 50;
            }
        }

    }



