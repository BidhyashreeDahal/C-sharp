/*
 * PlayerProfiles.cs
 * 100952513
 * The `PlayerProfile` class manages game settings like movement, video, and audio preferences. 
 * It supports creating, loading, and updating profiles, as well as predefined profiles for quick setup.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Assignment_4_Minecraft
{
    /// <summary>
    /// Represents a profiles containing Minecraft settings
    /// </summary>
    public class PlayerProfile
    {
        # region Properties
        // Unique identifier for each profile
        public string ProfileName { get; set; }
        // Movement Settings 
        public string InputDevice { get; set; } = Tools.InputDevices.Keyboard.ToString();
        public bool AutoJump { get; set; } = true;
        public decimal MouseSensitivity { get; set; } = 50;
        public decimal ControllerSensitivity { get; set; } = 50;
        public bool InvertYAxis { get; set; } = false;

        // Video Settings
        public int Brightness { get; set; } = 50;
        public bool FancyGraphics { get; set; } = true;
        public bool VSync { get; set; } = true;
        public bool Fullscreen { get; set; } = false;
        public int RenderDistance { get; set; } = 16;
        public int FieldOfView { get; set; } = 64;
        public bool RayTracing { get; set; } = false;
        public bool UpScaling { get; set; } = false;

        // Audio Settings
        public int Music { get; set; } = 100;
        public int Sound { get; set; } = 100;

        // Interface Settings 
        public int HUDDTransparency { get; set; } = 100;
        public bool ShowCoordinates { get; set; } = false;
        public string CameraPerspective { get; set; } = Tools.CameraPerspective.FirstPerson.ToString();
        /// <summary>
        /// Constructor with parameter to initialize a profile with custom settings.
        /// </summary>
        public PlayerProfile(string profileName, string inputDevice, bool autoJump, decimal mouseSensitivity, decimal controllerSensitivity, bool invertYAxis, int brightness, bool fancyGraphics, bool vSync, bool fullscreen, int renderDistance, int fieldOfView, bool rayTracing, bool upScaling, int music, int sound, int hUDDTransparency, bool showCoordinates, string cameraPerspective)
        {
            this.ProfileName = profileName;
            this.InputDevice = inputDevice;
            this.AutoJump = autoJump;
            this.MouseSensitivity = mouseSensitivity;
            this.ControllerSensitivity = controllerSensitivity;
            this.InvertYAxis = invertYAxis;
            this.Brightness = brightness;
            this.FancyGraphics = fancyGraphics;
            this.VSync = vSync;
            this.Fullscreen = Fullscreen;
            this.RenderDistance = renderDistance;
            this.FieldOfView = fieldOfView;
            this.RayTracing = rayTracing;
            this.UpScaling = upScaling;
            this.Music = music;
            this.Sound = sound;
            this.HUDDTransparency = hUDDTransparency;
            this.ShowCoordinates = showCoordinates;
            this.CameraPerspective = cameraPerspective;
        }
        /// <summary>
        /// Constructor to initialize a profile with custom settings.
        /// </summary>
        public PlayerProfile()
        {

        }


        public static List<PlayerProfile> Profiles = new List<PlayerProfile>();
        /// <summary>
        /// Sets default profiles with common Minecraft player settings.
        /// </summary>
        public void DefaultProfile()
        {
            PlayerProfile profile = new PlayerProfile
               (
               ProfileName = "Casual Player", InputDevice = Tools.InputDevices.Keyboard.ToString(), AutoJump = true, MouseSensitivity = 50,
               ControllerSensitivity = 50, InvertYAxis = false, Brightness = 50, FancyGraphics = true, VSync = true, Fullscreen = false,
               RenderDistance = 16, FieldOfView = 64, RayTracing = false, UpScaling = false, Music = 100, Sound = 100,
               HUDDTransparency = 100, ShowCoordinates = false, CameraPerspective = Tools.CameraPerspective.FirstPerson.ToString()
               );
            Profiles.Add(profile);

            profile = new PlayerProfile(
                ProfileName = "ProPlayer", InputDevice = Tools.InputDevices.Touch.ToString(), AutoJump = true, MouseSensitivity = 60,
                ControllerSensitivity = 55, InvertYAxis = true, Brightness = 40, FancyGraphics = true, VSync = false,
                Fullscreen = true, RenderDistance = 120, FieldOfView = 74, RayTracing = false, UpScaling = true,
                Music = 90, Sound = 90, HUDDTransparency = 70, ShowCoordinates = false,
                CameraPerspective = Tools.CameraPerspective.ThirdPersonBack.ToString()
                );
            Profiles.Add(profile);

            Profiles.Add(new PlayerProfile
                (
                ProfileName = "Builder", InputDevice = Tools.InputDevices.Controller.ToString(),
                AutoJump = false, MouseSensitivity = 55, ControllerSensitivity = 45,
                InvertYAxis = true, Brightness = 70, FancyGraphics = true, VSync = true,
                Fullscreen = false, RenderDistance = 10, FieldOfView = 85, RayTracing = true,
                UpScaling = true, Music = 30, Sound = 50, HUDDTransparency = 80,
                ShowCoordinates = true, CameraPerspective = Tools.CameraPerspective.ThirdPersonBack.ToString()
                )
             );
            Profiles.Add(new PlayerProfile
            (ProfileName = "Explorer",
            InputDevice = Tools.InputDevices.Touch.ToString(), AutoJump = true, MouseSensitivity = 55, ControllerSensitivity = 65, InvertYAxis = false,
            Brightness = 90, FancyGraphics = true,
            VSync = true, Fullscreen = true, RenderDistance = 14, FieldOfView = 80,
            RayTracing = false, UpScaling = false, Music = 80, Sound = 90, HUDDTransparency = 60, ShowCoordinates = true,
            CameraPerspective = Tools.CameraPerspective.FirstPerson.ToString()
            )
            );
            Profiles.Add(new PlayerProfile
                (ProfileName = "Visionary", InputDevice = Tools.InputDevices.Controller.ToString(), AutoJump = false,
                MouseSensitivity = 70, ControllerSensitivity = 30, InvertYAxis = true, Brightness = 60,
                FancyGraphics = true, VSync = true, Fullscreen = false, RenderDistance = 20,
                FieldOfView = 70, RayTracing = true, UpScaling = true, Music = 40, Sound = 70, HUDDTransparency = 30,
                ShowCoordinates = true, CameraPerspective = Tools.CameraPerspective.FirstPerson.ToString()
                )
            );
            Profiles.Add(new PlayerProfile(

                ProfileName = "Stealth Master", InputDevice = Tools.InputDevices.Keyboard.ToString(), AutoJump = false,
                MouseSensitivity = 55, ControllerSensitivity = 50, InvertYAxis = true, Brightness = 40, FancyGraphics = false,
                VSync = false, Fullscreen = true, RenderDistance = 8, FieldOfView = 75, RayTracing = false, UpScaling = false, Music = 20,
                Sound = 50, HUDDTransparency = 90, ShowCoordinates = false, CameraPerspective = Tools.CameraPerspective.ThirdPersonFront.ToString()
            ));
            Profiles.Add(new PlayerProfile(
                ProfileName = "Creative Spirit", InputDevice = Tools.InputDevices.Controller.ToString(), AutoJump = true,
                MouseSensitivity = 30, ControllerSensitivity = 60, InvertYAxis = false, Brightness = 100, FancyGraphics = true, VSync = true,
                Fullscreen = false, RenderDistance = 15, FieldOfView = 90, RayTracing = false, UpScaling = true, Music = 100, Sound = 80,
                HUDDTransparency = 40, ShowCoordinates = true, CameraPerspective = Tools.CameraPerspective.ThirdPersonBack.ToString()
            ));
        }
        #endregion
        #region Methods
        /// <summary>
        /// Generates a formatted string representation of the profile settings.
        /// </summary>
        /// <returns> String containing all settings for a profile</returns>

        public string StringOutput()
        {
            return $"ProfileName = {ProfileName}\n" +
                   $"InputDevice = {InputDevice}\n" +
                   $"AutoJump ={AutoJump}\n" +
                   $"MouseSensitivity = {MouseSensitivity}\n" +
                   $"ControllerSensitivity ={ControllerSensitivity}\n" +
                   $"InvertYAxis = {InvertYAxis}\n" +
                   $"Brightness = {Brightness}\n" +
                   $"FancyGraphics = {FancyGraphics}\n" +
                   $"VSync = {VSync}\n" +
                   $"Fullscreen = {Fullscreen}\n" +
                   $"RenderDistance = {RenderDistance}\n" +
                   $"FieldOfView = {FieldOfView}\n" +
                   $"RayTracing = {RayTracing}\n" +
                   $"Upscaling = {UpScaling}\n" +
                   $"MusicVolume = {Music}\n" +
                   $"SoundVolume = {Sound}\n" +
                   $"HudTransparency = {HUDDTransparency}\n" +
                   $"ShowCoordinates = {ShowCoordinates}\n" +
                   $"CameraPerspective = {CameraPerspective}";

        }
        /// <summary>
        /// Loads settings from a string formatted as a file content.
        /// </summary>
        /// <param name="fileContent"> The string content to parse settings from. </param>
        public void LoadFromString(string fileContent)
        {
            var lines = fileContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var parts = line.Split('=');
                if (parts.Length != 2) continue; // Skip invalid lines

                var key = parts[0].Trim();
                var value = parts[1].Trim();

                // Log the key and value for debugging purposes
                Console.WriteLine($"Key: {key}, Value: {value}");

                switch (key)
                {
                    case "ProfileName":
                        ProfileName = value;
                        break;
                    case "InputDevice":
                        InputDevice = value;
                        break;
                    case "AutoJump":
                        AutoJump = value.Equals("true", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "MouseSensitivity":
                        if (IsInteger(value)) MouseSensitivity = int.Parse(value);
                        break;
                    case "ControllerSensitivity":
                        if (IsInteger(value)) ControllerSensitivity = int.Parse(value);
                        break;
                    case "InvertYAxis":
                        InvertYAxis = value.Equals("true", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "Brightness":
                        if (IsInteger(value)) Brightness = int.Parse(value);
                        break;
                    case "FancyGraphics":
                        FancyGraphics = value.Equals("true", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "VSync":
                        VSync = value.Equals("true", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "FullScreen":
                        Fullscreen = value.Equals("true", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "RenderDistance":
                        if (IsInteger(value)) RenderDistance = int.Parse(value);
                        break;
                    case "FieldOfView":
                        if (IsInteger(value)) FieldOfView = int.Parse(value);
                        break;
                    case "RayTracing":
                        RayTracing = value.Equals("true", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "UpScaling":
                        UpScaling = value.Equals("true", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "Music":
                        if (IsInteger(value)) Music = int.Parse(value);
                        break;
                    case "Sound":
                        if (IsInteger(value)) Sound = int.Parse(value);
                        break;
                    case "HUDDTransparency":
                        if (IsInteger(value)) HUDDTransparency = int.Parse(value);
                        break;
                    case "ShowCoordinates":
                        ShowCoordinates = value.Equals("true", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "CameraPerspective":
                        CameraPerspective = value;
                        break;
                }
            }
        }

        /// <summary>
        /// Helper method to check if a string can be parsed as an integer
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsInteger(string value)
        {
            return int.TryParse(value, out _);
        }
        

        #endregion
        /// <summary>
        /// Method to find the name of the profile using
        /// </summary>
        /// <param name="profileName"></param>
        /// <returns></returns>
        public static PlayerProfile FindProfile(String profileName)
        {
            foreach (PlayerProfile profile in Profiles)
            {
                if (profile.ProfileName == profileName) return profile;
            }
            return null;
        }
    }
}
