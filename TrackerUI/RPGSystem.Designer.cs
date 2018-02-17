namespace TrackerUI
{
    partial class RPGSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPGSystem));
            this.headerLabel = new System.Windows.Forms.Label();
            this.systemDropDown = new System.Windows.Forms.ComboBox();
            this.campaignAddButton = new System.Windows.Forms.Button();
            this.newCampaignTextBox = new System.Windows.Forms.TextBox();
            this.newCampaignLabel = new System.Windows.Forms.Label();
            this.campaignRemoveButton = new System.Windows.Forms.Button();
            this.campaignDropDown = new System.Windows.Forms.ComboBox();
            this.currentCampaignLabel = new System.Windows.Forms.Label();
            this.loadCampaignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(96, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(215, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "System RPG:";
            // 
            // systemDropDown
            // 
            this.systemDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemDropDown.FormattingEnabled = true;
            this.systemDropDown.Location = new System.Drawing.Point(52, 104);
            this.systemDropDown.Name = "systemDropDown";
            this.systemDropDown.Size = new System.Drawing.Size(318, 38);
            this.systemDropDown.TabIndex = 2;
            this.systemDropDown.SelectedIndexChanged += new System.EventHandler(this.systemDropDown_SelectedIndexChanged);
            // 
            // campaignAddButton
            // 
            this.campaignAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.campaignAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.campaignAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campaignAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campaignAddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.campaignAddButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.campaignAddButton.Location = new System.Drawing.Point(52, 231);
            this.campaignAddButton.Name = "campaignAddButton";
            this.campaignAddButton.Size = new System.Drawing.Size(318, 35);
            this.campaignAddButton.TabIndex = 37;
            this.campaignAddButton.Text = "Dodaj do listy";
            this.campaignAddButton.UseVisualStyleBackColor = true;
            this.campaignAddButton.Click += new System.EventHandler(this.campaignAddButton_Click);
            // 
            // newCampaignTextBox
            // 
            this.newCampaignTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCampaignTextBox.Location = new System.Drawing.Point(52, 200);
            this.newCampaignTextBox.Name = "newCampaignTextBox";
            this.newCampaignTextBox.Size = new System.Drawing.Size(318, 25);
            this.newCampaignTextBox.TabIndex = 36;
            this.newCampaignTextBox.Text = "Wpisz nazwę nowej kampanii";
            this.newCampaignTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newCampaignLabel
            // 
            this.newCampaignLabel.AutoSize = true;
            this.newCampaignLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCampaignLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newCampaignLabel.Location = new System.Drawing.Point(100, 172);
            this.newCampaignLabel.Name = "newCampaignLabel";
            this.newCampaignLabel.Size = new System.Drawing.Size(211, 25);
            this.newCampaignLabel.TabIndex = 35;
            this.newCampaignLabel.Text = "Stwórz nową kampanię:";
            // 
            // campaignRemoveButton
            // 
            this.campaignRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.campaignRemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.campaignRemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campaignRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campaignRemoveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.campaignRemoveButton.ForeColor = System.Drawing.Color.Red;
            this.campaignRemoveButton.Location = new System.Drawing.Point(52, 544);
            this.campaignRemoveButton.Name = "campaignRemoveButton";
            this.campaignRemoveButton.Size = new System.Drawing.Size(318, 40);
            this.campaignRemoveButton.TabIndex = 34;
            this.campaignRemoveButton.Text = "Usuń zaznaczoną kampanię";
            this.campaignRemoveButton.UseVisualStyleBackColor = true;
            this.campaignRemoveButton.Click += new System.EventHandler(this.campaignRemoveButton_Click);
            // 
            // campaignDropDown
            // 
            this.campaignDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campaignDropDown.FormattingEnabled = true;
            this.campaignDropDown.Location = new System.Drawing.Point(52, 357);
            this.campaignDropDown.Name = "campaignDropDown";
            this.campaignDropDown.Size = new System.Drawing.Size(318, 38);
            this.campaignDropDown.TabIndex = 33;
            // 
            // currentCampaignLabel
            // 
            this.currentCampaignLabel.AutoSize = true;
            this.currentCampaignLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentCampaignLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentCampaignLabel.Location = new System.Drawing.Point(45, 307);
            this.currentCampaignLabel.Name = "currentCampaignLabel";
            this.currentCampaignLabel.Size = new System.Drawing.Size(350, 37);
            this.currentCampaignLabel.TabIndex = 32;
            this.currentCampaignLabel.Text = "Wybierz aktualną kampanię:";
            // 
            // loadCampaignButton
            // 
            this.loadCampaignButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loadCampaignButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.loadCampaignButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadCampaignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadCampaignButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadCampaignButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadCampaignButton.Location = new System.Drawing.Point(52, 413);
            this.loadCampaignButton.Name = "loadCampaignButton";
            this.loadCampaignButton.Size = new System.Drawing.Size(318, 73);
            this.loadCampaignButton.TabIndex = 38;
            this.loadCampaignButton.Text = "Załaduj zaznaczoną kampanię";
            this.loadCampaignButton.UseVisualStyleBackColor = true;
            this.loadCampaignButton.Click += new System.EventHandler(this.loadCampaignButton_Click);
            // 
            // RPGSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(429, 596);
            this.Controls.Add(this.loadCampaignButton);
            this.Controls.Add(this.campaignAddButton);
            this.Controls.Add(this.newCampaignTextBox);
            this.Controls.Add(this.newCampaignLabel);
            this.Controls.Add(this.campaignRemoveButton);
            this.Controls.Add(this.campaignDropDown);
            this.Controls.Add(this.currentCampaignLabel);
            this.Controls.Add(this.systemDropDown);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "RPGSystem";
            this.Text = "System RPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox systemDropDown;
        private System.Windows.Forms.Button campaignAddButton;
        private System.Windows.Forms.TextBox newCampaignTextBox;
        private System.Windows.Forms.Label newCampaignLabel;
        private System.Windows.Forms.Button campaignRemoveButton;
        private System.Windows.Forms.ComboBox campaignDropDown;
        private System.Windows.Forms.Label currentCampaignLabel;
        private System.Windows.Forms.Button loadCampaignButton;
    }
}

