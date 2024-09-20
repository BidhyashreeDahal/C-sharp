namespace ClassExercise01
{
    partial class frmMain
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnGTN = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.pnlGTN = new System.Windows.Forms.Panel();
            this.btnExitt = new System.Windows.Forms.Button();
            this.lblGTNTitle = new System.Windows.Forms.Label();
            this.btnGTNPlayAgain = new System.Windows.Forms.Button();
            this.nudGTNnumGuesses = new System.Windows.Forms.NumericUpDown();
            this.nudGTNActualNumber = new System.Windows.Forms.NumericUpDown();
            this.lblGTNOutput = new System.Windows.Forms.Label();
            this.btnGTNGuess = new System.Windows.Forms.Button();
            this.gbxGTNSettings = new System.Windows.Forms.GroupBox();
            this.cboGTNSettingDifficulty = new System.Windows.Forms.ComboBox();
            this.lblGTNGuessMaximum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGTNSettingsDifficulty = new System.Windows.Forms.Label();
            this.nudGTNGuess = new System.Windows.Forms.NumericUpDown();
            this.lblGTNEnterGuess = new System.Windows.Forms.Label();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.txtEnterCash = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnBack = new System.Windows.Forms.Button();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlIceCream = new System.Windows.Forms.Panel();
            this.lbxAddedIceCreams = new System.Windows.Forms.ListBox();
            this.pnlCashPayment = new System.Windows.Forms.Panel();
            this.lblCashBoxAmount = new System.Windows.Forms.Label();
            this.lblCashBoxTotal = new System.Windows.Forms.Label();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblTotalCashGiven = new System.Windows.Forms.Label();
            this.lblDisplayTotalPurchase = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSelectIcecream = new System.Windows.Forms.Label();
            this.cboProductlisst = new System.Windows.Forms.ComboBox();
            this.lblVanilla = new System.Windows.Forms.Label();
            this.lblPistachioPrice = new System.Windows.Forms.Label();
            this.lblPistachio = new System.Windows.Forms.Label();
            this.lblRocyRoadPrice = new System.Windows.Forms.Label();
            this.lbRocyRoad = new System.Windows.Forms.Label();
            this.lblStrawberryPrice = new System.Windows.Forms.Label();
            this.lblStrawberry = new System.Windows.Forms.Label();
            this.lblChocolatePrice = new System.Windows.Forms.Label();
            this.lblChocolate = new System.Windows.Forms.Label();
            this.lblVanillaPrice = new System.Windows.Forms.Label();
            this.lbxProductAvailable = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panMenu.SuspendLayout();
            this.pnlGTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNnumGuesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNActualNumber)).BeginInit();
            this.gbxGTNSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNGuess)).BeginInit();
            this.pnlIceCream.SuspendLayout();
            this.pnlCashPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panMenu.BackColor = System.Drawing.Color.Teal;
            this.panMenu.Controls.Add(this.btnGTN);
            this.panMenu.Controls.Add(this.lblMenuTitle);
            this.panMenu.Controls.Add(this.btnIceCream);
            this.panMenu.Location = new System.Drawing.Point(1, -1);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(157, 614);
            this.panMenu.TabIndex = 0;
            // 
            // btnGTN
            // 
            this.btnGTN.BackColor = System.Drawing.Color.LightCyan;
            this.btnGTN.Location = new System.Drawing.Point(9, 72);
            this.btnGTN.Name = "btnGTN";
            this.btnGTN.Size = new System.Drawing.Size(136, 66);
            this.btnGTN.TabIndex = 2;
            this.btnGTN.Text = "Guess The &Number";
            this.toolTips.SetToolTip(this.btnGTN, "Run Guess The Number Game (alt-N)");
            this.btnGTN.UseVisualStyleBackColor = false;
            this.btnGTN.Click += new System.EventHandler(this.btnGTN_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenuTitle.Location = new System.Drawing.Point(8, 8);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(139, 58);
            this.lblMenuTitle.TabIndex = 1;
            this.lblMenuTitle.Text = "My Little Games";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIceCream
            // 
            this.btnIceCream.BackColor = System.Drawing.Color.Pink;
            this.btnIceCream.Location = new System.Drawing.Point(9, 141);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(136, 66);
            this.btnIceCream.TabIndex = 3;
            this.btnIceCream.Text = "&Ice Cream";
            this.toolTips.SetToolTip(this.btnIceCream, "Click to order the icecream (alt+I)");
            this.btnIceCream.UseVisualStyleBackColor = true;
            this.btnIceCream.Click += new System.EventHandler(this.btnIceCream_Click);
            // 
            // pnlGTN
            // 
            this.pnlGTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGTN.Controls.Add(this.btnExitt);
            this.pnlGTN.Controls.Add(this.lblGTNTitle);
            this.pnlGTN.Controls.Add(this.btnGTNPlayAgain);
            this.pnlGTN.Controls.Add(this.nudGTNnumGuesses);
            this.pnlGTN.Controls.Add(this.nudGTNActualNumber);
            this.pnlGTN.Controls.Add(this.lblGTNOutput);
            this.pnlGTN.Controls.Add(this.btnGTNGuess);
            this.pnlGTN.Controls.Add(this.gbxGTNSettings);
            this.pnlGTN.Controls.Add(this.nudGTNGuess);
            this.pnlGTN.Controls.Add(this.lblGTNEnterGuess);
            this.pnlGTN.Location = new System.Drawing.Point(167, -1);
            this.pnlGTN.Name = "pnlGTN";
            this.pnlGTN.Size = new System.Drawing.Size(961, 610);
            this.pnlGTN.TabIndex = 4;
            this.toolTips.SetToolTip(this.pnlGTN, "\r\n");
            this.pnlGTN.Visible = false;
            // 
            // btnExitt
            // 
            this.btnExitt.Location = new System.Drawing.Point(795, 542);
            this.btnExitt.Name = "btnExitt";
            this.btnExitt.Size = new System.Drawing.Size(138, 49);
            this.btnExitt.TabIndex = 12;
            this.btnExitt.Text = "Ex&it";
            this.toolTips.SetToolTip(this.btnExitt, "Click to Exit(alt+i)");
            this.btnExitt.UseVisualStyleBackColor = true;
            this.btnExitt.Click += new System.EventHandler(this.btnExitt_Click);
            // 
            // lblGTNTitle
            // 
            this.lblGTNTitle.AutoSize = true;
            this.lblGTNTitle.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTNTitle.Location = new System.Drawing.Point(12, 13);
            this.lblGTNTitle.Name = "lblGTNTitle";
            this.lblGTNTitle.Size = new System.Drawing.Size(315, 45);
            this.lblGTNTitle.TabIndex = 0;
            this.lblGTNTitle.Text = "Guess The Number";
            // 
            // btnGTNPlayAgain
            // 
            this.btnGTNPlayAgain.Location = new System.Drawing.Point(507, 306);
            this.btnGTNPlayAgain.Name = "btnGTNPlayAgain";
            this.btnGTNPlayAgain.Size = new System.Drawing.Size(155, 49);
            this.btnGTNPlayAgain.TabIndex = 10;
            this.btnGTNPlayAgain.Text = "&Play Again";
            this.toolTips.SetToolTip(this.btnGTNPlayAgain, "Click to play again(alt+P)");
            this.btnGTNPlayAgain.UseVisualStyleBackColor = true;
            this.btnGTNPlayAgain.Visible = false;
            this.btnGTNPlayAgain.Click += new System.EventHandler(this.btnGTNPlayAgain_Click);
            // 
            // nudGTNnumGuesses
            // 
            this.nudGTNnumGuesses.Enabled = false;
            this.nudGTNnumGuesses.Location = new System.Drawing.Point(38, 306);
            this.nudGTNnumGuesses.Name = "nudGTNnumGuesses";
            this.nudGTNnumGuesses.Size = new System.Drawing.Size(120, 26);
            this.nudGTNnumGuesses.TabIndex = 8;
            // 
            // nudGTNActualNumber
            // 
            this.nudGTNActualNumber.Location = new System.Drawing.Point(38, 273);
            this.nudGTNActualNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGTNActualNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGTNActualNumber.Name = "nudGTNActualNumber";
            this.nudGTNActualNumber.Size = new System.Drawing.Size(120, 26);
            this.nudGTNActualNumber.TabIndex = 7;
            this.nudGTNActualNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGTNOutput
            // 
            this.lblGTNOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGTNOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGTNOutput.Location = new System.Drawing.Point(16, 381);
            this.lblGTNOutput.Name = "lblGTNOutput";
            this.lblGTNOutput.Size = new System.Drawing.Size(917, 174);
            this.lblGTNOutput.TabIndex = 11;
            // 
            // btnGTNGuess
            // 
            this.btnGTNGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGTNGuess.Location = new System.Drawing.Point(231, 259);
            this.btnGTNGuess.Name = "btnGTNGuess";
            this.btnGTNGuess.Size = new System.Drawing.Size(236, 110);
            this.btnGTNGuess.TabIndex = 9;
            this.btnGTNGuess.Text = "&Guess";
            this.toolTips.SetToolTip(this.btnGTNGuess, "Click to Guess the number(alt+G)");
            this.btnGTNGuess.UseVisualStyleBackColor = true;
            this.btnGTNGuess.Click += new System.EventHandler(this.btnGTNGuess_Click);
            // 
            // gbxGTNSettings
            // 
            this.gbxGTNSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGTNSettings.Controls.Add(this.cboGTNSettingDifficulty);
            this.gbxGTNSettings.Controls.Add(this.lblGTNGuessMaximum);
            this.gbxGTNSettings.Controls.Add(this.label4);
            this.gbxGTNSettings.Controls.Add(this.label3);
            this.gbxGTNSettings.Controls.Add(this.label2);
            this.gbxGTNSettings.Controls.Add(this.lblGTNSettingsDifficulty);
            this.gbxGTNSettings.Location = new System.Drawing.Point(20, 64);
            this.gbxGTNSettings.Name = "gbxGTNSettings";
            this.gbxGTNSettings.Size = new System.Drawing.Size(913, 100);
            this.gbxGTNSettings.TabIndex = 3;
            this.gbxGTNSettings.TabStop = false;
            this.gbxGTNSettings.Text = "Settings";
            // 
            // cboGTNSettingDifficulty
            // 
            this.cboGTNSettingDifficulty.FormattingEnabled = true;
            this.cboGTNSettingDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cboGTNSettingDifficulty.Location = new System.Drawing.Point(118, 26);
            this.cboGTNSettingDifficulty.Name = "cboGTNSettingDifficulty";
            this.cboGTNSettingDifficulty.Size = new System.Drawing.Size(121, 28);
            this.cboGTNSettingDifficulty.TabIndex = 5;
            this.toolTips.SetToolTip(this.cboGTNSettingDifficulty, "Change the level of your game. By hitting the down arrow.\r\n");
            this.cboGTNSettingDifficulty.SelectedIndexChanged += new System.EventHandler(this.cboGTNSettingDifficulty_SelectedIndexChanged);
            // 
            // lblGTNGuessMaximum
            // 
            this.lblGTNGuessMaximum.AutoSize = true;
            this.lblGTNGuessMaximum.Location = new System.Drawing.Point(442, 69);
            this.lblGTNGuessMaximum.Name = "lblGTNGuessMaximum";
            this.lblGTNGuessMaximum.Size = new System.Drawing.Size(27, 20);
            this.lblGTNGuessMaximum.TabIndex = 4;
            this.lblGTNGuessMaximum.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum";
            // 
            // lblGTNSettingsDifficulty
            // 
            this.lblGTNSettingsDifficulty.AutoSize = true;
            this.lblGTNSettingsDifficulty.Location = new System.Drawing.Point(24, 32);
            this.lblGTNSettingsDifficulty.Name = "lblGTNSettingsDifficulty";
            this.lblGTNSettingsDifficulty.Size = new System.Drawing.Size(69, 20);
            this.lblGTNSettingsDifficulty.TabIndex = 0;
            this.lblGTNSettingsDifficulty.Text = "Difficulty";
            // 
            // nudGTNGuess
            // 
            this.nudGTNGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGTNGuess.Location = new System.Drawing.Point(265, 186);
            this.nudGTNGuess.Name = "nudGTNGuess";
            this.nudGTNGuess.Size = new System.Drawing.Size(157, 62);
            this.nudGTNGuess.TabIndex = 6;
            this.toolTips.SetToolTip(this.nudGTNGuess, "Enter your guess number.");
            // 
            // lblGTNEnterGuess
            // 
            this.lblGTNEnterGuess.AutoSize = true;
            this.lblGTNEnterGuess.Location = new System.Drawing.Point(134, 205);
            this.lblGTNEnterGuess.Name = "lblGTNEnterGuess";
            this.lblGTNEnterGuess.Size = new System.Drawing.Size(112, 20);
            this.lblGTNEnterGuess.TabIndex = 1;
            this.lblGTNEnterGuess.Text = "Enter a Guess";
            // 
            // txtEnterCash
            // 
            this.txtEnterCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterCash.Location = new System.Drawing.Point(273, 10);
            this.txtEnterCash.Name = "txtEnterCash";
            this.txtEnterCash.Size = new System.Drawing.Size(136, 28);
            this.txtEnterCash.TabIndex = 27;
            this.txtEnterCash.Text = "0";
            this.toolTips.SetToolTip(this.txtEnterCash, "Enter The Total Cash Amount In Dollar\r\n");
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(672, 530);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 45);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "C&lear";
            this.toolTips.SetToolTip(this.btnClear, "Click To clear the screen (alt+l)");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(797, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 45);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "E&xit";
            this.toolTips.SetToolTip(this.btnExit, "Click to Exit.(alt +x)");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturnBack
            // 
            this.btnReturnBack.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnReturnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBack.Location = new System.Drawing.Point(168, 55);
            this.btnReturnBack.Name = "btnReturnBack";
            this.btnReturnBack.Size = new System.Drawing.Size(141, 38);
            this.btnReturnBack.TabIndex = 28;
            this.btnReturnBack.Text = "R&eturn Amount";
            this.btnReturnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTips.SetToolTip(this.btnReturnBack, "Click to calculate the Change(alt+e)");
            this.btnReturnBack.UseVisualStyleBackColor = false;
            this.btnReturnBack.Click += new System.EventHandler(this.btnReturnBack_Click);
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotal.Location = new System.Drawing.Point(98, 208);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(111, 59);
            this.btnCalculateTotal.TabIndex = 23;
            this.btnCalculateTotal.Text = "&Calculate Total";
            this.toolTips.SetToolTip(this.btnCalculateTotal, "Click To calculate total amount to pay(alt +C)");
            this.btnCalculateTotal.UseVisualStyleBackColor = false;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackColor = System.Drawing.Color.Thistle;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(620, 72);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(95, 34);
            this.btnRemoveProduct.TabIndex = 22;
            this.btnRemoveProduct.Text = "&Remove";
            this.toolTips.SetToolTip(this.btnRemoveProduct, "Click Remove to remove the selected items from the order list(alt+R)");
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(505, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 36);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "&Add";
            this.toolTips.SetToolTip(this.btnAdd, "Click Add to order(alt+A)");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlIceCream
            // 
            this.pnlIceCream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIceCream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlIceCream.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIceCream.Controls.Add(this.lbxAddedIceCreams);
            this.pnlIceCream.Controls.Add(this.btnClear);
            this.pnlIceCream.Controls.Add(this.btnExit);
            this.pnlIceCream.Controls.Add(this.pnlCashPayment);
            this.pnlIceCream.Controls.Add(this.btnCalculateTotal);
            this.pnlIceCream.Controls.Add(this.btnRemoveProduct);
            this.pnlIceCream.Controls.Add(this.lblDisplayTotalPurchase);
            this.pnlIceCream.Controls.Add(this.lblTotal);
            this.pnlIceCream.Controls.Add(this.btnAdd);
            this.pnlIceCream.Controls.Add(this.nudQuantity);
            this.pnlIceCream.Controls.Add(this.lblQuantity);
            this.pnlIceCream.Controls.Add(this.lblSelectIcecream);
            this.pnlIceCream.Controls.Add(this.cboProductlisst);
            this.pnlIceCream.Controls.Add(this.lblVanilla);
            this.pnlIceCream.Controls.Add(this.lblPistachioPrice);
            this.pnlIceCream.Controls.Add(this.lblPistachio);
            this.pnlIceCream.Controls.Add(this.lblRocyRoadPrice);
            this.pnlIceCream.Controls.Add(this.lbRocyRoad);
            this.pnlIceCream.Controls.Add(this.lblStrawberryPrice);
            this.pnlIceCream.Controls.Add(this.lblStrawberry);
            this.pnlIceCream.Controls.Add(this.lblChocolatePrice);
            this.pnlIceCream.Controls.Add(this.lblChocolate);
            this.pnlIceCream.Controls.Add(this.lblVanillaPrice);
            this.pnlIceCream.Controls.Add(this.lbxProductAvailable);
            this.pnlIceCream.Location = new System.Drawing.Point(164, -1);
            this.pnlIceCream.Name = "pnlIceCream";
            this.pnlIceCream.Size = new System.Drawing.Size(964, 614);
            this.pnlIceCream.TabIndex = 3;
            this.pnlIceCream.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIceCream_Paint);
            // 
            // lbxAddedIceCreams
            // 
            this.lbxAddedIceCreams.FormattingEnabled = true;
            this.lbxAddedIceCreams.ItemHeight = 20;
            this.lbxAddedIceCreams.Location = new System.Drawing.Point(282, 58);
            this.lbxAddedIceCreams.Name = "lbxAddedIceCreams";
            this.lbxAddedIceCreams.Size = new System.Drawing.Size(179, 144);
            this.lbxAddedIceCreams.TabIndex = 28;
            // 
            // pnlCashPayment
            // 
            this.pnlCashPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCashPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCashPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCashPayment.Controls.Add(this.lblCashBoxAmount);
            this.pnlCashPayment.Controls.Add(this.lblCashBoxTotal);
            this.pnlCashPayment.Controls.Add(this.lblReturnAmount);
            this.pnlCashPayment.Controls.Add(this.btnReturnBack);
            this.pnlCashPayment.Controls.Add(this.txtEnterCash);
            this.pnlCashPayment.Controls.Add(this.lblTotalCashGiven);
            this.pnlCashPayment.Location = new System.Drawing.Point(316, 253);
            this.pnlCashPayment.Name = "pnlCashPayment";
            this.pnlCashPayment.Size = new System.Drawing.Size(499, 271);
            this.pnlCashPayment.TabIndex = 26;
            // 
            // lblCashBoxAmount
            // 
            this.lblCashBoxAmount.AutoSize = true;
            this.lblCashBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashBoxAmount.Location = new System.Drawing.Point(255, 184);
            this.lblCashBoxAmount.Name = "lblCashBoxAmount";
            this.lblCashBoxAmount.Size = new System.Drawing.Size(54, 22);
            this.lblCashBoxAmount.TabIndex = 5;
            this.lblCashBoxAmount.Text = "$100";
            // 
            // lblCashBoxTotal
            // 
            this.lblCashBoxTotal.AutoSize = true;
            this.lblCashBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashBoxTotal.Location = new System.Drawing.Point(79, 184);
            this.lblCashBoxTotal.Name = "lblCashBoxTotal";
            this.lblCashBoxTotal.Size = new System.Drawing.Size(160, 22);
            this.lblCashBoxTotal.TabIndex = 4;
            this.lblCashBoxTotal.Text = "Cash Box Total :";
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmount.Location = new System.Drawing.Point(230, 119);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(32, 22);
            this.lblReturnAmount.TabIndex = 3;
            this.lblReturnAmount.Text = "$0";
            // 
            // lblTotalCashGiven
            // 
            this.lblTotalCashGiven.AutoSize = true;
            this.lblTotalCashGiven.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCashGiven.Location = new System.Drawing.Point(40, 14);
            this.lblTotalCashGiven.Name = "lblTotalCashGiven";
            this.lblTotalCashGiven.Size = new System.Drawing.Size(175, 22);
            this.lblTotalCashGiven.TabIndex = 0;
            this.lblTotalCashGiven.Text = "Total Cash Given :";
            // 
            // lblDisplayTotalPurchase
            // 
            this.lblDisplayTotalPurchase.AutoSize = true;
            this.lblDisplayTotalPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDisplayTotalPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotalPurchase.Location = new System.Drawing.Point(286, 228);
            this.lblDisplayTotalPurchase.Name = "lblDisplayTotalPurchase";
            this.lblDisplayTotalPurchase.Size = new System.Drawing.Size(32, 22);
            this.lblDisplayTotalPurchase.TabIndex = 25;
            this.lblDisplayTotalPurchase.Text = "$0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(224, 225);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 25);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total :";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(505, 28);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(159, 26);
            this.nudQuantity.TabIndex = 20;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(504, -1);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 25);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSelectIcecream
            // 
            this.lblSelectIcecream.AutoSize = true;
            this.lblSelectIcecream.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectIcecream.Location = new System.Drawing.Point(277, -2);
            this.lblSelectIcecream.Name = "lblSelectIcecream";
            this.lblSelectIcecream.Size = new System.Drawing.Size(192, 25);
            this.lblSelectIcecream.TabIndex = 16;
            this.lblSelectIcecream.Text = "Select The Icecream";
            // 
            // cboProductlisst
            // 
            this.cboProductlisst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductlisst.FormattingEnabled = true;
            this.cboProductlisst.Items.AddRange(new object[] {
            "Vanilla ",
            "Chocolate ",
            "Strawberry ",
            "Rocy Road ",
            "Pastachio "});
            this.cboProductlisst.Location = new System.Drawing.Point(283, 24);
            this.cboProductlisst.Name = "cboProductlisst";
            this.cboProductlisst.Size = new System.Drawing.Size(178, 30);
            this.cboProductlisst.TabIndex = 17;
            // 
            // lblVanilla
            // 
            this.lblVanilla.AutoSize = true;
            this.lblVanilla.BackColor = System.Drawing.Color.White;
            this.lblVanilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanilla.Location = new System.Drawing.Point(5, 34);
            this.lblVanilla.Name = "lblVanilla";
            this.lblVanilla.Size = new System.Drawing.Size(143, 24);
            this.lblVanilla.TabIndex = 6;
            this.lblVanilla.Text = "Vanilla Icecream";
            // 
            // lblPistachioPrice
            // 
            this.lblPistachioPrice.AutoSize = true;
            this.lblPistachioPrice.BackColor = System.Drawing.Color.White;
            this.lblPistachioPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPistachioPrice.Location = new System.Drawing.Point(215, 152);
            this.lblPistachioPrice.Name = "lblPistachioPrice";
            this.lblPistachioPrice.Size = new System.Drawing.Size(32, 22);
            this.lblPistachioPrice.TabIndex = 15;
            this.lblPistachioPrice.Text = "$3";
            // 
            // lblPistachio
            // 
            this.lblPistachio.AutoSize = true;
            this.lblPistachio.BackColor = System.Drawing.Color.White;
            this.lblPistachio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPistachio.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblPistachio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPistachio.Location = new System.Drawing.Point(5, 152);
            this.lblPistachio.Name = "lblPistachio";
            this.lblPistachio.Size = new System.Drawing.Size(162, 24);
            this.lblPistachio.TabIndex = 14;
            this.lblPistachio.Text = "Pistachio Icecream";
            this.lblPistachio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRocyRoadPrice
            // 
            this.lblRocyRoadPrice.AutoSize = true;
            this.lblRocyRoadPrice.BackColor = System.Drawing.Color.White;
            this.lblRocyRoadPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRocyRoadPrice.Location = new System.Drawing.Point(215, 121);
            this.lblRocyRoadPrice.Name = "lblRocyRoadPrice";
            this.lblRocyRoadPrice.Size = new System.Drawing.Size(32, 22);
            this.lblRocyRoadPrice.TabIndex = 13;
            this.lblRocyRoadPrice.Text = "$3";
            // 
            // lbRocyRoad
            // 
            this.lbRocyRoad.AutoSize = true;
            this.lbRocyRoad.BackColor = System.Drawing.Color.White;
            this.lbRocyRoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRocyRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRocyRoad.Location = new System.Drawing.Point(5, 121);
            this.lbRocyRoad.Name = "lbRocyRoad";
            this.lbRocyRoad.Size = new System.Drawing.Size(178, 24);
            this.lbRocyRoad.TabIndex = 12;
            this.lbRocyRoad.Text = "Rocy Road Icecream";
            // 
            // lblStrawberryPrice
            // 
            this.lblStrawberryPrice.AutoSize = true;
            this.lblStrawberryPrice.BackColor = System.Drawing.Color.White;
            this.lblStrawberryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrawberryPrice.Location = new System.Drawing.Point(215, 96);
            this.lblStrawberryPrice.Name = "lblStrawberryPrice";
            this.lblStrawberryPrice.Size = new System.Drawing.Size(32, 22);
            this.lblStrawberryPrice.TabIndex = 11;
            this.lblStrawberryPrice.Text = "$3";
            // 
            // lblStrawberry
            // 
            this.lblStrawberry.AutoSize = true;
            this.lblStrawberry.BackColor = System.Drawing.Color.White;
            this.lblStrawberry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrawberry.Location = new System.Drawing.Point(5, 94);
            this.lblStrawberry.Name = "lblStrawberry";
            this.lblStrawberry.Size = new System.Drawing.Size(176, 24);
            this.lblStrawberry.TabIndex = 10;
            this.lblStrawberry.Text = "Strawberry Icecream";
            // 
            // lblChocolatePrice
            // 
            this.lblChocolatePrice.AutoSize = true;
            this.lblChocolatePrice.BackColor = System.Drawing.Color.White;
            this.lblChocolatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChocolatePrice.Location = new System.Drawing.Point(215, 65);
            this.lblChocolatePrice.Name = "lblChocolatePrice";
            this.lblChocolatePrice.Size = new System.Drawing.Size(32, 22);
            this.lblChocolatePrice.TabIndex = 9;
            this.lblChocolatePrice.Text = "$4";
            // 
            // lblChocolate
            // 
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.BackColor = System.Drawing.Color.White;
            this.lblChocolate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChocolate.Location = new System.Drawing.Point(5, 65);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(170, 24);
            this.lblChocolate.TabIndex = 8;
            this.lblChocolate.Text = "Chocolate Icecream";
            // 
            // lblVanillaPrice
            // 
            this.lblVanillaPrice.AutoSize = true;
            this.lblVanillaPrice.BackColor = System.Drawing.Color.White;
            this.lblVanillaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanillaPrice.Location = new System.Drawing.Point(215, 34);
            this.lblVanillaPrice.Name = "lblVanillaPrice";
            this.lblVanillaPrice.Size = new System.Drawing.Size(32, 22);
            this.lblVanillaPrice.TabIndex = 7;
            this.lblVanillaPrice.Text = "$3";
            // 
            // lbxProductAvailable
            // 
            this.lbxProductAvailable.BackColor = System.Drawing.Color.White;
            this.lbxProductAvailable.FormattingEnabled = true;
            this.lbxProductAvailable.ItemHeight = 20;
            this.lbxProductAvailable.Location = new System.Drawing.Point(-2, -2);
            this.lbxProductAvailable.Name = "lbxProductAvailable";
            this.lbxProductAvailable.Size = new System.Drawing.Size(282, 204);
            this.lbxProductAvailable.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1127, 611);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.pnlIceCream);
            this.Controls.Add(this.pnlGTN);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Little Games";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMenu.ResumeLayout(false);
            this.pnlGTN.ResumeLayout(false);
            this.pnlGTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNnumGuesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNActualNumber)).EndInit();
            this.gbxGTNSettings.ResumeLayout(false);
            this.gbxGTNSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGTNGuess)).EndInit();
            this.pnlIceCream.ResumeLayout(false);
            this.pnlIceCream.PerformLayout();
            this.pnlCashPayment.ResumeLayout(false);
            this.pnlCashPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnIceCream;
        private System.Windows.Forms.Button btnGTN;
        private System.Windows.Forms.Panel pnlGTN;
        private System.Windows.Forms.Label lblGTNEnterGuess;
        private System.Windows.Forms.Label lblGTNTitle;
        private System.Windows.Forms.GroupBox gbxGTNSettings;
        private System.Windows.Forms.ComboBox cboGTNSettingDifficulty;
        private System.Windows.Forms.Label lblGTNGuessMaximum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGTNSettingsDifficulty;
        private System.Windows.Forms.NumericUpDown nudGTNGuess;
        private System.Windows.Forms.Label lblGTNOutput;
        private System.Windows.Forms.Button btnGTNGuess;
        private System.Windows.Forms.NumericUpDown nudGTNnumGuesses;
        private System.Windows.Forms.NumericUpDown nudGTNActualNumber;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button btnGTNPlayAgain;
        private System.Windows.Forms.Panel pnlIceCream;
        private System.Windows.Forms.ListBox lbxProductAvailable;
        private System.Windows.Forms.Label lblVanilla;
        private System.Windows.Forms.Label lblPistachioPrice;
        private System.Windows.Forms.Label lblPistachio;
        private System.Windows.Forms.Label lblRocyRoadPrice;
        private System.Windows.Forms.Label lbRocyRoad;
        private System.Windows.Forms.Label lblStrawberryPrice;
        private System.Windows.Forms.Label lblStrawberry;
        private System.Windows.Forms.Label lblChocolatePrice;
        private System.Windows.Forms.Label lblChocolate;
        private System.Windows.Forms.Label lblVanillaPrice;
        private System.Windows.Forms.ComboBox cboProductlisst;
        private System.Windows.Forms.Label lblSelectIcecream;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDisplayTotalPurchase;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Panel pnlCashPayment;
        private System.Windows.Forms.TextBox txtEnterCash;
        private System.Windows.Forms.Label lblTotalCashGiven;
        private System.Windows.Forms.Button btnReturnBack;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.Label lblCashBoxAmount;
        private System.Windows.Forms.Label lblCashBoxTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExitt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbxAddedIceCreams;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

