/* Title :Race.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to contain the tool used in the programs 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3D_D.Classes
{
    /// <summary>
    /// Provides utility methods for playing sound effects in the program.
    /// </summary>
    public class Tools
    {
       
        private static SoundPlayer _player = new SoundPlayer(Properties.Resources.Sound);
        private static bool _isPlaying = false;
        // <summary>
        /// Plays the sound in a looping manner if it is not already playing.
        /// </summary>
        public static void Play()
            {
                if (!_isPlaying)
                {
                    _player.PlayLooping(); // Start looping the sound  
                    _isPlaying = true;
                }
            }
        }
    
}
    
    

