/*
 * Tools.cs
 * Bidhyashree Dahal
 * 100952513
 * The `Tools.cs` file contains methods to save and load player profiles, manage input devices, 
 * and handle camera perspectives in the Minecraft application. It includes error handling for file
 * operations and profile parsing.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Minecraft
{
    public class Tools
    {
        // A utility class containing methods and enums related to player profiles and input devices
        public enum InputDevices
        {
            Keyboard, Controller, Touch
        }
        // Enum to define different camera perspectives in the game
        public enum CameraPerspective
        {
            FirstPerson, ThirdPersonFront, ThirdPersonBack
        }
        public const string DefaultConstantPath = "profile.txt ";
        // <summary>
        /// Saves a list of player profiles to a file.
        /// <param name="profiles">The list of profiles to be saved.</param>
        /// <param name="filePath">The file path where profiles will be saved. Defaults to "profile.txt".</param>
        public static void SaveProfilesToFile(List<PlayerProfile> profiles, string filePath = DefaultConstantPath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var profile in profiles)
                    {
                        writer.WriteLine(profile.StringOutput());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while saving profiles.", ex);
            }

        }
        /// <summary>
        /// Loads a list of profiles from a file.
        /// </summary>
        /// <param name="filePath">Optional file path to load the profiles from. Defaults to a standard location.</param>
        /// <returns>A list of profiles loaded from the file.</returns>
        public static List<PlayerProfile> LoadProfilesFromFile(string filePath = DefaultConstantPath)
        {
            var profiles = new List<PlayerProfile>();
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string profileContent = string.Empty;
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(line))
                            {
                                // Manage profile content separation logic
                                if (!string.IsNullOrWhiteSpace(profileContent))
                                {
                                    try
                                    {
                                        var profile = new PlayerProfile();
                                        profile.LoadFromString(profileContent); // Parse profile
                                        profiles.Add(profile); // Add to the list if valid
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Error parsing profile:\n{profileContent}\n{ex.Message}");
                                    }
                                    finally
                                    {
                                        profileContent = string.Empty; // Reset for the next profile
                                    }
                                }
                            }
                            else
                            {
                                profileContent += line + "\n";
                            }
                        }

                        // Handle the last profile if it wasn't followed by an empty line
                        if (!string.IsNullOrWhiteSpace(profileContent))
                        {
                            try
                            {
                                var profile = new PlayerProfile();
                                profile.LoadFromString(profileContent); // Parse profile
                                profiles.Add(profile); // Add to the list if valid
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error parsing last profile:\n{profileContent}\n{ex.Message}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"File not found: {filePath}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while loading profiles.", ex);
            }
            return profiles;
        }
    }
}

