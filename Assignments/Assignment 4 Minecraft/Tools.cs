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
        public enum InputDevices
        {
            Keyboard, Controller, Touch
        }
        public enum CameraPerspective
        {
            FirstPerson,
            ThirdPersonFront,
            ThirdPersonBack
        }
        public const string DefaultConstantPath = "profile.txt ";

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
            catch (Exception ex) {
                // Handle exceptions (e.g., file access issues) and propagate them if needed.
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
                                // Empty line indicates the end of one profile's data
                                if (!string.IsNullOrWhiteSpace(profileContent))
                                {
                                    var profile = new PlayerProfile();
                                    profile.LoadFromString(profileContent);
                                    profiles.Add(profile);
                                    profileContent = string.Empty; // Reset for the next profile
                                }
                            }
                            else
                            {
                                profileContent += line + "\n";
                            }
                        }

                        // Handle the last profile if there's no trailing empty line
                        if (!string.IsNullOrWhiteSpace(profileContent))
                        {
                            var profile = new PlayerProfile();
                            profile.LoadFromString(profileContent);
                            profiles.Add(profile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file read issues) and propagate them if needed.
                throw new Exception("An error occurred while loading profiles.", ex);
            }

            return profiles;
        }
}

}
