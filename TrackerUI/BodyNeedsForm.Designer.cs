namespace TrackerUI
{
    partial class BodyNeedsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BodyNeedsForm));
            this.bodyNeedsLabel = new System.Windows.Forms.Label();
            this.pickCharacterLabel = new System.Windows.Forms.Label();
            this.hungerLabel = new System.Windows.Forms.Label();
            this.thirstLabel = new System.Windows.Forms.Label();
            this.needForDrugsLabel = new System.Windows.Forms.Label();
            this.hungerValueLabel = new System.Windows.Forms.Label();
            this.thirstValueLabel = new System.Windows.Forms.Label();
            this.needForDrugsValueLabel = new System.Windows.Forms.Label();
            this.disclaimerLabel = new System.Windows.Forms.Label();
            this.hungerNewValueTextBox = new System.Windows.Forms.TextBox();
            this.thirstNewValueTextBox = new System.Windows.Forms.TextBox();
            this.needForDrugsNewValueTextBox = new System.Windows.Forms.TextBox();
            this.updateBodyNeedsButton = new System.Windows.Forms.Button();
            this.pickCharacterDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bodyNeedsLabel
            // 
            this.bodyNeedsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bodyNeedsLabel.AutoSize = true;
            this.bodyNeedsLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bodyNeedsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bodyNeedsLabel.Location = new System.Drawing.Point(103, 9);
            this.bodyNeedsLabel.Name = "bodyNeedsLabel";
            this.bodyNeedsLabel.Size = new System.Drawing.Size(363, 50);
            this.bodyNeedsLabel.TabIndex = 5;
            this.bodyNeedsLabel.Text = "Potrzeby fizjologiczne";
            // 
            // pickCharacterLabel
            // 
            this.pickCharacterLabel.AutoSize = true;
            this.pickCharacterLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pickCharacterLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pickCharacterLabel.Location = new System.Drawing.Point(12, 121);
            this.pickCharacterLabel.Name = "pickCharacterLabel";
            this.pickCharacterLabel.Size = new System.Drawing.Size(160, 30);
            this.pickCharacterLabel.TabIndex = 32;
            this.pickCharacterLabel.Text = "Wybierz postać:";
            // 
            // hungerLabel
            // 
            this.hungerLabel.AutoSize = true;
            this.hungerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hungerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hungerLabel.Location = new System.Drawing.Point(12, 183);
            this.hungerLabel.Name = "hungerLabel";
            this.hungerLabel.Size = new System.Drawing.Size(62, 30);
            this.hungerLabel.TabIndex = 33;
            this.hungerLabel.Text = "Głód:";
            // 
            // thirstLabel
            // 
            this.thirstLabel.AutoSize = true;
            this.thirstLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thirstLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.thirstLabel.Location = new System.Drawing.Point(12, 224);
            this.thirstLabel.Name = "thirstLabel";
            this.thirstLabel.Size = new System.Drawing.Size(116, 30);
            this.thirstLabel.TabIndex = 34;
            this.thirstLabel.Text = "Pragnienie:";
            // 
            // needForDrugsLabel
            // 
            this.needForDrugsLabel.AutoSize = true;
            this.needForDrugsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.needForDrugsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.needForDrugsLabel.Location = new System.Drawing.Point(12, 265);
            this.needForDrugsLabel.Name = "needForDrugsLabel";
            this.needForDrugsLabel.Size = new System.Drawing.Size(54, 30);
            this.needForDrugsLabel.TabIndex = 35;
            this.needForDrugsLabel.Text = "Leki:";
            // 
            // hungerValueLabel
            // 
            this.hungerValueLabel.AutoSize = true;
            this.hungerValueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hungerValueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hungerValueLabel.Location = new System.Drawing.Point(146, 183);
            this.hungerValueLabel.Name = "hungerValueLabel";
            this.hungerValueLabel.Size = new System.Drawing.Size(81, 30);
            this.hungerValueLabel.TabIndex = 36;
            this.hungerValueLabel.Text = "<brak>";
            // 
            // thirstValueLabel
            // 
            this.thirstValueLabel.AutoSize = true;
            this.thirstValueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thirstValueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.thirstValueLabel.Location = new System.Drawing.Point(146, 224);
            this.thirstValueLabel.Name = "thirstValueLabel";
            this.thirstValueLabel.Size = new System.Drawing.Size(81, 30);
            this.thirstValueLabel.TabIndex = 37;
            this.thirstValueLabel.Text = "<brak>";
            // 
            // needForDrugsValueLabel
            // 
            this.needForDrugsValueLabel.AutoSize = true;
            this.needForDrugsValueLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.needForDrugsValueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.needForDrugsValueLabel.Location = new System.Drawing.Point(146, 265);
            this.needForDrugsValueLabel.Name = "needForDrugsValueLabel";
            this.needForDrugsValueLabel.Size = new System.Drawing.Size(81, 30);
            this.needForDrugsValueLabel.TabIndex = 38;
            this.needForDrugsValueLabel.Text = "<brak>";
            // 
            // disclaimerLabel
            // 
            this.disclaimerLabel.AutoSize = true;
            this.disclaimerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.disclaimerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.disclaimerLabel.Location = new System.Drawing.Point(12, 354);
            this.disclaimerLabel.Name = "disclaimerLabel";
            this.disclaimerLabel.Size = new System.Drawing.Size(548, 25);
            this.disclaimerLabel.TabIndex = 39;
            this.disclaimerLabel.Text = "*Liczby oznaczają godziny od ostatniego zaspokojenia potrzeby";
            // 
            // hungerNewValueTextBox
            // 
            this.hungerNewValueTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hungerNewValueTextBox.Location = new System.Drawing.Point(264, 180);
            this.hungerNewValueTextBox.Name = "hungerNewValueTextBox";
            this.hungerNewValueTextBox.Size = new System.Drawing.Size(165, 33);
            this.hungerNewValueTextBox.TabIndex = 40;
            this.hungerNewValueTextBox.Text = "nowa wartość";
            // 
            // thirstNewValueTextBox
            // 
            this.thirstNewValueTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thirstNewValueTextBox.Location = new System.Drawing.Point(264, 221);
            this.thirstNewValueTextBox.Name = "thirstNewValueTextBox";
            this.thirstNewValueTextBox.Size = new System.Drawing.Size(165, 33);
            this.thirstNewValueTextBox.TabIndex = 41;
            this.thirstNewValueTextBox.Text = "nowa wartość";
            // 
            // needForDrugsNewValueTextBox
            // 
            this.needForDrugsNewValueTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.needForDrugsNewValueTextBox.Location = new System.Drawing.Point(264, 262);
            this.needForDrugsNewValueTextBox.Name = "needForDrugsNewValueTextBox";
            this.needForDrugsNewValueTextBox.Size = new System.Drawing.Size(165, 33);
            this.needForDrugsNewValueTextBox.TabIndex = 42;
            this.needForDrugsNewValueTextBox.Text = "nowa wartość";
            // 
            // updateBodyNeedsButton
            // 
            this.updateBodyNeedsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.updateBodyNeedsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.updateBodyNeedsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateBodyNeedsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBodyNeedsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateBodyNeedsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateBodyNeedsButton.Location = new System.Drawing.Point(435, 183);
            this.updateBodyNeedsButton.Name = "updateBodyNeedsButton";
            this.updateBodyNeedsButton.Size = new System.Drawing.Size(116, 112);
            this.updateBodyNeedsButton.TabIndex = 51;
            this.updateBodyNeedsButton.Text = "Aktualizuj potrzeby";
            this.updateBodyNeedsButton.UseVisualStyleBackColor = true;
            // 
            // pickCharacterDropDown
            // 
            this.pickCharacterDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pickCharacterDropDown.FormattingEnabled = true;
            this.pickCharacterDropDown.Location = new System.Drawing.Point(196, 122);
            this.pickCharacterDropDown.Name = "pickCharacterDropDown";
            this.pickCharacterDropDown.Size = new System.Drawing.Size(233, 29);
            this.pickCharacterDropDown.TabIndex = 52;
            // 
            // BodyNeedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 388);
            this.Controls.Add(this.pickCharacterDropDown);
            this.Controls.Add(this.updateBodyNeedsButton);
            this.Controls.Add(this.needForDrugsNewValueTextBox);
            this.Controls.Add(this.thirstNewValueTextBox);
            this.Controls.Add(this.hungerNewValueTextBox);
            this.Controls.Add(this.disclaimerLabel);
            this.Controls.Add(this.needForDrugsValueLabel);
            this.Controls.Add(this.thirstValueLabel);
            this.Controls.Add(this.hungerValueLabel);
            this.Controls.Add(this.needForDrugsLabel);
            this.Controls.Add(this.thirstLabel);
            this.Controls.Add(this.hungerLabel);
            this.Controls.Add(this.pickCharacterLabel);
            this.Controls.Add(this.bodyNeedsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BodyNeedsForm";
            this.Text = "Potrzeby fizjologiczne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bodyNeedsLabel;
        private System.Windows.Forms.Label pickCharacterLabel;
        private System.Windows.Forms.Label hungerLabel;
        private System.Windows.Forms.Label thirstLabel;
        private System.Windows.Forms.Label needForDrugsLabel;
        private System.Windows.Forms.Label hungerValueLabel;
        private System.Windows.Forms.Label thirstValueLabel;
        private System.Windows.Forms.Label needForDrugsValueLabel;
        private System.Windows.Forms.Label disclaimerLabel;
        private System.Windows.Forms.TextBox hungerNewValueTextBox;
        private System.Windows.Forms.TextBox thirstNewValueTextBox;
        private System.Windows.Forms.TextBox needForDrugsNewValueTextBox;
        private System.Windows.Forms.Button updateBodyNeedsButton;
        private System.Windows.Forms.ComboBox pickCharacterDropDown;
    }
}