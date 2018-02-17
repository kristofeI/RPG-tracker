﻿namespace TrackerUI
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
            this.weaponDamageLabel = new System.Windows.Forms.Label();
            this.weaponDamageValue = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
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
            this.addNewWeaponHeader.Location = new System.Drawing.Point(134, 9);
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
            this.addNewWeaponButton.ForeColor = System.Drawing.Color.OliveDrab;
            this.addNewWeaponButton.Location = new System.Drawing.Point(18, 273);
            this.addNewWeaponButton.Name = "addNewWeaponButton";
            this.addNewWeaponButton.Size = new System.Drawing.Size(490, 47);
            this.addNewWeaponButton.TabIndex = 69;
            this.addNewWeaponButton.Text = "Dodaj broń i wróć";
            this.addNewWeaponButton.UseVisualStyleBackColor = true;
            this.addNewWeaponButton.Click += new System.EventHandler(this.addNewWeaponButton_Click);
            // 
            // weaponDamageLabel
            // 
            this.weaponDamageLabel.AutoSize = true;
            this.weaponDamageLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weaponDamageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.weaponDamageLabel.Location = new System.Drawing.Point(12, 215);
            this.weaponDamageLabel.Name = "weaponDamageLabel";
            this.weaponDamageLabel.Size = new System.Drawing.Size(113, 30);
            this.weaponDamageLabel.TabIndex = 70;
            this.weaponDamageLabel.Text = "Obrażenia:";
            // 
            // weaponDamageValue
            // 
            this.weaponDamageValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weaponDamageValue.Location = new System.Drawing.Point(284, 210);
            this.weaponDamageValue.Name = "weaponDamageValue";
            this.weaponDamageValue.Size = new System.Drawing.Size(223, 35);
            this.weaponDamageValue.TabIndex = 71;
            this.weaponDamageValue.Text = "np. k4";
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.backButton.Location = new System.Drawing.Point(18, 338);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(490, 47);
            this.backButton.TabIndex = 72;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // AddNewWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(536, 409);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.weaponDamageValue);
            this.Controls.Add(this.weaponDamageLabel);
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
        private System.Windows.Forms.Label weaponDamageLabel;
        private System.Windows.Forms.TextBox weaponDamageValue;
        private System.Windows.Forms.Button backButton;
    }
}