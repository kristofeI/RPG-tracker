namespace TrackerUI
{
    partial class SystemRPG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemRPG));
            this.headerLabel = new System.Windows.Forms.Label();
            this.systemName = new System.Windows.Forms.Label();
            this.systemDropDown = new System.Windows.Forms.ComboBox();
            this.systemButton = new System.Windows.Forms.Button();
            this.addNewSessionButton = new System.Windows.Forms.Button();
            this.newSessionTextBox = new System.Windows.Forms.TextBox();
            this.newSessionLabel = new System.Windows.Forms.Label();
            this.sessionEditButton = new System.Windows.Forms.Button();
            this.sessionDropDown = new System.Windows.Forms.ComboBox();
            this.activeSessionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(25, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(215, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "System RPG:";
            // 
            // systemName
            // 
            this.systemName.AutoSize = true;
            this.systemName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.systemName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.systemName.Location = new System.Drawing.Point(246, 27);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(137, 50);
            this.systemName.TabIndex = 1;
            this.systemName.Text = "<brak>";
            // 
            // systemDropDown
            // 
            this.systemDropDown.FormattingEnabled = true;
            this.systemDropDown.Location = new System.Drawing.Point(34, 108);
            this.systemDropDown.Name = "systemDropDown";
            this.systemDropDown.Size = new System.Drawing.Size(318, 38);
            this.systemDropDown.TabIndex = 2;
            // 
            // systemButton
            // 
            this.systemButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.systemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.systemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.systemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.systemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.systemButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.systemButton.Location = new System.Drawing.Point(34, 168);
            this.systemButton.Name = "systemButton";
            this.systemButton.Size = new System.Drawing.Size(318, 54);
            this.systemButton.TabIndex = 3;
            this.systemButton.Text = "Wybierz system";
            this.systemButton.UseVisualStyleBackColor = true;
            // 
            // addNewSessionButton
            // 
            this.addNewSessionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addNewSessionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addNewSessionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewSessionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewSessionButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewSessionButton.Location = new System.Drawing.Point(205, 422);
            this.addNewSessionButton.Name = "addNewSessionButton";
            this.addNewSessionButton.Size = new System.Drawing.Size(147, 54);
            this.addNewSessionButton.TabIndex = 37;
            this.addNewSessionButton.Text = "Dodaj";
            this.addNewSessionButton.UseVisualStyleBackColor = true;
            // 
            // newSessionTextBox
            // 
            this.newSessionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newSessionTextBox.Location = new System.Drawing.Point(34, 450);
            this.newSessionTextBox.Name = "newSessionTextBox";
            this.newSessionTextBox.Size = new System.Drawing.Size(165, 25);
            this.newSessionTextBox.TabIndex = 36;
            this.newSessionTextBox.Text = "Wpisz nazwę nowej sesji";
            // 
            // newSessionLabel
            // 
            this.newSessionLabel.AutoSize = true;
            this.newSessionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newSessionLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newSessionLabel.Location = new System.Drawing.Point(29, 422);
            this.newSessionLabel.Name = "newSessionLabel";
            this.newSessionLabel.Size = new System.Drawing.Size(170, 25);
            this.newSessionLabel.TabIndex = 35;
            this.newSessionLabel.Text = "Stwórz nową sesję:";
            // 
            // sessionEditButton
            // 
            this.sessionEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sessionEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.sessionEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sessionEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sessionEditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sessionEditButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sessionEditButton.Location = new System.Drawing.Point(32, 371);
            this.sessionEditButton.Name = "sessionEditButton";
            this.sessionEditButton.Size = new System.Drawing.Size(318, 37);
            this.sessionEditButton.TabIndex = 34;
            this.sessionEditButton.Text = "Edytuj sesję";
            this.sessionEditButton.UseVisualStyleBackColor = true;
            // 
            // sessionDropDown
            // 
            this.sessionDropDown.FormattingEnabled = true;
            this.sessionDropDown.Location = new System.Drawing.Point(34, 321);
            this.sessionDropDown.Name = "sessionDropDown";
            this.sessionDropDown.Size = new System.Drawing.Size(318, 38);
            this.sessionDropDown.TabIndex = 33;
            // 
            // activeSessionLabel
            // 
            this.activeSessionLabel.AutoSize = true;
            this.activeSessionLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activeSessionLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.activeSessionLabel.Location = new System.Drawing.Point(27, 277);
            this.activeSessionLabel.Name = "activeSessionLabel";
            this.activeSessionLabel.Size = new System.Drawing.Size(188, 37);
            this.activeSessionLabel.TabIndex = 32;
            this.activeSessionLabel.Text = "Aktywna sesja:";
            // 
            // SystemRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(451, 596);
            this.Controls.Add(this.addNewSessionButton);
            this.Controls.Add(this.newSessionTextBox);
            this.Controls.Add(this.newSessionLabel);
            this.Controls.Add(this.sessionEditButton);
            this.Controls.Add(this.sessionDropDown);
            this.Controls.Add(this.activeSessionLabel);
            this.Controls.Add(this.systemButton);
            this.Controls.Add(this.systemDropDown);
            this.Controls.Add(this.systemName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SystemRPG";
            this.Text = "System RPG";
            this.Load += new System.EventHandler(this.RPGSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label systemName;
        private System.Windows.Forms.ComboBox systemDropDown;
        private System.Windows.Forms.Button systemButton;
        private System.Windows.Forms.Button addNewSessionButton;
        private System.Windows.Forms.TextBox newSessionTextBox;
        private System.Windows.Forms.Label newSessionLabel;
        private System.Windows.Forms.Button sessionEditButton;
        private System.Windows.Forms.ComboBox sessionDropDown;
        private System.Windows.Forms.Label activeSessionLabel;
    }
}

