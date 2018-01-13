namespace TrackerUI
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.historyLabel = new System.Windows.Forms.Label();
            this.timeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.historyListLabel = new System.Windows.Forms.Label();
            this.NPCLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.addNewTimeDescriptionButton = new System.Windows.Forms.Button();
            this.removeTimeDescriptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyLabel
            // 
            this.historyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.historyLabel.Location = new System.Drawing.Point(122, 9);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(139, 50);
            this.historyLabel.TabIndex = 4;
            this.historyLabel.Text = "Historia";
            // 
            // timeDescriptionTextBox
            // 
            this.timeDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeDescriptionTextBox.Location = new System.Drawing.Point(17, 188);
            this.timeDescriptionTextBox.Name = "timeDescriptionTextBox";
            this.timeDescriptionTextBox.Size = new System.Drawing.Size(359, 33);
            this.timeDescriptionTextBox.TabIndex = 36;
            // 
            // historyListBox
            // 
            this.historyListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 30;
            this.historyListBox.Location = new System.Drawing.Point(17, 345);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(359, 214);
            this.historyListBox.TabIndex = 35;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateLabel.Location = new System.Drawing.Point(153, 101);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(223, 37);
            this.dateLabel.TabIndex = 34;
            this.dateLabel.Text = "RRRR:MM:DD:HH";
            // 
            // historyListLabel
            // 
            this.historyListLabel.AutoSize = true;
            this.historyListLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyListLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.historyListLabel.Location = new System.Drawing.Point(12, 312);
            this.historyListLabel.Name = "historyListLabel";
            this.historyListLabel.Size = new System.Drawing.Size(89, 30);
            this.historyListLabel.TabIndex = 33;
            this.historyListLabel.Text = "Historia:";
            // 
            // NPCLabel
            // 
            this.NPCLabel.AutoSize = true;
            this.NPCLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NPCLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NPCLabel.Location = new System.Drawing.Point(12, 155);
            this.NPCLabel.Name = "NPCLabel";
            this.NPCLabel.Size = new System.Drawing.Size(275, 30);
            this.NPCLabel.TabIndex = 32;
            this.NPCLabel.Text = "Dodaj opis podanego czasu:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.timeLabel.Location = new System.Drawing.Point(12, 108);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(135, 30);
            this.timeLabel.TabIndex = 31;
            this.timeLabel.Text = "Obecny czas:";
            // 
            // addNewTimeDescriptionButton
            // 
            this.addNewTimeDescriptionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addNewTimeDescriptionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addNewTimeDescriptionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewTimeDescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewTimeDescriptionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewTimeDescriptionButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewTimeDescriptionButton.Location = new System.Drawing.Point(17, 227);
            this.addNewTimeDescriptionButton.Name = "addNewTimeDescriptionButton";
            this.addNewTimeDescriptionButton.Size = new System.Drawing.Size(359, 49);
            this.addNewTimeDescriptionButton.TabIndex = 50;
            this.addNewTimeDescriptionButton.Text = "Dodaj opis do historii";
            this.addNewTimeDescriptionButton.UseVisualStyleBackColor = true;
            // 
            // removeTimeDescriptionButton
            // 
            this.removeTimeDescriptionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeTimeDescriptionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeTimeDescriptionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeTimeDescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTimeDescriptionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeTimeDescriptionButton.ForeColor = System.Drawing.Color.Red;
            this.removeTimeDescriptionButton.Location = new System.Drawing.Point(17, 565);
            this.removeTimeDescriptionButton.Name = "removeTimeDescriptionButton";
            this.removeTimeDescriptionButton.Size = new System.Drawing.Size(359, 73);
            this.removeTimeDescriptionButton.TabIndex = 49;
            this.removeTimeDescriptionButton.Text = "Usuń zaznaczoną umiejętność";
            this.removeTimeDescriptionButton.UseVisualStyleBackColor = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(398, 650);
            this.Controls.Add(this.addNewTimeDescriptionButton);
            this.Controls.Add(this.removeTimeDescriptionButton);
            this.Controls.Add(this.timeDescriptionTextBox);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.historyListLabel);
            this.Controls.Add(this.NPCLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.historyLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "HistoryForm";
            this.Text = "Historia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.TextBox timeDescriptionTextBox;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label historyListLabel;
        private System.Windows.Forms.Label NPCLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button addNewTimeDescriptionButton;
        private System.Windows.Forms.Button removeTimeDescriptionButton;
    }
}