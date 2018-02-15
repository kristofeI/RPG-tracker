namespace TrackerUI
{
    partial class BattleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.fightHeader = new System.Windows.Forms.Label();
            this.charactersInBattleListBox = new System.Windows.Forms.ListBox();
            this.charactersInFightLabel = new System.Windows.Forms.Label();
            this.actualRoundLabel = new System.Windows.Forms.Label();
            this.actualRoundValueLabel = new System.Windows.Forms.Label();
            this.addRoundButton = new System.Windows.Forms.Button();
            this.selectedCharacterStatsLabel = new System.Windows.Forms.Label();
            this.initiativeLabel = new System.Windows.Forms.Label();
            this.actionThisRoundLabel = new System.Windows.Forms.Label();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.enduranceLabel = new System.Windows.Forms.Label();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.woundsLabel = new System.Windows.Forms.Label();
            this.exhaustionLabel = new System.Windows.Forms.Label();
            this.shockLabel = new System.Windows.Forms.Label();
            this.bleedingLabel = new System.Windows.Forms.Label();
            this.actionThisRoundDropDown = new System.Windows.Forms.ComboBox();
            this.cardDropDown = new System.Windows.Forms.ComboBox();
            this.changeStatsAndBackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tempoValueLabel = new System.Windows.Forms.Label();
            this.defenseValueLabel = new System.Windows.Forms.Label();
            this.enduranceValueLabel = new System.Windows.Forms.Label();
            this.charismaValueLabel = new System.Windows.Forms.Label();
            this.skillsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDropDown = new System.Windows.Forms.ComboBox();
            this.weaponDropDown = new System.Windows.Forms.ComboBox();
            this.woundsValueDropDown = new System.Windows.Forms.ComboBox();
            this.exhaustionValueDropDown = new System.Windows.Forms.ComboBox();
            this.shockValueDropDown = new System.Windows.Forms.ComboBox();
            this.bleedingValueDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fightHeader
            // 
            this.fightHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fightHeader.AutoSize = true;
            this.fightHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fightHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fightHeader.Location = new System.Drawing.Point(547, 9);
            this.fightHeader.Name = "fightHeader";
            this.fightHeader.Size = new System.Drawing.Size(113, 50);
            this.fightHeader.TabIndex = 6;
            this.fightHeader.Text = "Walka";
            // 
            // charactersInBattleListBox
            // 
            this.charactersInBattleListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.charactersInBattleListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charactersInBattleListBox.FormattingEnabled = true;
            this.charactersInBattleListBox.ItemHeight = 25;
            this.charactersInBattleListBox.Location = new System.Drawing.Point(12, 217);
            this.charactersInBattleListBox.Name = "charactersInBattleListBox";
            this.charactersInBattleListBox.Size = new System.Drawing.Size(565, 204);
            this.charactersInBattleListBox.TabIndex = 36;
            this.charactersInBattleListBox.SelectedIndexChanged += new System.EventHandler(this.charactersInBattleListBox_SelectedIndexChanged);
            // 
            // charactersInFightLabel
            // 
            this.charactersInFightLabel.AutoSize = true;
            this.charactersInFightLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charactersInFightLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.charactersInFightLabel.Location = new System.Drawing.Point(12, 161);
            this.charactersInFightLabel.Name = "charactersInFightLabel";
            this.charactersInFightLabel.Size = new System.Drawing.Size(151, 30);
            this.charactersInFightLabel.TabIndex = 37;
            this.charactersInFightLabel.Text = "Tabela postaci:";
            // 
            // actualRoundLabel
            // 
            this.actualRoundLabel.AutoSize = true;
            this.actualRoundLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualRoundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.actualRoundLabel.Location = new System.Drawing.Point(12, 93);
            this.actualRoundLabel.Name = "actualRoundLabel";
            this.actualRoundLabel.Size = new System.Drawing.Size(124, 30);
            this.actualRoundLabel.TabIndex = 39;
            this.actualRoundLabel.Text = "Numer tury:";
            // 
            // actualRoundValueLabel
            // 
            this.actualRoundValueLabel.AutoSize = true;
            this.actualRoundValueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualRoundValueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.actualRoundValueLabel.Location = new System.Drawing.Point(142, 93);
            this.actualRoundValueLabel.Name = "actualRoundValueLabel";
            this.actualRoundValueLabel.Size = new System.Drawing.Size(24, 30);
            this.actualRoundValueLabel.TabIndex = 40;
            this.actualRoundValueLabel.Text = "1";
            // 
            // addRoundButton
            // 
            this.addRoundButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addRoundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addRoundButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addRoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoundButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addRoundButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addRoundButton.Location = new System.Drawing.Point(187, 89);
            this.addRoundButton.Name = "addRoundButton";
            this.addRoundButton.Size = new System.Drawing.Size(52, 38);
            this.addRoundButton.TabIndex = 41;
            this.addRoundButton.Text = "+1";
            this.addRoundButton.UseVisualStyleBackColor = true;
            this.addRoundButton.Click += new System.EventHandler(this.addRoundButton_Click);
            // 
            // selectedCharacterStatsLabel
            // 
            this.selectedCharacterStatsLabel.AutoSize = true;
            this.selectedCharacterStatsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedCharacterStatsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectedCharacterStatsLabel.Location = new System.Drawing.Point(15, 436);
            this.selectedCharacterStatsLabel.Name = "selectedCharacterStatsLabel";
            this.selectedCharacterStatsLabel.Size = new System.Drawing.Size(298, 30);
            this.selectedCharacterStatsLabel.TabIndex = 43;
            this.selectedCharacterStatsLabel.Text = "Statystyki zaznaczonej postaci ";
            // 
            // initiativeLabel
            // 
            this.initiativeLabel.AutoSize = true;
            this.initiativeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.initiativeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.initiativeLabel.Location = new System.Drawing.Point(6, 478);
            this.initiativeLabel.Name = "initiativeLabel";
            this.initiativeLabel.Size = new System.Drawing.Size(110, 30);
            this.initiativeLabel.TabIndex = 44;
            this.initiativeLabel.Text = "Inicjatywa:";
            // 
            // actionThisRoundLabel
            // 
            this.actionThisRoundLabel.AutoSize = true;
            this.actionThisRoundLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionThisRoundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.actionThisRoundLabel.Location = new System.Drawing.Point(406, 477);
            this.actionThisRoundLabel.Name = "actionThisRoundLabel";
            this.actionThisRoundLabel.Size = new System.Drawing.Size(171, 30);
            this.actionThisRoundLabel.TabIndex = 45;
            this.actionThisRoundLabel.Text = "Akcja w tej turze:";
            // 
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tempoLabel.Location = new System.Drawing.Point(900, 342);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(82, 30);
            this.tempoLabel.TabIndex = 47;
            this.tempoLabel.Text = "Tempo:";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defenseLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.defenseLabel.Location = new System.Drawing.Point(900, 392);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(88, 30);
            this.defenseLabel.TabIndex = 48;
            this.defenseLabel.Text = "Obrona:";
            // 
            // enduranceLabel
            // 
            this.enduranceLabel.AutoSize = true;
            this.enduranceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enduranceLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.enduranceLabel.Location = new System.Drawing.Point(900, 437);
            this.enduranceLabel.Name = "enduranceLabel";
            this.enduranceLabel.Size = new System.Drawing.Size(148, 30);
            this.enduranceLabel.TabIndex = 49;
            this.enduranceLabel.Text = "Wytrzymałość:";
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charismaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.charismaLabel.Location = new System.Drawing.Point(900, 481);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(110, 30);
            this.charismaLabel.TabIndex = 50;
            this.charismaLabel.Text = "Charyzma:";
            // 
            // woundsLabel
            // 
            this.woundsLabel.AutoSize = true;
            this.woundsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.woundsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.woundsLabel.Location = new System.Drawing.Point(6, 518);
            this.woundsLabel.Name = "woundsLabel";
            this.woundsLabel.Size = new System.Drawing.Size(64, 30);
            this.woundsLabel.TabIndex = 51;
            this.woundsLabel.Text = "Rany:";
            // 
            // exhaustionLabel
            // 
            this.exhaustionLabel.AutoSize = true;
            this.exhaustionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exhaustionLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.exhaustionLabel.Location = new System.Drawing.Point(164, 518);
            this.exhaustionLabel.Name = "exhaustionLabel";
            this.exhaustionLabel.Size = new System.Drawing.Size(137, 30);
            this.exhaustionLabel.TabIndex = 52;
            this.exhaustionLabel.Text = "Wyczerpanie:";
            // 
            // shockLabel
            // 
            this.shockLabel.AutoSize = true;
            this.shockLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shockLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.shockLabel.Location = new System.Drawing.Point(418, 537);
            this.shockLabel.Name = "shockLabel";
            this.shockLabel.Size = new System.Drawing.Size(61, 30);
            this.shockLabel.TabIndex = 53;
            this.shockLabel.Text = "Szok:";
            // 
            // bleedingLabel
            // 
            this.bleedingLabel.AutoSize = true;
            this.bleedingLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bleedingLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bleedingLabel.Location = new System.Drawing.Point(583, 535);
            this.bleedingLabel.Name = "bleedingLabel";
            this.bleedingLabel.Size = new System.Drawing.Size(122, 30);
            this.bleedingLabel.TabIndex = 54;
            this.bleedingLabel.Text = "Krwawienie:";
            // 
            // actionThisRoundDropDown
            // 
            this.actionThisRoundDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionThisRoundDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionThisRoundDropDown.FormattingEnabled = true;
            this.actionThisRoundDropDown.Location = new System.Drawing.Point(583, 479);
            this.actionThisRoundDropDown.Name = "actionThisRoundDropDown";
            this.actionThisRoundDropDown.Size = new System.Drawing.Size(144, 29);
            this.actionThisRoundDropDown.TabIndex = 66;
            this.actionThisRoundDropDown.SelectedIndexChanged += new System.EventHandler(this.actionThisRoundDropDown_SelectedIndexChanged);
            // 
            // cardDropDown
            // 
            this.cardDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cardDropDown.FormattingEnabled = true;
            this.cardDropDown.Location = new System.Drawing.Point(122, 478);
            this.cardDropDown.Name = "cardDropDown";
            this.cardDropDown.Size = new System.Drawing.Size(128, 29);
            this.cardDropDown.TabIndex = 67;
            this.cardDropDown.SelectedIndexChanged += new System.EventHandler(this.cardDropDown_SelectedIndexChanged);
            // 
            // changeStatsAndBackButton
            // 
            this.changeStatsAndBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeStatsAndBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.changeStatsAndBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changeStatsAndBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatsAndBackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeStatsAndBackButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.changeStatsAndBackButton.Location = new System.Drawing.Point(694, 648);
            this.changeStatsAndBackButton.Name = "changeStatsAndBackButton";
            this.changeStatsAndBackButton.Size = new System.Drawing.Size(480, 47);
            this.changeStatsAndBackButton.TabIndex = 68;
            this.changeStatsAndBackButton.Text = "Zatwierdź zmiany i wróć do panelu głównego";
            this.changeStatsAndBackButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(15, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 69;
            this.label2.Text = "Broń:";
            // 
            // tempoValueLabel
            // 
            this.tempoValueLabel.AutoSize = true;
            this.tempoValueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempoValueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tempoValueLabel.Location = new System.Drawing.Point(988, 342);
            this.tempoValueLabel.Name = "tempoValueLabel";
            this.tempoValueLabel.Size = new System.Drawing.Size(41, 30);
            this.tempoValueLabel.TabIndex = 73;
            this.tempoValueLabel.Text = "<>";
            // 
            // defenseValueLabel
            // 
            this.defenseValueLabel.AutoSize = true;
            this.defenseValueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defenseValueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.defenseValueLabel.Location = new System.Drawing.Point(988, 392);
            this.defenseValueLabel.Name = "defenseValueLabel";
            this.defenseValueLabel.Size = new System.Drawing.Size(41, 30);
            this.defenseValueLabel.TabIndex = 74;
            this.defenseValueLabel.Text = "<>";
            // 
            // enduranceValueLabel
            // 
            this.enduranceValueLabel.AutoSize = true;
            this.enduranceValueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enduranceValueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.enduranceValueLabel.Location = new System.Drawing.Point(1054, 437);
            this.enduranceValueLabel.Name = "enduranceValueLabel";
            this.enduranceValueLabel.Size = new System.Drawing.Size(41, 30);
            this.enduranceValueLabel.TabIndex = 75;
            this.enduranceValueLabel.Text = "<>";
            // 
            // charismaValueLabel
            // 
            this.charismaValueLabel.AutoSize = true;
            this.charismaValueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charismaValueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.charismaValueLabel.Location = new System.Drawing.Point(1016, 482);
            this.charismaValueLabel.Name = "charismaValueLabel";
            this.charismaValueLabel.Size = new System.Drawing.Size(41, 30);
            this.charismaValueLabel.TabIndex = 76;
            this.charismaValueLabel.Text = "<>";
            // 
            // skillsListBox
            // 
            this.skillsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skillsListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skillsListBox.FormattingEnabled = true;
            this.skillsListBox.ItemHeight = 25;
            this.skillsListBox.Location = new System.Drawing.Point(805, 122);
            this.skillsListBox.Name = "skillsListBox";
            this.skillsListBox.Size = new System.Drawing.Size(358, 204);
            this.skillsListBox.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(800, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 30);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tabela umiejętności wybranej postaci:";
            // 
            // colorDropDown
            // 
            this.colorDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorDropDown.FormattingEnabled = true;
            this.colorDropDown.Location = new System.Drawing.Point(256, 478);
            this.colorDropDown.Name = "colorDropDown";
            this.colorDropDown.Size = new System.Drawing.Size(128, 29);
            this.colorDropDown.TabIndex = 79;
            this.colorDropDown.SelectedIndexChanged += new System.EventHandler(this.colorDropDown_SelectedIndexChanged);
            // 
            // weaponDropDown
            // 
            this.weaponDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weaponDropDown.FormattingEnabled = true;
            this.weaponDropDown.Location = new System.Drawing.Point(85, 647);
            this.weaponDropDown.Name = "weaponDropDown";
            this.weaponDropDown.Size = new System.Drawing.Size(264, 29);
            this.weaponDropDown.TabIndex = 80;
            this.weaponDropDown.SelectedIndexChanged += new System.EventHandler(this.weaponDropDown_SelectedIndexChanged);
            // 
            // woundsValueDropDown
            // 
            this.woundsValueDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.woundsValueDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.woundsValueDropDown.FormattingEnabled = true;
            this.woundsValueDropDown.Location = new System.Drawing.Point(73, 519);
            this.woundsValueDropDown.Name = "woundsValueDropDown";
            this.woundsValueDropDown.Size = new System.Drawing.Size(63, 29);
            this.woundsValueDropDown.TabIndex = 86;
            this.woundsValueDropDown.SelectedIndexChanged += new System.EventHandler(this.woundsValueDropDown_SelectedIndexChanged);
            // 
            // exhaustionValueDropDown
            // 
            this.exhaustionValueDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exhaustionValueDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exhaustionValueDropDown.FormattingEnabled = true;
            this.exhaustionValueDropDown.Location = new System.Drawing.Point(298, 519);
            this.exhaustionValueDropDown.Name = "exhaustionValueDropDown";
            this.exhaustionValueDropDown.Size = new System.Drawing.Size(63, 29);
            this.exhaustionValueDropDown.TabIndex = 87;
            this.exhaustionValueDropDown.SelectedIndexChanged += new System.EventHandler(this.exhaustionValueDropDown_SelectedIndexChanged);
            // 
            // shockValueDropDown
            // 
            this.shockValueDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shockValueDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shockValueDropDown.FormattingEnabled = true;
            this.shockValueDropDown.Location = new System.Drawing.Point(485, 536);
            this.shockValueDropDown.Name = "shockValueDropDown";
            this.shockValueDropDown.Size = new System.Drawing.Size(63, 29);
            this.shockValueDropDown.TabIndex = 88;
            this.shockValueDropDown.SelectedIndexChanged += new System.EventHandler(this.shockValueDropDown_SelectedIndexChanged);
            // 
            // bleedingValueDropDown
            // 
            this.bleedingValueDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bleedingValueDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bleedingValueDropDown.FormattingEnabled = true;
            this.bleedingValueDropDown.Location = new System.Drawing.Point(707, 536);
            this.bleedingValueDropDown.Name = "bleedingValueDropDown";
            this.bleedingValueDropDown.Size = new System.Drawing.Size(63, 29);
            this.bleedingValueDropDown.TabIndex = 89;
            this.bleedingValueDropDown.SelectedIndexChanged += new System.EventHandler(this.bleedingValueDropDown_SelectedIndexChanged);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1204, 706);
            this.Controls.Add(this.bleedingValueDropDown);
            this.Controls.Add(this.shockValueDropDown);
            this.Controls.Add(this.exhaustionValueDropDown);
            this.Controls.Add(this.woundsValueDropDown);
            this.Controls.Add(this.weaponDropDown);
            this.Controls.Add(this.colorDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skillsListBox);
            this.Controls.Add(this.charismaValueLabel);
            this.Controls.Add(this.enduranceValueLabel);
            this.Controls.Add(this.defenseValueLabel);
            this.Controls.Add(this.tempoValueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeStatsAndBackButton);
            this.Controls.Add(this.cardDropDown);
            this.Controls.Add(this.actionThisRoundDropDown);
            this.Controls.Add(this.bleedingLabel);
            this.Controls.Add(this.shockLabel);
            this.Controls.Add(this.exhaustionLabel);
            this.Controls.Add(this.woundsLabel);
            this.Controls.Add(this.charismaLabel);
            this.Controls.Add(this.enduranceLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.tempoLabel);
            this.Controls.Add(this.actionThisRoundLabel);
            this.Controls.Add(this.initiativeLabel);
            this.Controls.Add(this.selectedCharacterStatsLabel);
            this.Controls.Add(this.addRoundButton);
            this.Controls.Add(this.actualRoundValueLabel);
            this.Controls.Add(this.actualRoundLabel);
            this.Controls.Add(this.charactersInFightLabel);
            this.Controls.Add(this.charactersInBattleListBox);
            this.Controls.Add(this.fightHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BattleForm";
            this.Text = "Walka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fightHeader;
        private System.Windows.Forms.ListBox charactersInBattleListBox;
        private System.Windows.Forms.Label charactersInFightLabel;
        private System.Windows.Forms.Label actualRoundLabel;
        private System.Windows.Forms.Label actualRoundValueLabel;
        private System.Windows.Forms.Button addRoundButton;
        private System.Windows.Forms.Label selectedCharacterStatsLabel;
        private System.Windows.Forms.Label initiativeLabel;
        private System.Windows.Forms.Label actionThisRoundLabel;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label enduranceLabel;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.Label woundsLabel;
        private System.Windows.Forms.Label exhaustionLabel;
        private System.Windows.Forms.Label shockLabel;
        private System.Windows.Forms.Label bleedingLabel;
        private System.Windows.Forms.ComboBox actionThisRoundDropDown;
        private System.Windows.Forms.ComboBox cardDropDown;
        private System.Windows.Forms.Button changeStatsAndBackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tempoValueLabel;
        private System.Windows.Forms.Label defenseValueLabel;
        private System.Windows.Forms.Label enduranceValueLabel;
        private System.Windows.Forms.Label charismaValueLabel;
        private System.Windows.Forms.ListBox skillsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox colorDropDown;
        private System.Windows.Forms.ComboBox weaponDropDown;
        private System.Windows.Forms.ComboBox woundsValueDropDown;
        private System.Windows.Forms.ComboBox exhaustionValueDropDown;
        private System.Windows.Forms.ComboBox shockValueDropDown;
        private System.Windows.Forms.ComboBox bleedingValueDropDown;
    }
}