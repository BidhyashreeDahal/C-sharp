/*
 * Title :Race.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to create a user interface for creating and editing characters 
 * in the Assignment_3D_D project. It allows users to customize character details,
 * allocate points to attributes, and supports both new character creation and editing existing
 */

using Assignment_3D_D.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3D_D
{
    public partial class frmEditor : Form
    {
        private Character character;

        private bool isNewCharacter;
        /// <summary>
        /// Constructor to initialize the editor form.
        /// </summary>
        /// <param name="characterName">Name of the character being edited, or null if creating a new character.</param>
        public frmEditor(string characterName)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(characterName))
            {
                // Creating a new character
                character = new Character();
                isNewCharacter = true; // Set flag to true for new character
            }
            else
            {
                // Editing an existing character
                character = Character.FindCharacter(characterName);
                isNewCharacter = false; // Set flag to false for existing character
            }
        }

        #region Populate Form
        /// <summary>
        /// Loads and populates form elements when the form opens.
        /// </summary>
        private void frmEditor_Load(object sender, EventArgs e)
        {
            PopulateAlignment();
            PopulateRace();
            PopulateClass();
            PopulateGender();
           
            if (isNewCharacter)
            {
                ClearScreen(); // Clear screen if creating a new character
            }
            else
            {
               PopulateCharacter();
            }
        }
        /// <summary>
        /// Populates the alignment dropdown with available alignments.
        /// </summary>
        private void PopulateAlignment()
        {
            foreach (var alignment in Enum.GetValues(typeof(Classes.Constants.Alignments)))
            {
                cboAlignment.Items.Add(alignment);
            }
        }

        /// <summary>
        /// Populates the race dropdown with available races.
        /// </summary>
        private void PopulateRace()
        {
            cboRace.Items.Clear();
            foreach (var race in Race.RaceDetail)
            {
                cboRace.Items.Add(race.Name);
            }
        }
        /// <summary>
        /// Populates the gender dropdown with available genders.
        /// </summary>
        private void PopulateGender()
        {
            cboGender.Items.Clear();
            foreach (var gender in Enum.GetValues(typeof(Classes.Constants.Gender)))
            {
                cboGender.Items.Add(gender);
            }
        }
        /// <summary>
        /// Populates the class dropdown with available classes.
        /// </summary>

        private void PopulateClass()
        {
            cboClass.Items.Clear();
            foreach (var classOfCharacter in Classes.Classes.classList)
            {
                cboClass.Items.Add(classOfCharacter.Name);
            }
        }
        /// <summary>
        /// Populates character form fields based on character data.
        /// </summary>
        public void PopulateCharacter()
        {
            txtCharacterName.Text = character.Name;
            cboAlignment.SelectedItem = character.Alignments;
            cboClass.SelectedItem =character.CharacterClass.Name;
            cboRace.SelectedItem = character.CharacterRace.Name;
            cboGender.SelectedItem = character.Gender;
            
        }
        // <summary>
        /// Populates the bonus labels for character attributes.
        /// </summary>
        public void PopulateBonuses()
        {
           
            lblStrengthBonus.Text = character.Strength.ToString();
            lblWisdomBonus.Text = character.Wisdom.ToString();
            lblConstitutionBonus.Text = character.Constitution.ToString();
            lblIntelligenceBonus.Text = character.Intelligence.ToString();
            lblDexterityBonus.Text = character.Dexterity.ToString();
            lblCharismaBonus.Text = character.Charisma.ToString();
            lblRemainingPointValue.Text = character.CalculateRemainingPoints().ToString();
        }
        #endregion

        #region Combo Box Index Change
        /// <summary>
        /// Handles selection change in the race dropdown, updating character and UI.
        /// </summary>
        private void cboRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboRace.SelectedItem==null)return;
            String selectedRaceName = cboRace.SelectedItem.ToString();// Safely getting the name  
            
            if (!string.IsNullOrEmpty(selectedRaceName))
            {
                Race selectedRace = Race.FindRace(selectedRaceName);
                if (selectedRace != null)
                {
                    character.CharacterRace = selectedRace;
                    cboRace.SelectedItem = selectedRace;
                    character.InitializeBaseStats();
                   
                    character.ApplyDefaultRaceBonuses();
                    character.ApplyDefaultClassBonuses();
                    character.ApplyDefaultGenderBonuses();
                    PopulateBonuses();
                }

            }

        }
        /// <summary>
        /// Handles selection change in the class dropdown, updating character and UI.
        /// </summary>
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedItem == null) return;
            String selectedClassName = cboClass.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedClassName))
            {
                Classes.Classes selectedClass = Classes.Classes.FindClass(selectedClassName);
                if (selectedClass != null)
                {
                    character.InitializeBaseStats();
                    character.CharacterClass = selectedClass;
                    cboClass.SelectedItem = selectedClass;
                    character.ApplyDefaultClassBonuses();
                    character.ApplyDefaultRaceBonuses();
                    character.ApplyDefaultGenderBonuses();
                    PopulateBonuses();
                }

            }

        }
        /// <summary>
        /// Handles selection change in the gender dropdown, updating character and UI.
        /// </summary>
        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGender.SelectedItem == null) return;
            character.InitializeBaseStats();
            character.Gender = (Classes.Constants.Gender)Enum.Parse(typeof(Classes.Constants.Gender), cboGender.SelectedItem.ToString());
            character.ApplyDefaultGenderBonuses();
            character.ApplyDefaultClassBonuses();
            character.ApplyDefaultRaceBonuses();
            PopulateBonuses();

        }

        #endregion
        #region Create and Edit Character
        /// <summary>
        /// Creates a new character with form data and adds to character list.
        /// </summary>
        private void CreateCharacter()
        {
            Character tempCharacter = new Character();
            tempCharacter.Name =this.txtCharacterName.Text;
            tempCharacter.Alignments = (Constants.Alignments)this.cboAlignment.SelectedIndex;
            tempCharacter.CharacterClass = Classes.Classes.FindClass(this.cboClass.SelectedItem.ToString());
            tempCharacter.CharacterRace = Race.FindRace(this.cboRace.SelectedItem.ToString());
            tempCharacter.Gender = (Constants.Gender)this.cboGender.SelectedIndex;
            tempCharacter.Strength = (Constants.Attributes)int.Parse(lblStrengthBonus.Text);
            tempCharacter.Constitution =(Constants.Attributes)int.Parse(lblConstitutionBonus.Text);
            tempCharacter.Charisma = (Constants.Attributes)int.Parse(lblCharismaBonus.Text);
            tempCharacter.Dexterity = (Constants.Attributes)int.Parse(lblDexterityBonus.Text);
            tempCharacter.Intelligence = (Constants.Attributes)int.Parse(lblIntelligenceBonus.Text);
            tempCharacter.Wisdom =(Constants.Attributes)int.Parse(lblWisdomBonus.Text);
            tempCharacter.remainingPoints = int.Parse(lblRemainingPointValue.Text);
            Character.Characters.Add(tempCharacter);
        }
        /// <summary>
        /// Edits an existing character based on form data.
        /// </summary>
        public void EditCharacter()
        {
            
            // Set character properties based on form inputs
            character.Name = txtCharacterName.Text.Trim();
            character.Alignments = (Constants.Alignments)cboAlignment.SelectedItem;
            character.CharacterClass = Classes.Classes.FindClass(cboClass.SelectedItem.ToString());
            character.CharacterRace = Race.FindRace(cboRace.SelectedItem.ToString());
            character.Gender = (Constants.Gender)cboGender.SelectedItem;

            
            character.Strength = (Constants.Attributes)int.Parse(lblStrengthBonus.Text);
            
            character.Dexterity = (Constants.Attributes)int.Parse(lblDexterityBonus.Text);
            character.Constitution = (Constants.Attributes)int.Parse(lblConstitutionBonus.Text);
            character.Intelligence = (Constants.Attributes)int.Parse(lblIntelligenceBonus.Text);
            character.Wisdom = (Constants.Attributes)int.Parse(lblWisdomBonus.Text);
            character.Charisma = (Constants.Attributes)int.Parse(lblCharismaBonus.Text);
            character.remainingPoints = int.Parse(lblRemainingPointValue.Text);


            
        }
        #endregion


        #region Click Events
        /// <summary>
        /// Allocates points to attributes based on user input.
        /// </summary>
        private void btnAllocatePoint_Click(object sender, EventArgs e)
        {
            
            lblCostStrengthValue.Text = character.AllocatePoints(Constants.Attributes.Strength, (int)nudStrength.Value).ToString();
            lblCostWisdomValue.Text = character.AllocatePoints(Constants.Attributes.Wisdom, (int)nudWisdom.Value).ToString();
            lblCostIntelligenceValue.Text = character.AllocatePoints(Constants.Attributes.Intelligence, (int)nudIntelligence.Value).ToString();
            lblCostDexterityValue.Text = character.AllocatePoints(Constants.Attributes.Dexterity, (int)nudDexterity.Value).ToString();
            lblCostCharismaValue.Text = character.AllocatePoints(Constants.Attributes.Charisma, (int)nudCharisma.Value).ToString();
            lblCostConstitutionValue.Text = character.AllocatePoints(Constants.Attributes.Charisma, (int)nudCharisma.Value).ToString();
            lblRemainingPointValue.Text = character.CalculateRemainingPoints().ToString();
        }
        /// <summary>
        /// Click Event for Reset Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }
        /// <summary>
        /// Click Event for exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Conformation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }
        /// <summary>
        /// Click event for save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNewCharacter)
            {
                CreateCharacter();
                

            }
            else
            {
                EditCharacter();
                int index = Character.Characters.FindIndex(c => c.Name == character.Name);
                if (index >= 0)
                {
                    Character.Characters[index] = character; // Update existing character
                }
            }
           
            this.DialogResult = DialogResult.OK;
            this.Close();
            #endregion
        }
        #region Screen Clear

        /// <summary>
        /// Clearing everything on the screen
        /// </summary>
        public void ClearScreen()
        {
            txtCharacterName.Clear();
            cboAlignment.SelectedIndex = -1; // Clear selection  
            cboClass.SelectedIndex = -1; // Clear selection  
            cboRace.SelectedIndex = -1; // Clear selection  
            cboGender.SelectedIndex = -1; // Clear selection  
            nudStrength.Value = 0; // Reset numeric updowns  
            nudDexterity.Value = 0;
            nudConstitution.Value = 0;
            nudIntelligence.Value = 0;
            nudWisdom.Value = 0;
            nudCharisma.Value = 0;
            lblRemainingPointValue.Text = "0";

            // Clearing the label Bonus
            lblStrengthBonus.Text = "0";
            lblCharismaBonus.Text = "0";
            lblConstitutionBonus.Text = "0";
            lblIntelligenceBonus.Text = "0";
            lblWisdomBonus.Text = "0";
            lblDexterityBonus.Text = "0";

            // Clearing the remaining Value
            lblRemainingPointValue.Text = "0";

            // Clearing the costs 
            lblCostStrengthValue.Text = "0";
            lblCostIntelligenceValue.Text = "0";
            lblCostWisdomValue.Text = "0";
            lblCostDexterityValue.Text = "0";
            lblCostConstitutionValue.Text = "0";
            lblCostCharismaValue.Text = "0";
        }
    }
    #endregion
}
