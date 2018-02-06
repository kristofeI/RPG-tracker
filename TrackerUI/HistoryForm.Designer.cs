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
            this.eventHistoryLabel = new System.Windows.Forms.Label();
            this.timeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.fullDateLabel = new System.Windows.Forms.Label();
            this.historyListLabel = new System.Windows.Forms.Label();
            this.NPCLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.addNewEventButton = new System.Windows.Forms.Button();
            this.removeSelectedEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventHistoryLabel
            // 
            this.eventHistoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eventHistoryLabel.AutoSize = true;
            this.eventHistoryLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventHistoryLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.eventHistoryLabel.Location = new System.Drawing.Point(53, 20);
            this.eventHistoryLabel.Name = "eventHistoryLabel";
            this.eventHistoryLabel.Size = new System.Drawing.Size(299, 50);
            this.eventHistoryLabel.TabIndex = 4;
            this.eventHistoryLabel.Text = "Historia wydarzeń";
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
            // fullDateLabel
            // 
            this.fullDateLabel.AutoSize = true;
            this.fullDateLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fullDateLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fullDateLabel.Location = new System.Drawing.Point(153, 102);
            this.fullDateLabel.Name = "fullDateLabel";
            this.fullDateLabel.Size = new System.Drawing.Size(223, 37);
            this.fullDateLabel.TabIndex = 34;
            this.fullDateLabel.Text = "RRRR:MM:DD:HH";
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
            this.NPCLabel.Size = new System.Drawing.Size(227, 30);
            this.NPCLabel.TabIndex = 32;
            this.NPCLabel.Text = "Dodaj opis wydarzenia:";
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
            // addNewEventButton
            // 
            this.addNewEventButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addNewEventButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addNewEventButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewEventButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewEventButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewEventButton.Location = new System.Drawing.Point(17, 227);
            this.addNewEventButton.Name = "addNewEventButton";
            this.addNewEventButton.Size = new System.Drawing.Size(359, 49);
            this.addNewEventButton.TabIndex = 50;
            this.addNewEventButton.Text = "Dodaj wydarzenie";
            this.addNewEventButton.UseVisualStyleBackColor = true;
            this.addNewEventButton.Click += new System.EventHandler(this.addNewEventButton_Click);
            // 
            // removeSelectedEventButton
            // 
            this.removeSelectedEventButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeSelectedEventButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeSelectedEventButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeSelectedEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedEventButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSelectedEventButton.ForeColor = System.Drawing.Color.Red;
            this.removeSelectedEventButton.Location = new System.Drawing.Point(17, 565);
            this.removeSelectedEventButton.Name = "removeSelectedEventButton";
            this.removeSelectedEventButton.Size = new System.Drawing.Size(359, 73);
            this.removeSelectedEventButton.TabIndex = 49;
            this.removeSelectedEventButton.Text = "Usuń zaznaczoną umiejętność";
            this.removeSelectedEventButton.UseVisualStyleBackColor = true;
            this.removeSelectedEventButton.Click += new System.EventHandler(this.removeSelectedEventButton_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(398, 650);
            this.Controls.Add(this.addNewEventButton);
            this.Controls.Add(this.removeSelectedEventButton);
            this.Controls.Add(this.timeDescriptionTextBox);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.fullDateLabel);
            this.Controls.Add(this.historyListLabel);
            this.Controls.Add(this.NPCLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.eventHistoryLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "HistoryForm";
            this.Text = "Historia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventHistoryLabel;
        private System.Windows.Forms.TextBox timeDescriptionTextBox;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Label fullDateLabel;
        private System.Windows.Forms.Label historyListLabel;
        private System.Windows.Forms.Label NPCLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button addNewEventButton;
        private System.Windows.Forms.Button removeSelectedEventButton;
    }
}