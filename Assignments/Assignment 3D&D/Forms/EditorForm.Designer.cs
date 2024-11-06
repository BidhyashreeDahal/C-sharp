namespace Assignment_3D_D
{
    partial class frmEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlignment = new System.Windows.Forms.Label();
            this.cboAlignment = new System.Windows.Forms.ComboBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCostDexterityValue = new System.Windows.Forms.Label();
            this.lblCostConstitutionValue = new System.Windows.Forms.Label();
            this.lblCostIntelligenceValue = new System.Windows.Forms.Label();
            this.lblCostWisdomValue = new System.Windows.Forms.Label();
            this.lblCostCharismaValue = new System.Windows.Forms.Label();
            this.lblCostStrength = new System.Windows.Forms.Label();
            this.lblCostDexteritry = new System.Windows.Forms.Label();
            this.lblCostConstitution = new System.Windows.Forms.Label();
            this.lblCostIntelligence = new System.Windows.Forms.Label();
            this.lblCostWisdom = new System.Windows.Forms.Label();
            this.lblCostCharisma = new System.Windows.Forms.Label();
            this.lblCostStrengthValue = new System.Windows.Forms.Label();
            this.lblWisdomBonus = new System.Windows.Forms.Label();
            this.lblCharismaBonus = new System.Windows.Forms.Label();
            this.lblIntelligenceBonus = new System.Windows.Forms.Label();
            this.lblConstitutionBonus = new System.Windows.Forms.Label();
            this.lblDexterityBonus = new System.Windows.Forms.Label();
            this.lblStrengthBonus = new System.Windows.Forms.Label();
            this.lblRemainingPointValue = new System.Windows.Forms.Label();
            this.lblRemainingPoints = new System.Windows.Forms.Label();
            this.nudDexterity = new System.Windows.Forms.NumericUpDown();
            this.nudConstitution = new System.Windows.Forms.NumericUpDown();
            this.nudIntelligence = new System.Windows.Forms.NumericUpDown();
            this.nudCharisma = new System.Windows.Forms.NumericUpDown();
            this.nudWisdom = new System.Windows.Forms.NumericUpDown();
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpCreateOrEdit = new System.Windows.Forms.GroupBox();
            this.btnAllocatePoint = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudAC = new System.Windows.Forms.NumericUpDown();
            this.nudInitiative = new System.Windows.Forms.NumericUpDown();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudHitPoints = new System.Windows.Forms.NumericUpDown();
            this.nudEP = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            this.grpCreateOrEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHitPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterName.Location = new System.Drawing.Point(172, 50);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(227, 34);
            this.txtCharacterName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCharacterName, "Enter the character Name");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gender";
            // 
            // lblAlignment
            // 
            this.lblAlignment.AutoSize = true;
            this.lblAlignment.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlignment.Location = new System.Drawing.Point(18, 95);
            this.lblAlignment.Name = "lblAlignment";
            this.lblAlignment.Size = new System.Drawing.Size(121, 31);
            this.lblAlignment.TabIndex = 9;
            this.lblAlignment.Text = "Alignment :";
            // 
            // cboAlignment
            // 
            this.cboAlignment.FormattingEnabled = true;
            this.cboAlignment.Location = new System.Drawing.Point(172, 111);
            this.cboAlignment.Name = "cboAlignment";
            this.cboAlignment.Size = new System.Drawing.Size(227, 33);
            this.cboAlignment.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cboAlignment, "Choose the Alignment for the character");
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(172, 203);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(227, 33);
            this.cboClass.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboClass, "Choose the Class");
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // cboRace
            // 
            this.cboRace.FormattingEnabled = true;
            this.cboRace.Location = new System.Drawing.Point(172, 154);
            this.cboRace.Name = "cboRace";
            this.cboRace.Size = new System.Drawing.Size(227, 33);
            this.cboRace.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboRace, "Choose the race for the character");
            this.cboRace.SelectedIndexChanged += new System.EventHandler(this.cboRace_SelectedIndexChanged);
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(18, 153);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(73, 31);
            this.lblRace.TabIndex = 4;
            this.lblRace.Text = "Race :";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(15, 206);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(81, 31);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class :";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.Location = new System.Drawing.Point(30, 53);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(79, 31);
            this.lblCharacter.TabIndex = 0;
            this.lblCharacter.Text = "Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblCostDexterityValue);
            this.panel2.Controls.Add(this.lblCostConstitutionValue);
            this.panel2.Controls.Add(this.lblCostIntelligenceValue);
            this.panel2.Controls.Add(this.lblCostWisdomValue);
            this.panel2.Controls.Add(this.lblCostCharismaValue);
            this.panel2.Controls.Add(this.lblCostStrength);
            this.panel2.Controls.Add(this.lblCostDexteritry);
            this.panel2.Controls.Add(this.lblCostConstitution);
            this.panel2.Controls.Add(this.lblCostIntelligence);
            this.panel2.Controls.Add(this.lblCostWisdom);
            this.panel2.Controls.Add(this.lblCostCharisma);
            this.panel2.Controls.Add(this.lblCostStrengthValue);
            this.panel2.Controls.Add(this.lblWisdomBonus);
            this.panel2.Controls.Add(this.lblCharismaBonus);
            this.panel2.Controls.Add(this.lblIntelligenceBonus);
            this.panel2.Controls.Add(this.lblConstitutionBonus);
            this.panel2.Controls.Add(this.lblDexterityBonus);
            this.panel2.Controls.Add(this.lblStrengthBonus);
            this.panel2.Controls.Add(this.lblRemainingPointValue);
            this.panel2.Controls.Add(this.lblRemainingPoints);
            this.panel2.Controls.Add(this.nudDexterity);
            this.panel2.Controls.Add(this.nudConstitution);
            this.panel2.Controls.Add(this.nudIntelligence);
            this.panel2.Controls.Add(this.nudCharisma);
            this.panel2.Controls.Add(this.nudWisdom);
            this.panel2.Controls.Add(this.nudStrength);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblStrength);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(686, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 403);
            this.panel2.TabIndex = 13;
            // 
            // lblCostDexterityValue
            // 
            this.lblCostDexterityValue.AutoSize = true;
            this.lblCostDexterityValue.Location = new System.Drawing.Point(452, 111);
            this.lblCostDexterityValue.Name = "lblCostDexterityValue";
            this.lblCostDexterityValue.Size = new System.Drawing.Size(0, 25);
            this.lblCostDexterityValue.TabIndex = 42;
            // 
            // lblCostConstitutionValue
            // 
            this.lblCostConstitutionValue.AutoSize = true;
            this.lblCostConstitutionValue.Location = new System.Drawing.Point(452, 152);
            this.lblCostConstitutionValue.Name = "lblCostConstitutionValue";
            this.lblCostConstitutionValue.Size = new System.Drawing.Size(0, 25);
            this.lblCostConstitutionValue.TabIndex = 41;
            // 
            // lblCostIntelligenceValue
            // 
            this.lblCostIntelligenceValue.AutoSize = true;
            this.lblCostIntelligenceValue.Location = new System.Drawing.Point(452, 197);
            this.lblCostIntelligenceValue.Name = "lblCostIntelligenceValue";
            this.lblCostIntelligenceValue.Size = new System.Drawing.Size(0, 25);
            this.lblCostIntelligenceValue.TabIndex = 40;
            // 
            // lblCostWisdomValue
            // 
            this.lblCostWisdomValue.AutoSize = true;
            this.lblCostWisdomValue.Location = new System.Drawing.Point(452, 245);
            this.lblCostWisdomValue.Name = "lblCostWisdomValue";
            this.lblCostWisdomValue.Size = new System.Drawing.Size(0, 25);
            this.lblCostWisdomValue.TabIndex = 39;
            // 
            // lblCostCharismaValue
            // 
            this.lblCostCharismaValue.AutoSize = true;
            this.lblCostCharismaValue.Location = new System.Drawing.Point(452, 298);
            this.lblCostCharismaValue.Name = "lblCostCharismaValue";
            this.lblCostCharismaValue.Size = new System.Drawing.Size(0, 25);
            this.lblCostCharismaValue.TabIndex = 38;
            // 
            // lblCostStrength
            // 
            this.lblCostStrength.AutoSize = true;
            this.lblCostStrength.Location = new System.Drawing.Point(383, 58);
            this.lblCostStrength.Name = "lblCostStrength";
            this.lblCostStrength.Size = new System.Drawing.Size(63, 25);
            this.lblCostStrength.TabIndex = 37;
            this.lblCostStrength.Text = "Cost :";
            // 
            // lblCostDexteritry
            // 
            this.lblCostDexteritry.AutoSize = true;
            this.lblCostDexteritry.Location = new System.Drawing.Point(383, 112);
            this.lblCostDexteritry.Name = "lblCostDexteritry";
            this.lblCostDexteritry.Size = new System.Drawing.Size(63, 25);
            this.lblCostDexteritry.TabIndex = 36;
            this.lblCostDexteritry.Text = "Cost :";
            // 
            // lblCostConstitution
            // 
            this.lblCostConstitution.AutoSize = true;
            this.lblCostConstitution.Location = new System.Drawing.Point(383, 152);
            this.lblCostConstitution.Name = "lblCostConstitution";
            this.lblCostConstitution.Size = new System.Drawing.Size(63, 25);
            this.lblCostConstitution.TabIndex = 35;
            this.lblCostConstitution.Text = "Cost :";
            // 
            // lblCostIntelligence
            // 
            this.lblCostIntelligence.AutoSize = true;
            this.lblCostIntelligence.Location = new System.Drawing.Point(383, 197);
            this.lblCostIntelligence.Name = "lblCostIntelligence";
            this.lblCostIntelligence.Size = new System.Drawing.Size(63, 25);
            this.lblCostIntelligence.TabIndex = 34;
            this.lblCostIntelligence.Text = "Cost :";
            // 
            // lblCostWisdom
            // 
            this.lblCostWisdom.AutoSize = true;
            this.lblCostWisdom.Location = new System.Drawing.Point(383, 244);
            this.lblCostWisdom.Name = "lblCostWisdom";
            this.lblCostWisdom.Size = new System.Drawing.Size(63, 25);
            this.lblCostWisdom.TabIndex = 33;
            this.lblCostWisdom.Text = "Cost :";
            // 
            // lblCostCharisma
            // 
            this.lblCostCharisma.AutoSize = true;
            this.lblCostCharisma.Location = new System.Drawing.Point(383, 298);
            this.lblCostCharisma.Name = "lblCostCharisma";
            this.lblCostCharisma.Size = new System.Drawing.Size(63, 25);
            this.lblCostCharisma.TabIndex = 32;
            this.lblCostCharisma.Text = "Cost :";
            // 
            // lblCostStrengthValue
            // 
            this.lblCostStrengthValue.AutoSize = true;
            this.lblCostStrengthValue.Location = new System.Drawing.Point(452, 58);
            this.lblCostStrengthValue.Name = "lblCostStrengthValue";
            this.lblCostStrengthValue.Size = new System.Drawing.Size(0, 25);
            this.lblCostStrengthValue.TabIndex = 31;
            // 
            // lblWisdomBonus
            // 
            this.lblWisdomBonus.AutoSize = true;
            this.lblWisdomBonus.Location = new System.Drawing.Point(128, 240);
            this.lblWisdomBonus.Name = "lblWisdomBonus";
            this.lblWisdomBonus.Size = new System.Drawing.Size(0, 25);
            this.lblWisdomBonus.TabIndex = 30;
            // 
            // lblCharismaBonus
            // 
            this.lblCharismaBonus.AutoSize = true;
            this.lblCharismaBonus.Location = new System.Drawing.Point(128, 298);
            this.lblCharismaBonus.Name = "lblCharismaBonus";
            this.lblCharismaBonus.Size = new System.Drawing.Size(0, 25);
            this.lblCharismaBonus.TabIndex = 29;
            // 
            // lblIntelligenceBonus
            // 
            this.lblIntelligenceBonus.AutoSize = true;
            this.lblIntelligenceBonus.Location = new System.Drawing.Point(128, 197);
            this.lblIntelligenceBonus.Name = "lblIntelligenceBonus";
            this.lblIntelligenceBonus.Size = new System.Drawing.Size(0, 25);
            this.lblIntelligenceBonus.TabIndex = 28;
            // 
            // lblConstitutionBonus
            // 
            this.lblConstitutionBonus.AutoSize = true;
            this.lblConstitutionBonus.Location = new System.Drawing.Point(128, 152);
            this.lblConstitutionBonus.Name = "lblConstitutionBonus";
            this.lblConstitutionBonus.Size = new System.Drawing.Size(0, 25);
            this.lblConstitutionBonus.TabIndex = 27;
            // 
            // lblDexterityBonus
            // 
            this.lblDexterityBonus.AutoSize = true;
            this.lblDexterityBonus.Location = new System.Drawing.Point(128, 110);
            this.lblDexterityBonus.Name = "lblDexterityBonus";
            this.lblDexterityBonus.Size = new System.Drawing.Size(0, 25);
            this.lblDexterityBonus.TabIndex = 26;
            // 
            // lblStrengthBonus
            // 
            this.lblStrengthBonus.AutoSize = true;
            this.lblStrengthBonus.Location = new System.Drawing.Point(128, 59);
            this.lblStrengthBonus.Name = "lblStrengthBonus";
            this.lblStrengthBonus.Size = new System.Drawing.Size(0, 25);
            this.lblStrengthBonus.TabIndex = 25;
            // 
            // lblRemainingPointValue
            // 
            this.lblRemainingPointValue.AutoSize = true;
            this.lblRemainingPointValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingPointValue.Location = new System.Drawing.Point(194, 350);
            this.lblRemainingPointValue.Name = "lblRemainingPointValue";
            this.lblRemainingPointValue.Size = new System.Drawing.Size(23, 29);
            this.lblRemainingPointValue.TabIndex = 24;
            this.lblRemainingPointValue.Text = "0";
            // 
            // lblRemainingPoints
            // 
            this.lblRemainingPoints.AutoSize = true;
            this.lblRemainingPoints.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingPoints.Location = new System.Drawing.Point(24, 350);
            this.lblRemainingPoints.Name = "lblRemainingPoints";
            this.lblRemainingPoints.Size = new System.Drawing.Size(160, 29);
            this.lblRemainingPoints.TabIndex = 22;
            this.lblRemainingPoints.Text = "Remaining Points :";
            // 
            // nudDexterity
            // 
            this.nudDexterity.Location = new System.Drawing.Point(243, 99);
            this.nudDexterity.Name = "nudDexterity";
            this.nudDexterity.Size = new System.Drawing.Size(120, 33);
            this.nudDexterity.TabIndex = 7;
            // 
            // nudConstitution
            // 
            this.nudConstitution.Location = new System.Drawing.Point(243, 144);
            this.nudConstitution.Name = "nudConstitution";
            this.nudConstitution.Size = new System.Drawing.Size(120, 33);
            this.nudConstitution.TabIndex = 8;
            // 
            // nudIntelligence
            // 
            this.nudIntelligence.Location = new System.Drawing.Point(243, 189);
            this.nudIntelligence.Name = "nudIntelligence";
            this.nudIntelligence.Size = new System.Drawing.Size(120, 33);
            this.nudIntelligence.TabIndex = 9;
            // 
            // nudCharisma
            // 
            this.nudCharisma.Location = new System.Drawing.Point(243, 290);
            this.nudCharisma.Name = "nudCharisma";
            this.nudCharisma.Size = new System.Drawing.Size(120, 33);
            this.nudCharisma.TabIndex = 11;
            // 
            // nudWisdom
            // 
            this.nudWisdom.Location = new System.Drawing.Point(243, 232);
            this.nudWisdom.Name = "nudWisdom";
            this.nudWisdom.Size = new System.Drawing.Size(120, 33);
            this.nudWisdom.TabIndex = 10;
            // 
            // nudStrength
            // 
            this.nudStrength.Location = new System.Drawing.Point(243, 60);
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(120, 33);
            this.nudStrength.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Charisma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Intelligence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wisdom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dexterity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Constitution";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(24, 58);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(82, 29);
            this.lblStrength.TabIndex = 7;
            this.lblStrength.Text = "Strength";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 34);
            this.label8.TabIndex = 6;
            this.label8.Text = "Attributes and Bonuses ";
            // 
            // grpCreateOrEdit
            // 
            this.grpCreateOrEdit.BackColor = System.Drawing.Color.Transparent;
            this.grpCreateOrEdit.Controls.Add(this.btnAllocatePoint);
            this.grpCreateOrEdit.Controls.Add(this.cboGender);
            this.grpCreateOrEdit.Controls.Add(this.panel1);
            this.grpCreateOrEdit.Controls.Add(this.txtCharacterName);
            this.grpCreateOrEdit.Controls.Add(this.cboAlignment);
            this.grpCreateOrEdit.Controls.Add(this.lblClass);
            this.grpCreateOrEdit.Controls.Add(this.panel2);
            this.grpCreateOrEdit.Controls.Add(this.lblRace);
            this.grpCreateOrEdit.Controls.Add(this.cboRace);
            this.grpCreateOrEdit.Controls.Add(this.label1);
            this.grpCreateOrEdit.Controls.Add(this.lblCharacter);
            this.grpCreateOrEdit.Controls.Add(this.lblAlignment);
            this.grpCreateOrEdit.Controls.Add(this.cboClass);
            this.grpCreateOrEdit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreateOrEdit.Location = new System.Drawing.Point(12, 12);
            this.grpCreateOrEdit.Name = "grpCreateOrEdit";
            this.grpCreateOrEdit.Size = new System.Drawing.Size(1245, 628);
            this.grpCreateOrEdit.TabIndex = 0;
            this.grpCreateOrEdit.TabStop = false;
            this.grpCreateOrEdit.Text = "Character Details";
            // 
            // btnAllocatePoint
            // 
            this.btnAllocatePoint.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocatePoint.Location = new System.Drawing.Point(1045, 556);
            this.btnAllocatePoint.Name = "btnAllocatePoint";
            this.btnAllocatePoint.Size = new System.Drawing.Size(139, 54);
            this.btnAllocatePoint.TabIndex = 12;
            this.btnAllocatePoint.Text = "&Allocate Point";
            this.toolTip1.SetToolTip(this.btnAllocatePoint, "Click to allocate Point(alt+A)");
            this.btnAllocatePoint.UseVisualStyleBackColor = true;
            this.btnAllocatePoint.Click += new System.EventHandler(this.btnAllocatePoint_Click);
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(172, 274);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(227, 33);
            this.cboGender.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboGender, "Chhose the Gender");
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nudAC);
            this.panel1.Controls.Add(this.nudInitiative);
            this.panel1.Controls.Add(this.nudSpeed);
            this.panel1.Controls.Add(this.nudHitPoints);
            this.panel1.Controls.Add(this.nudEP);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(24, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 283);
            this.panel1.TabIndex = 25;
            // 
            // nudAC
            // 
            this.nudAC.Location = new System.Drawing.Point(183, 109);
            this.nudAC.Name = "nudAC";
            this.nudAC.Size = new System.Drawing.Size(120, 33);
            this.nudAC.TabIndex = 21;
            // 
            // nudInitiative
            // 
            this.nudInitiative.Location = new System.Drawing.Point(183, 156);
            this.nudInitiative.Name = "nudInitiative";
            this.nudInitiative.Size = new System.Drawing.Size(120, 33);
            this.nudInitiative.TabIndex = 20;
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(183, 199);
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 33);
            this.nudSpeed.TabIndex = 19;
            // 
            // nudHitPoints
            // 
            this.nudHitPoints.Location = new System.Drawing.Point(183, 243);
            this.nudHitPoints.Name = "nudHitPoints";
            this.nudHitPoints.Size = new System.Drawing.Size(120, 33);
            this.nudHitPoints.TabIndex = 16;
            // 
            // nudEP
            // 
            this.nudEP.Location = new System.Drawing.Point(183, 58);
            this.nudEP.Name = "nudEP";
            this.nudEP.Size = new System.Drawing.Size(120, 33);
            this.nudEP.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 27);
            this.label12.TabIndex = 13;
            this.label12.Text = "Speed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 27);
            this.label13.TabIndex = 12;
            this.label13.Text = "Hit Points";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 27);
            this.label14.TabIndex = 11;
            this.label14.Text = "Armor Class";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 27);
            this.label15.TabIndex = 10;
            this.label15.Text = "Initiative";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 29);
            this.label16.TabIndex = 7;
            this.label16.Text = "Experience Points";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Papyrus", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 34);
            this.label17.TabIndex = 6;
            this.label17.Text = "Additional Details";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1002, 646);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 54);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to exit(alt+E)");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(833, 646);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 54);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save Character";
            this.toolTip1.SetToolTip(this.btnSave, "Click to save the character");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(650, 646);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 54);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Click to reset the screen(alt+R)");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmEditor
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_3D_D.Properties.Resources.B;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1269, 710);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCreateOrEdit);
            this.Controls.Add(this.btnSave);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create or Edit Characters";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            this.grpCreateOrEdit.ResumeLayout(false);
            this.grpCreateOrEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitiative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHitPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlignment;
        private System.Windows.Forms.ComboBox cboAlignment;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpCreateOrEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.NumericUpDown nudDexterity;
        private System.Windows.Forms.NumericUpDown nudConstitution;
        private System.Windows.Forms.NumericUpDown nudIntelligence;
        private System.Windows.Forms.NumericUpDown nudCharisma;
        private System.Windows.Forms.NumericUpDown nudWisdom;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRemainingPointValue;
        private System.Windows.Forms.Label lblRemainingPoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudAC;
        private System.Windows.Forms.NumericUpDown nudInitiative;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudHitPoints;
        private System.Windows.Forms.NumericUpDown nudEP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblWisdomBonus;
        private System.Windows.Forms.Label lblCharismaBonus;
        private System.Windows.Forms.Label lblIntelligenceBonus;
        private System.Windows.Forms.Label lblConstitutionBonus;
        private System.Windows.Forms.Label lblDexterityBonus;
        private System.Windows.Forms.Label lblStrengthBonus;
        private System.Windows.Forms.Label lblCostDexterityValue;
        private System.Windows.Forms.Label lblCostConstitutionValue;
        private System.Windows.Forms.Label lblCostIntelligenceValue;
        private System.Windows.Forms.Label lblCostWisdomValue;
        private System.Windows.Forms.Label lblCostCharismaValue;
        private System.Windows.Forms.Label lblCostStrength;
        private System.Windows.Forms.Label lblCostDexteritry;
        private System.Windows.Forms.Label lblCostConstitution;
        private System.Windows.Forms.Label lblCostIntelligence;
        private System.Windows.Forms.Label lblCostWisdom;
        private System.Windows.Forms.Label lblCostCharisma;
        private System.Windows.Forms.Label lblCostStrengthValue;
        private System.Windows.Forms.Button btnAllocatePoint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}