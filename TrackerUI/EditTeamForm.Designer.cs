namespace TrackerUI
{
    partial class EditTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeamForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.showCharacterDetailsButton = new System.Windows.Forms.Button();
            this.removeCharacterButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addOldCharacterGroupBox = new System.Windows.Forms.GroupBox();
            this.characterListDropDown = new System.Windows.Forms.ComboBox();
            this.makeNewCharacterButton = new System.Windows.Forms.Button();
            this.addOldCharacterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(195, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(254, 50);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Edytuj drużynę";
            // 
            // teamListBox
            // 
            this.teamListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.ItemHeight = 30;
            this.teamListBox.Location = new System.Drawing.Point(12, 91);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(316, 454);
            this.teamListBox.TabIndex = 17;
            // 
            // showCharacterDetailsButton
            // 
            this.showCharacterDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showCharacterDetailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.showCharacterDetailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showCharacterDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCharacterDetailsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showCharacterDetailsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.showCharacterDetailsButton.Location = new System.Drawing.Point(344, 91);
            this.showCharacterDetailsButton.Name = "showCharacterDetailsButton";
            this.showCharacterDetailsButton.Size = new System.Drawing.Size(240, 73);
            this.showCharacterDetailsButton.TabIndex = 21;
            this.showCharacterDetailsButton.Text = "Wyświetl szczegóły zaznaczonej postaci";
            this.showCharacterDetailsButton.UseVisualStyleBackColor = true;
            // 
            // removeCharacterButton
            // 
            this.removeCharacterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeCharacterButton.ForeColor = System.Drawing.Color.Red;
            this.removeCharacterButton.Location = new System.Drawing.Point(344, 472);
            this.removeCharacterButton.Name = "removeCharacterButton";
            this.removeCharacterButton.Size = new System.Drawing.Size(240, 73);
            this.removeCharacterButton.TabIndex = 22;
            this.removeCharacterButton.Text = "Usuń zaznaczoną postać";
            this.removeCharacterButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(6, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 45);
            this.button2.TabIndex = 23;
            this.button2.Text = "Dodaj do listy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addOldCharacterGroupBox
            // 
            this.addOldCharacterGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addOldCharacterGroupBox.Controls.Add(this.characterListDropDown);
            this.addOldCharacterGroupBox.Controls.Add(this.button2);
            this.addOldCharacterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOldCharacterGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addOldCharacterGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addOldCharacterGroupBox.Location = new System.Drawing.Point(344, 171);
            this.addOldCharacterGroupBox.Name = "addOldCharacterGroupBox";
            this.addOldCharacterGroupBox.Size = new System.Drawing.Size(240, 200);
            this.addOldCharacterGroupBox.TabIndex = 24;
            this.addOldCharacterGroupBox.TabStop = false;
            this.addOldCharacterGroupBox.Text = "Dodaj istniejącą postać";
            // 
            // characterListDropDown
            // 
            this.characterListDropDown.FormattingEnabled = true;
            this.characterListDropDown.Location = new System.Drawing.Point(6, 77);
            this.characterListDropDown.Name = "characterListDropDown";
            this.characterListDropDown.Size = new System.Drawing.Size(228, 38);
            this.characterListDropDown.TabIndex = 24;
            // 
            // makeNewCharacterButton
            // 
            this.makeNewCharacterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.makeNewCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.makeNewCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.makeNewCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeNewCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.makeNewCharacterButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.makeNewCharacterButton.Location = new System.Drawing.Point(344, 393);
            this.makeNewCharacterButton.Name = "makeNewCharacterButton";
            this.makeNewCharacterButton.Size = new System.Drawing.Size(240, 73);
            this.makeNewCharacterButton.TabIndex = 25;
            this.makeNewCharacterButton.Text = "Stwórz nową postać";
            this.makeNewCharacterButton.UseVisualStyleBackColor = true;
            // 
            // EditTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(657, 636);
            this.Controls.Add(this.makeNewCharacterButton);
            this.Controls.Add(this.addOldCharacterGroupBox);
            this.Controls.Add(this.removeCharacterButton);
            this.Controls.Add(this.showCharacterDetailsButton);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditTeamForm";
            this.Text = "Edytuj drużynę";
            this.addOldCharacterGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Button showCharacterDetailsButton;
        private System.Windows.Forms.Button removeCharacterButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox addOldCharacterGroupBox;
        private System.Windows.Forms.ComboBox characterListDropDown;
        private System.Windows.Forms.Button makeNewCharacterButton;
    }
}