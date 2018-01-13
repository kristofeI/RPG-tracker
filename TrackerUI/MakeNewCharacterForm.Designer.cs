namespace TrackerUI
{
    partial class MakeNewCharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeNewCharacterForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.makeCharacterAndBackButton = new System.Windows.Forms.Button();
            this.characterNameValue = new System.Windows.Forms.TextBox();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerDropDown = new System.Windows.Forms.ComboBox();
            this.makeCharacterAndEditButton = new System.Windows.Forms.Button();
            this.createNewPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerEmailValue = new System.Windows.Forms.TextBox();
            this.playerEmailLabel = new System.Windows.Forms.Label();
            this.playerNameValue = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.createNewPlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(69, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(470, 50);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Stwórz nową postać lub NPC";
            // 
            // makeCharacterAndBackButton
            // 
            this.makeCharacterAndBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.makeCharacterAndBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.makeCharacterAndBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.makeCharacterAndBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeCharacterAndBackButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.makeCharacterAndBackButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.makeCharacterAndBackButton.Location = new System.Drawing.Point(40, 441);
            this.makeCharacterAndBackButton.Name = "makeCharacterAndBackButton";
            this.makeCharacterAndBackButton.Size = new System.Drawing.Size(525, 63);
            this.makeCharacterAndBackButton.TabIndex = 48;
            this.makeCharacterAndBackButton.Text = "Stwórz postać i wróć do menu głównego";
            this.makeCharacterAndBackButton.UseVisualStyleBackColor = true;
            this.makeCharacterAndBackButton.Click += new System.EventHandler(this.makeCharacterAndBackButton_Click);
            // 
            // characterNameValue
            // 
            this.characterNameValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characterNameValue.Location = new System.Drawing.Point(316, 101);
            this.characterNameValue.Name = "characterNameValue";
            this.characterNameValue.Size = new System.Drawing.Size(249, 33);
            this.characterNameValue.TabIndex = 51;
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characterNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.characterNameLabel.Location = new System.Drawing.Point(35, 109);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(138, 25);
            this.characterNameLabel.TabIndex = 49;
            this.characterNameLabel.Text = "Nazwa postaci:";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playerLabel.Location = new System.Drawing.Point(35, 153);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(252, 25);
            this.playerLabel.TabIndex = 50;
            this.playerLabel.Text = "Wybierz istniejącego gracza:";
            // 
            // playerDropDown
            // 
            this.playerDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerDropDown.FormattingEnabled = true;
            this.playerDropDown.Location = new System.Drawing.Point(316, 145);
            this.playerDropDown.Name = "playerDropDown";
            this.playerDropDown.Size = new System.Drawing.Size(249, 33);
            this.playerDropDown.TabIndex = 52;
            // 
            // makeCharacterAndEditButton
            // 
            this.makeCharacterAndEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.makeCharacterAndEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.makeCharacterAndEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.makeCharacterAndEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeCharacterAndEditButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.makeCharacterAndEditButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.makeCharacterAndEditButton.Location = new System.Drawing.Point(40, 510);
            this.makeCharacterAndEditButton.Name = "makeCharacterAndEditButton";
            this.makeCharacterAndEditButton.Size = new System.Drawing.Size(525, 63);
            this.makeCharacterAndEditButton.TabIndex = 53;
            this.makeCharacterAndEditButton.Text = "Stwórz postać i uzupełnij pozostałe statystyki";
            this.makeCharacterAndEditButton.UseVisualStyleBackColor = true;
            this.makeCharacterAndEditButton.Click += new System.EventHandler(this.makeCharacterAndEditButton_Click);
            // 
            // createNewPlayerGroupBox
            // 
            this.createNewPlayerGroupBox.Controls.Add(this.playerEmailValue);
            this.createNewPlayerGroupBox.Controls.Add(this.playerEmailLabel);
            this.createNewPlayerGroupBox.Controls.Add(this.playerNameValue);
            this.createNewPlayerGroupBox.Controls.Add(this.playerNameLabel);
            this.createNewPlayerGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewPlayerGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewPlayerGroupBox.Location = new System.Drawing.Point(40, 204);
            this.createNewPlayerGroupBox.Name = "createNewPlayerGroupBox";
            this.createNewPlayerGroupBox.Size = new System.Drawing.Size(525, 143);
            this.createNewPlayerGroupBox.TabIndex = 54;
            this.createNewPlayerGroupBox.TabStop = false;
            this.createNewPlayerGroupBox.Text = "...lub dodaj nowego gracza";
            // 
            // playerEmailValue
            // 
            this.playerEmailValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerEmailValue.Location = new System.Drawing.Point(270, 75);
            this.playerEmailValue.Name = "playerEmailValue";
            this.playerEmailValue.Size = new System.Drawing.Size(249, 33);
            this.playerEmailValue.TabIndex = 55;
            // 
            // playerEmailLabel
            // 
            this.playerEmailLabel.AutoSize = true;
            this.playerEmailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerEmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playerEmailLabel.Location = new System.Drawing.Point(6, 83);
            this.playerEmailLabel.Name = "playerEmailLabel";
            this.playerEmailLabel.Size = new System.Drawing.Size(239, 25);
            this.playerEmailLabel.TabIndex = 54;
            this.playerEmailLabel.Text = "Adres e-mail (opcjonalnie):";
            // 
            // playerNameValue
            // 
            this.playerNameValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNameValue.Location = new System.Drawing.Point(270, 32);
            this.playerNameValue.Name = "playerNameValue";
            this.playerNameValue.Size = new System.Drawing.Size(249, 33);
            this.playerNameValue.TabIndex = 53;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playerNameLabel.Location = new System.Drawing.Point(6, 40);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(134, 25);
            this.playerNameLabel.TabIndex = 52;
            this.playerNameLabel.Text = "Nazwa gracza:";
            // 
            // MakeNewCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(594, 595);
            this.Controls.Add(this.createNewPlayerGroupBox);
            this.Controls.Add(this.makeCharacterAndEditButton);
            this.Controls.Add(this.playerDropDown);
            this.Controls.Add(this.characterNameValue);
            this.Controls.Add(this.characterNameLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.makeCharacterAndBackButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MakeNewCharacterForm";
            this.Text = "Stwórz nową postać";
            this.createNewPlayerGroupBox.ResumeLayout(false);
            this.createNewPlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button makeCharacterAndBackButton;
        private System.Windows.Forms.TextBox characterNameValue;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.ComboBox playerDropDown;
        private System.Windows.Forms.Button makeCharacterAndEditButton;
        private System.Windows.Forms.GroupBox createNewPlayerGroupBox;
        private System.Windows.Forms.TextBox playerEmailValue;
        private System.Windows.Forms.Label playerEmailLabel;
        private System.Windows.Forms.TextBox playerNameValue;
        private System.Windows.Forms.Label playerNameLabel;
    }
}