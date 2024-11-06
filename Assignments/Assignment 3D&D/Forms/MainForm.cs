/*
 * Title :Race.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to create a user interface showcasing the available characters. And It allows the users
 * to create or edit the characters.
 */
using Assignment_3D_D.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3D_D
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// This constructor sets up the form components by calling the InitializeComponent method.
        /// </summary>
        private Character character;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler that initializes the form, plays background music, populates sample characters,
        /// and fills the list box with character names when the form loads.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Classes.Tools.Play();
            Character.PopulateSampleCharacters();
            PopulateListBox();
        }
        /// <summary>
        /// Populates the list box with the names of available characters from the character collection.
        /// Clears the existing items in the list box before adding new ones.
        /// </summary>

        public void PopulateListBox() 
        {
            Characters.Items.Clear();
            foreach(Character character in Character.Characters)
            {
                Characters.Items.Add(character.Name);
            }
        }
        #region Click Events
        // <summary>
        /// Event handler for creating a new character. Opens the editor form to create a new character 
        /// and refreshes the list box if the character is successfully created.
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {

            frmEditor frm = new frmEditor(null); // Open form for a new character  
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PopulateListBox(); 
            }
        }
        /// <summary>
        /// Event handler for editing an existing character. Opens the editor form for the selected character 
        /// and refreshes the list box if changes are saved.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Characters.SelectedIndex > -1)
            {
                string selectedCharacterName = Characters.SelectedItem.ToString();
                frmEditor frm = new frmEditor(selectedCharacterName);
                if (frm.ShowDialog() == DialogResult.OK) // Check if changes were saved
                {
                    PopulateListBox(); 
                }
            }


        }
        /// <summary>
        /// Event handler that updates the story text box based on the selected character in the list box.
        /// Displays the corresponding character's backstory when selected.
        /// </summary>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Characters.SelectedIndex != -1)
            {
                if (Characters.SelectedIndex == 0)
                {
                    txtStory.Text = $"{Characters.SelectedItem.ToString()} belongs to Barabians class. Barbarians are mighty warriors who are powered by primal forces of the multiverse that manifest as a Rage. " +
                        "More than a mere emotion—and not limited to anger—this Rage is an incarnation of a predator’s ferocity, a storm’s fury, and a sea’s turmoil.";
                }
                if (Characters.SelectedIndex == 1)
                {
                    txtStory.Text = $"{Characters.SelectedItem.ToString()} belongs to Bards class. Bards are invoking magic through music, dance, and verse, Bards are expert at inspiring others, soothing hurts, disheartening foes, and creating illusions. " +
                        "Bards believe the multiverse was spoken into existence and that remnants of its Words of Creation still resound and glimmer on every plane of existence." +
                        " Bardic magic attempts to harness those words, which transcend any language.";
                }
                if(Characters.SelectedIndex == 2)
                {
                    txtStory.Text = $"{Characters.SelectedItem.ToString()} belongs to Clerics class. Clerics draw power from the realms of the gods and harness it to work miracles." +
                        " Blessed by a deity, a pantheon, or another immortal entity," +
                        " a Cleric can reach out to the divine magic of the Outer Planes—where gods dwell—and channel it to bolster people and battle foes.";
                }
                if (Characters.SelectedIndex == 3) 
                {
                    txtStory.Text = $"{Characters.SelectedItem.ToString()} belongs to druids class. Druids belong to ancient orders that call on the forces of nature." +
                        " Harnessing the magic of animals, plants, and the four elements, Druids heal," +
                        " transform into animals, and wield elemental destruction.";
                }
                if(Characters.SelectedIndex == 4) 
                {
                    txtStory.Text = $"{Characters.SelectedItem.ToString()} belongs to fighter class. Fighters rule many battlefields. Questing knights, royal champions, elite soldiers, and hardened mercenaries—as Fighters," +
                        " they all share an unparalleled prowess with weapons and armor. And they are well acquainted with death, both meting it out and defying it.";
                }
                if(Characters.SelectedIndex == 5)
                {
                    txtStory.Text = $"{Characters.SelectedItem.ToString()} belongs to wizard class. Wizards are defined by their exhaustive study of magic’s inner workings." +
                        " They cast spells of explosive fire, arcing lightning, subtle deception, and spectacular transformations. " +
                        "Their magic conjures monsters from other planes of existence, glimpses the future, or forms protective barriers. " +
                        "Their mightiest spells change one substance into another, call meteors from the sky, or open portals to other worlds.";
                }
            }
        }

        /// <summary>
        /// Event handler for the exit button. Confirms with the user before closing the application.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}
