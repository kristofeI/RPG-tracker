namespace TrackerUI
{
    partial class GMTrackerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GMTrackerUI));
            this.headerLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fightLabel = new System.Windows.Forms.Label();
            this.NPCLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.eventHistoryButton = new System.Windows.Forms.Button();
            this.bodyNeedsButton = new System.Windows.Forms.Button();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.NpcListBox = new System.Windows.Forms.ListBox();
            this.showEditCharacterButton = new System.Windows.Forms.Button();
            this.pickUnitsLabel = new System.Windows.Forms.Label();
            this.fightingUnitsListBox = new System.Windows.Forms.ListBox();
            this.startFightButton = new System.Windows.Forms.Button();
            this.addCharacterToFightButton = new System.Windows.Forms.Button();
            this.removeSelectedFightUnitsButton = new System.Windows.Forms.Button();
            this.charactersGroupBox = new System.Windows.Forms.GroupBox();
            this.choosingTableLabel = new System.Windows.Forms.Label();
            this.npcRadioButton = new System.Windows.Forms.RadioButton();
            this.teamRadioButton = new System.Windows.Forms.RadioButton();
            this.makeNewCharacterButton = new System.Windows.Forms.Button();
            this.removeCharacterButton = new System.Windows.Forms.Button();
            this.addOldCharacterGroupBox = new System.Windows.Forms.GroupBox();
            this.pickPlayerLabel = new System.Windows.Forms.Label();
            this.pickCharacterLabel = new System.Windows.Forms.Label();
            this.playerListDropDown = new System.Windows.Forms.ComboBox();
            this.characterListDropDown = new System.Windows.Forms.ComboBox();
            this.addExistingCharacterToListButton = new System.Windows.Forms.Button();
            this.subtractTimeButton = new System.Windows.Forms.Button();
            this.addTimeButton = new System.Windows.Forms.Button();
            this.yearValue = new System.Windows.Forms.TextBox();
            this.monthValue = new System.Windows.Forms.TextBox();
            this.dayValue = new System.Windows.Forms.TextBox();
            this.changeDateButton = new System.Windows.Forms.Button();
            this.timeIntervalsLabel = new System.Windows.Forms.Label();
            this.actualTimeOfDayLabel = new System.Windows.Forms.Label();
            this.charactersGroupBox.SuspendLayout();
            this.addOldCharacterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(448, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(293, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Panel Mistrza Gry";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateLabel.Location = new System.Drawing.Point(810, 54);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(187, 37);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Aktualna data:";
            // 
            // fightLabel
            // 
            this.fightLabel.AutoSize = true;
            this.fightLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fightLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.fightLabel.Location = new System.Drawing.Point(824, 455);
            this.fightLabel.Name = "fightLabel";
            this.fightLabel.Size = new System.Drawing.Size(90, 37);
            this.fightLabel.TabIndex = 7;
            this.fightLabel.Text = "Walka";
            // 
            // NPCLabel
            // 
            this.NPCLabel.AutoSize = true;
            this.NPCLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NPCLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NPCLabel.Location = new System.Drawing.Point(372, 50);
            this.NPCLabel.Name = "NPCLabel";
            this.NPCLabel.Size = new System.Drawing.Size(255, 37);
            this.NPCLabel.TabIndex = 8;
            this.NPCLabel.Text = "Inne postacie (NPC):";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamLabel.Location = new System.Drawing.Point(6, 50);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(120, 37);
            this.teamLabel.TabIndex = 9;
            this.teamLabel.Text = "Drużyna:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.timeLabel.Location = new System.Drawing.Point(810, 222);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(107, 37);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "HH:mm";
            // 
            // eventHistoryButton
            // 
            this.eventHistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eventHistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.eventHistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eventHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventHistoryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventHistoryButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.eventHistoryButton.Location = new System.Drawing.Point(817, 282);
            this.eventHistoryButton.Name = "eventHistoryButton";
            this.eventHistoryButton.Size = new System.Drawing.Size(290, 52);
            this.eventHistoryButton.TabIndex = 14;
            this.eventHistoryButton.Text = "Historia wydarzeń";
            this.eventHistoryButton.UseVisualStyleBackColor = true;
            this.eventHistoryButton.Click += new System.EventHandler(this.timeDescriptionButton_Click);
            // 
            // bodyNeedsButton
            // 
            this.bodyNeedsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bodyNeedsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bodyNeedsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bodyNeedsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodyNeedsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bodyNeedsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bodyNeedsButton.Location = new System.Drawing.Point(817, 340);
            this.bodyNeedsButton.Name = "bodyNeedsButton";
            this.bodyNeedsButton.Size = new System.Drawing.Size(290, 54);
            this.bodyNeedsButton.TabIndex = 15;
            this.bodyNeedsButton.Text = "Potrzeby fizjologiczne";
            this.bodyNeedsButton.UseVisualStyleBackColor = true;
            this.bodyNeedsButton.Click += new System.EventHandler(this.bodyNeedsButton_Click);
            // 
            // teamListBox
            // 
            this.teamListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.ItemHeight = 30;
            this.teamListBox.Location = new System.Drawing.Point(13, 90);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(316, 184);
            this.teamListBox.TabIndex = 16;
            // 
            // NpcListBox
            // 
            this.NpcListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NpcListBox.FormattingEnabled = true;
            this.NpcListBox.ItemHeight = 30;
            this.NpcListBox.Location = new System.Drawing.Point(379, 90);
            this.NpcListBox.Name = "NpcListBox";
            this.NpcListBox.Size = new System.Drawing.Size(316, 184);
            this.NpcListBox.TabIndex = 18;
            // 
            // showEditCharacterButton
            // 
            this.showEditCharacterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showEditCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.showEditCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showEditCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showEditCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showEditCharacterButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.showEditCharacterButton.Location = new System.Drawing.Point(24, 396);
            this.showEditCharacterButton.Name = "showEditCharacterButton";
            this.showEditCharacterButton.Size = new System.Drawing.Size(671, 55);
            this.showEditCharacterButton.TabIndex = 20;
            this.showEditCharacterButton.Text = "Wyświetl/edytuj szczegóły wybranej postaci z listy";
            this.showEditCharacterButton.UseVisualStyleBackColor = true;
            this.showEditCharacterButton.Click += new System.EventHandler(this.showEditCharacterButton_Click);
            // 
            // pickUnitsLabel
            // 
            this.pickUnitsLabel.AutoSize = true;
            this.pickUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pickUnitsLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.pickUnitsLabel.Location = new System.Drawing.Point(822, 492);
            this.pickUnitsLabel.Name = "pickUnitsLabel";
            this.pickUnitsLabel.Size = new System.Drawing.Size(310, 30);
            this.pickUnitsLabel.TabIndex = 22;
            this.pickUnitsLabel.Text = "Postacie biorące udział w walce:";
            // 
            // fightingUnitsListBox
            // 
            this.fightingUnitsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fightingUnitsListBox.FormattingEnabled = true;
            this.fightingUnitsListBox.ItemHeight = 30;
            this.fightingUnitsListBox.Location = new System.Drawing.Point(827, 525);
            this.fightingUnitsListBox.Name = "fightingUnitsListBox";
            this.fightingUnitsListBox.Size = new System.Drawing.Size(316, 184);
            this.fightingUnitsListBox.TabIndex = 23;
            // 
            // startFightButton
            // 
            this.startFightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startFightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.startFightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startFightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startFightButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startFightButton.ForeColor = System.Drawing.Color.MediumPurple;
            this.startFightButton.Location = new System.Drawing.Point(827, 727);
            this.startFightButton.Name = "startFightButton";
            this.startFightButton.Size = new System.Drawing.Size(318, 54);
            this.startFightButton.TabIndex = 24;
            this.startFightButton.Text = "Rozpocznij walkę";
            this.startFightButton.UseVisualStyleBackColor = true;
            this.startFightButton.Click += new System.EventHandler(this.startFightButton_Click);
            // 
            // addCharacterToFightButton
            // 
            this.addCharacterToFightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addCharacterToFightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addCharacterToFightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addCharacterToFightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCharacterToFightButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addCharacterToFightButton.ForeColor = System.Drawing.Color.MediumPurple;
            this.addCharacterToFightButton.Location = new System.Drawing.Point(24, 456);
            this.addCharacterToFightButton.Name = "addCharacterToFightButton";
            this.addCharacterToFightButton.Size = new System.Drawing.Size(671, 55);
            this.addCharacterToFightButton.TabIndex = 25;
            this.addCharacterToFightButton.Text = "Dodaj postać do walki";
            this.addCharacterToFightButton.UseVisualStyleBackColor = true;
            this.addCharacterToFightButton.Click += new System.EventHandler(this.addCharacterToFightButton_Click);
            // 
            // removeSelectedFightUnitsButton
            // 
            this.removeSelectedFightUnitsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeSelectedFightUnitsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeSelectedFightUnitsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeSelectedFightUnitsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedFightUnitsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSelectedFightUnitsButton.ForeColor = System.Drawing.Color.Red;
            this.removeSelectedFightUnitsButton.Location = new System.Drawing.Point(825, 787);
            this.removeSelectedFightUnitsButton.Name = "removeSelectedFightUnitsButton";
            this.removeSelectedFightUnitsButton.Size = new System.Drawing.Size(318, 54);
            this.removeSelectedFightUnitsButton.TabIndex = 26;
            this.removeSelectedFightUnitsButton.Text = "Usuń zaznaczone";
            this.removeSelectedFightUnitsButton.UseVisualStyleBackColor = true;
            this.removeSelectedFightUnitsButton.Click += new System.EventHandler(this.removeSelectedFightUnitsButton_Click);
            // 
            // charactersGroupBox
            // 
            this.charactersGroupBox.Controls.Add(this.choosingTableLabel);
            this.charactersGroupBox.Controls.Add(this.npcRadioButton);
            this.charactersGroupBox.Controls.Add(this.teamRadioButton);
            this.charactersGroupBox.Controls.Add(this.makeNewCharacterButton);
            this.charactersGroupBox.Controls.Add(this.removeCharacterButton);
            this.charactersGroupBox.Controls.Add(this.addOldCharacterGroupBox);
            this.charactersGroupBox.Controls.Add(this.teamLabel);
            this.charactersGroupBox.Controls.Add(this.NPCLabel);
            this.charactersGroupBox.Controls.Add(this.teamListBox);
            this.charactersGroupBox.Controls.Add(this.addCharacterToFightButton);
            this.charactersGroupBox.Controls.Add(this.NpcListBox);
            this.charactersGroupBox.Controls.Add(this.showEditCharacterButton);
            this.charactersGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.charactersGroupBox.Location = new System.Drawing.Point(68, 82);
            this.charactersGroupBox.Name = "charactersGroupBox";
            this.charactersGroupBox.Size = new System.Drawing.Size(705, 766);
            this.charactersGroupBox.TabIndex = 28;
            this.charactersGroupBox.TabStop = false;
            this.charactersGroupBox.Text = "Listy Postaci";
            // 
            // choosingTableLabel
            // 
            this.choosingTableLabel.AutoSize = true;
            this.choosingTableLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.choosingTableLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.choosingTableLabel.Location = new System.Drawing.Point(199, 310);
            this.choosingTableLabel.Name = "choosingTableLabel";
            this.choosingTableLabel.Size = new System.Drawing.Size(297, 30);
            this.choosingTableLabel.TabIndex = 31;
            this.choosingTableLabel.Text = "Wybierz listę postaci do edycji:";
            // 
            // npcRadioButton
            // 
            this.npcRadioButton.AutoSize = true;
            this.npcRadioButton.Location = new System.Drawing.Point(417, 343);
            this.npcRadioButton.Name = "npcRadioButton";
            this.npcRadioButton.Size = new System.Drawing.Size(72, 34);
            this.npcRadioButton.TabIndex = 30;
            this.npcRadioButton.TabStop = true;
            this.npcRadioButton.Text = "NPC";
            this.npcRadioButton.UseVisualStyleBackColor = true;
            // 
            // teamRadioButton
            // 
            this.teamRadioButton.AutoSize = true;
            this.teamRadioButton.Location = new System.Drawing.Point(204, 343);
            this.teamRadioButton.Name = "teamRadioButton";
            this.teamRadioButton.Size = new System.Drawing.Size(108, 34);
            this.teamRadioButton.TabIndex = 29;
            this.teamRadioButton.TabStop = true;
            this.teamRadioButton.Text = "Drużyna";
            this.teamRadioButton.UseVisualStyleBackColor = true;
            // 
            // makeNewCharacterButton
            // 
            this.makeNewCharacterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.makeNewCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.makeNewCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.makeNewCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeNewCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.makeNewCharacterButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.makeNewCharacterButton.Location = new System.Drawing.Point(24, 644);
            this.makeNewCharacterButton.Name = "makeNewCharacterButton";
            this.makeNewCharacterButton.Size = new System.Drawing.Size(671, 55);
            this.makeNewCharacterButton.TabIndex = 28;
            this.makeNewCharacterButton.Text = "Stwórz nową postać i dodaj ją do listy";
            this.makeNewCharacterButton.UseVisualStyleBackColor = true;
            this.makeNewCharacterButton.Click += new System.EventHandler(this.makeNewCharacterButton_Click);
            // 
            // removeCharacterButton
            // 
            this.removeCharacterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeCharacterButton.ForeColor = System.Drawing.Color.Red;
            this.removeCharacterButton.Location = new System.Drawing.Point(24, 705);
            this.removeCharacterButton.Name = "removeCharacterButton";
            this.removeCharacterButton.Size = new System.Drawing.Size(671, 55);
            this.removeCharacterButton.TabIndex = 27;
            this.removeCharacterButton.Text = "Usuń wybraną postać z listy";
            this.removeCharacterButton.UseVisualStyleBackColor = true;
            this.removeCharacterButton.Click += new System.EventHandler(this.removeCharacterButton_Click);
            // 
            // addOldCharacterGroupBox
            // 
            this.addOldCharacterGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addOldCharacterGroupBox.Controls.Add(this.pickPlayerLabel);
            this.addOldCharacterGroupBox.Controls.Add(this.pickCharacterLabel);
            this.addOldCharacterGroupBox.Controls.Add(this.playerListDropDown);
            this.addOldCharacterGroupBox.Controls.Add(this.characterListDropDown);
            this.addOldCharacterGroupBox.Controls.Add(this.addExistingCharacterToListButton);
            this.addOldCharacterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOldCharacterGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addOldCharacterGroupBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.addOldCharacterGroupBox.Location = new System.Drawing.Point(24, 516);
            this.addOldCharacterGroupBox.Name = "addOldCharacterGroupBox";
            this.addOldCharacterGroupBox.Size = new System.Drawing.Size(671, 122);
            this.addOldCharacterGroupBox.TabIndex = 26;
            this.addOldCharacterGroupBox.TabStop = false;
            this.addOldCharacterGroupBox.Text = "Dodaj do listy istniejącą postać";
            // 
            // pickPlayerLabel
            // 
            this.pickPlayerLabel.AutoSize = true;
            this.pickPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pickPlayerLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.pickPlayerLabel.Location = new System.Drawing.Point(44, 45);
            this.pickPlayerLabel.Name = "pickPlayerLabel";
            this.pickPlayerLabel.Size = new System.Drawing.Size(160, 30);
            this.pickPlayerLabel.TabIndex = 27;
            this.pickPlayerLabel.Text = "Wybierz gracza:";
            // 
            // pickCharacterLabel
            // 
            this.pickCharacterLabel.AutoSize = true;
            this.pickCharacterLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pickCharacterLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.pickCharacterLabel.Location = new System.Drawing.Point(272, 45);
            this.pickCharacterLabel.Name = "pickCharacterLabel";
            this.pickCharacterLabel.Size = new System.Drawing.Size(160, 30);
            this.pickCharacterLabel.TabIndex = 26;
            this.pickCharacterLabel.Text = "Wybierz postać:";
            // 
            // playerListDropDown
            // 
            this.playerListDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerListDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerListDropDown.FormattingEnabled = true;
            this.playerListDropDown.Location = new System.Drawing.Point(20, 78);
            this.playerListDropDown.Name = "playerListDropDown";
            this.playerListDropDown.Size = new System.Drawing.Size(202, 33);
            this.playerListDropDown.TabIndex = 25;
            this.playerListDropDown.SelectedIndexChanged += new System.EventHandler(this.playerListDropDown_SelectedIndexChanged);
            // 
            // characterListDropDown
            // 
            this.characterListDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterListDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characterListDropDown.FormattingEnabled = true;
            this.characterListDropDown.Location = new System.Drawing.Point(243, 78);
            this.characterListDropDown.Name = "characterListDropDown";
            this.characterListDropDown.Size = new System.Drawing.Size(202, 33);
            this.characterListDropDown.TabIndex = 24;
            // 
            // addExistingCharacterToListButton
            // 
            this.addExistingCharacterToListButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addExistingCharacterToListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addExistingCharacterToListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addExistingCharacterToListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExistingCharacterToListButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addExistingCharacterToListButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.addExistingCharacterToListButton.Location = new System.Drawing.Point(460, 34);
            this.addExistingCharacterToListButton.Name = "addExistingCharacterToListButton";
            this.addExistingCharacterToListButton.Size = new System.Drawing.Size(205, 77);
            this.addExistingCharacterToListButton.TabIndex = 23;
            this.addExistingCharacterToListButton.Text = "Dodaj do listy";
            this.addExistingCharacterToListButton.UseVisualStyleBackColor = true;
            this.addExistingCharacterToListButton.Click += new System.EventHandler(this.addExistingCharacterToListButton_Click);
            // 
            // subtractTimeButton
            // 
            this.subtractTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.subtractTimeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.subtractTimeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subtractTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractTimeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtractTimeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subtractTimeButton.Location = new System.Drawing.Point(1055, 221);
            this.subtractTimeButton.Name = "subtractTimeButton";
            this.subtractTimeButton.Size = new System.Drawing.Size(52, 38);
            this.subtractTimeButton.TabIndex = 13;
            this.subtractTimeButton.Text = "-1";
            this.subtractTimeButton.UseVisualStyleBackColor = true;
            this.subtractTimeButton.Click += new System.EventHandler(this.subtractTimeButton_Click);
            // 
            // addTimeButton
            // 
            this.addTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addTimeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addTimeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTimeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTimeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTimeButton.Location = new System.Drawing.Point(997, 221);
            this.addTimeButton.Name = "addTimeButton";
            this.addTimeButton.Size = new System.Drawing.Size(52, 38);
            this.addTimeButton.TabIndex = 12;
            this.addTimeButton.Text = "+1";
            this.addTimeButton.UseVisualStyleBackColor = true;
            this.addTimeButton.Click += new System.EventHandler(this.addTimeButton_Click);
            // 
            // yearValue
            // 
            this.yearValue.Location = new System.Drawing.Point(812, 94);
            this.yearValue.Name = "yearValue";
            this.yearValue.Size = new System.Drawing.Size(72, 35);
            this.yearValue.TabIndex = 29;
            // 
            // monthValue
            // 
            this.monthValue.Location = new System.Drawing.Point(890, 94);
            this.monthValue.Name = "monthValue";
            this.monthValue.Size = new System.Drawing.Size(66, 35);
            this.monthValue.TabIndex = 30;
            // 
            // dayValue
            // 
            this.dayValue.Location = new System.Drawing.Point(962, 94);
            this.dayValue.Name = "dayValue";
            this.dayValue.Size = new System.Drawing.Size(71, 35);
            this.dayValue.TabIndex = 31;
            // 
            // changeDateButton
            // 
            this.changeDateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeDateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.changeDateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changeDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeDateButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.changeDateButton.Location = new System.Drawing.Point(1050, 89);
            this.changeDateButton.Name = "changeDateButton";
            this.changeDateButton.Size = new System.Drawing.Size(93, 40);
            this.changeDateButton.TabIndex = 32;
            this.changeDateButton.Text = "Zmień";
            this.changeDateButton.UseVisualStyleBackColor = true;
            this.changeDateButton.Click += new System.EventHandler(this.changeDateButton_Click);
            // 
            // timeIntervalsLabel
            // 
            this.timeIntervalsLabel.AutoSize = true;
            this.timeIntervalsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeIntervalsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.timeIntervalsLabel.Location = new System.Drawing.Point(814, 132);
            this.timeIntervalsLabel.Name = "timeIntervalsLabel";
            this.timeIntervalsLabel.Size = new System.Drawing.Size(186, 17);
            this.timeIntervalsLabel.TabIndex = 33;
            this.timeIntervalsLabel.Text = "Rok             Miesiąc       Dzień";
            // 
            // actualTimeOfDayLabel
            // 
            this.actualTimeOfDayLabel.AutoSize = true;
            this.actualTimeOfDayLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualTimeOfDayLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.actualTimeOfDayLabel.Location = new System.Drawing.Point(810, 172);
            this.actualTimeOfDayLabel.Name = "actualTimeOfDayLabel";
            this.actualTimeOfDayLabel.Size = new System.Drawing.Size(241, 37);
            this.actualTimeOfDayLabel.TabIndex = 34;
            this.actualTimeOfDayLabel.Text = "Aktualny czas dnia:";
            // 
            // GMTrackerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 914);
            this.Controls.Add(this.actualTimeOfDayLabel);
            this.Controls.Add(this.timeIntervalsLabel);
            this.Controls.Add(this.changeDateButton);
            this.Controls.Add(this.dayValue);
            this.Controls.Add(this.monthValue);
            this.Controls.Add(this.yearValue);
            this.Controls.Add(this.charactersGroupBox);
            this.Controls.Add(this.removeSelectedFightUnitsButton);
            this.Controls.Add(this.startFightButton);
            this.Controls.Add(this.fightingUnitsListBox);
            this.Controls.Add(this.pickUnitsLabel);
            this.Controls.Add(this.bodyNeedsButton);
            this.Controls.Add(this.eventHistoryButton);
            this.Controls.Add(this.subtractTimeButton);
            this.Controls.Add(this.addTimeButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.fightLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "GMTrackerUI";
            this.Text = "Panel Mistrza Gry";
            this.charactersGroupBox.ResumeLayout(false);
            this.charactersGroupBox.PerformLayout();
            this.addOldCharacterGroupBox.ResumeLayout(false);
            this.addOldCharacterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label fightLabel;
        private System.Windows.Forms.Label NPCLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button eventHistoryButton;
        private System.Windows.Forms.Button bodyNeedsButton;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.ListBox NpcListBox;
        private System.Windows.Forms.Button showEditCharacterButton;
        private System.Windows.Forms.Label pickUnitsLabel;
        private System.Windows.Forms.ListBox fightingUnitsListBox;
        private System.Windows.Forms.Button startFightButton;
        private System.Windows.Forms.Button addCharacterToFightButton;
        private System.Windows.Forms.Button removeSelectedFightUnitsButton;
        private System.Windows.Forms.GroupBox charactersGroupBox;
        private System.Windows.Forms.GroupBox addOldCharacterGroupBox;
        private System.Windows.Forms.ComboBox characterListDropDown;
        private System.Windows.Forms.Button addExistingCharacterToListButton;
        private System.Windows.Forms.Label choosingTableLabel;
        private System.Windows.Forms.RadioButton npcRadioButton;
        private System.Windows.Forms.RadioButton teamRadioButton;
        private System.Windows.Forms.Button makeNewCharacterButton;
        private System.Windows.Forms.Button removeCharacterButton;
        private System.Windows.Forms.ComboBox playerListDropDown;
        private System.Windows.Forms.Label pickPlayerLabel;
        private System.Windows.Forms.Label pickCharacterLabel;
        private System.Windows.Forms.Button subtractTimeButton;
        private System.Windows.Forms.Button addTimeButton;
        private System.Windows.Forms.TextBox yearValue;
        private System.Windows.Forms.TextBox monthValue;
        private System.Windows.Forms.TextBox dayValue;
        private System.Windows.Forms.Button changeDateButton;
        private System.Windows.Forms.Label timeIntervalsLabel;
        private System.Windows.Forms.Label actualTimeOfDayLabel;
    }
}