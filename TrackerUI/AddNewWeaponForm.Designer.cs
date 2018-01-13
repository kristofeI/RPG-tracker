namespace TrackerUI
{
    partial class AddNewWeaponForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewWeaponForm));
            this.ammoSupplyValue = new System.Windows.Forms.TextBox();
            this.ammoSupplyLabel = new System.Windows.Forms.Label();
            this.weaponNameLabel = new System.Windows.Forms.Label();
            this.weaponNameValue = new System.Windows.Forms.TextBox();
            this.addNewWeaponHeader = new System.Windows.Forms.Label();
            this.addNewWeaponButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ammoSupplyValue
            // 
            this.ammoSupplyValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ammoSupplyValue.Location = new System.Drawing.Point(285, 169);
            this.ammoSupplyValue.Name = "ammoSupplyValue";
            this.ammoSupplyValue.Size = new System.Drawing.Size(223, 35);
            this.ammoSupplyValue.TabIndex = 55;
            // 
            // ammoSupplyLabel
            // 
            this.ammoSupplyLabel.AutoSize = true;
            this.ammoSupplyLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ammoSupplyLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ammoSupplyLabel.Location = new System.Drawing.Point(12, 175);
            this.ammoSupplyLabel.Name = "ammoSupplyLabel";
            this.ammoSupplyLabel.Size = new System.Drawing.Size(105, 30);
            this.ammoSupplyLabel.TabIndex = 52;
            this.ammoSupplyLabel.Text = "Amunicja:";
            // 
            // weaponNameLabel
            // 
            this.weaponNameLabel.AutoSize = true;
            this.weaponNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weaponNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.weaponNameLabel.Location = new System.Drawing.Point(12, 134);
            this.weaponNameLabel.Name = "weaponNameLabel";
            this.weaponNameLabel.Size = new System.Drawing.Size(81, 30);
            this.weaponNameLabel.TabIndex = 50;
            this.weaponNameLabel.Text = "Nazwa:";
            // 
            // weaponNameValue
            // 
            this.weaponNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weaponNameValue.Location = new System.Drawing.Point(285, 128);
            this.weaponNameValue.Name = "weaponNameValue";
            this.weaponNameValue.Size = new System.Drawing.Size(223, 35);
            this.weaponNameValue.TabIndex = 49;
            // 
            // addNewWeaponHeader
            // 
            this.addNewWeaponHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addNewWeaponHeader.AutoSize = true;
            this.addNewWeaponHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewWeaponHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewWeaponHeader.Location = new System.Drawing.Point(150, 9);
            this.addNewWeaponHeader.Name = "addNewWeaponHeader";
            this.addNewWeaponHeader.Size = new System.Drawing.Size(292, 50);
            this.addNewWeaponHeader.TabIndex = 57;
            this.addNewWeaponHeader.Text = "Dodaj nową broń";
            // 
            // addNewWeaponButton
            // 
            this.addNewWeaponButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addNewWeaponButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addNewWeaponButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewWeaponButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewWeaponButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewWeaponButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewWeaponButton.Location = new System.Drawing.Point(17, 225);
            this.addNewWeaponButton.Name = "addNewWeaponButton";
            this.addNewWeaponButton.Size = new System.Drawing.Size(490, 47);
            this.addNewWeaponButton.TabIndex = 69;
            this.addNewWeaponButton.Text = "Dodaj";
            this.addNewWeaponButton.UseVisualStyleBackColor = true;
            this.addNewWeaponButton.Click += new System.EventHandler(this.addNewWeaponButton_Click);
            // 
            // AddNewWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 341);
            this.Controls.Add(this.addNewWeaponButton);
            this.Controls.Add(this.addNewWeaponHeader);
            this.Controls.Add(this.ammoSupplyValue);
            this.Controls.Add(this.ammoSupplyLabel);
            this.Controls.Add(this.weaponNameLabel);
            this.Controls.Add(this.weaponNameValue);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddNewWeaponForm";
            this.Text = "Dodaj nową broń";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ammoSupplyValue;
        private System.Windows.Forms.Label ammoSupplyLabel;
        private System.Windows.Forms.Label weaponNameLabel;
        private System.Windows.Forms.TextBox weaponNameValue;
        private System.Windows.Forms.Label addNewWeaponHeader;
        private System.Windows.Forms.Button addNewWeaponButton;
    }
}