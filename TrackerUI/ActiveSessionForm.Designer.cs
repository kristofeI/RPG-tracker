namespace TrackerUI
{
    partial class ActiveSessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveSessionForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.sessionNameLabel = new System.Windows.Forms.Label();
            this.actualSessionNameLabel = new System.Windows.Forms.Label();
            this.newSessionNameLabel = new System.Windows.Forms.Label();
            this.newSessionNameTextBox = new System.Windows.Forms.TextBox();
            this.newSessionNameButton = new System.Windows.Forms.Button();
            this.removeSessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(99, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(235, 50);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Aktywna sesja";
            // 
            // sessionNameLabel
            // 
            this.sessionNameLabel.AutoSize = true;
            this.sessionNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sessionNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sessionNameLabel.Location = new System.Drawing.Point(22, 94);
            this.sessionNameLabel.Name = "sessionNameLabel";
            this.sessionNameLabel.Size = new System.Drawing.Size(103, 37);
            this.sessionNameLabel.TabIndex = 3;
            this.sessionNameLabel.Text = "Nazwa:";
            // 
            // actualSessionNameLabel
            // 
            this.actualSessionNameLabel.AutoSize = true;
            this.actualSessionNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualSessionNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.actualSessionNameLabel.Location = new System.Drawing.Point(131, 94);
            this.actualSessionNameLabel.Name = "actualSessionNameLabel";
            this.actualSessionNameLabel.Size = new System.Drawing.Size(105, 37);
            this.actualSessionNameLabel.TabIndex = 4;
            this.actualSessionNameLabel.Text = "<brak>";
            // 
            // newSessionNameLabel
            // 
            this.newSessionNameLabel.AutoSize = true;
            this.newSessionNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newSessionNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newSessionNameLabel.Location = new System.Drawing.Point(94, 150);
            this.newSessionNameLabel.Name = "newSessionNameLabel";
            this.newSessionNameLabel.Size = new System.Drawing.Size(215, 25);
            this.newSessionNameLabel.TabIndex = 5;
            this.newSessionNameLabel.Text = "Podaj nową nazwę sesji:";
            // 
            // newSessionNameTextBox
            // 
            this.newSessionNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newSessionNameTextBox.Location = new System.Drawing.Point(29, 178);
            this.newSessionNameTextBox.Name = "newSessionNameTextBox";
            this.newSessionNameTextBox.Size = new System.Drawing.Size(356, 33);
            this.newSessionNameTextBox.TabIndex = 6;
            // 
            // newSessionNameButton
            // 
            this.newSessionNameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newSessionNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.newSessionNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newSessionNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSessionNameButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newSessionNameButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newSessionNameButton.Location = new System.Drawing.Point(29, 217);
            this.newSessionNameButton.Name = "newSessionNameButton";
            this.newSessionNameButton.Size = new System.Drawing.Size(356, 41);
            this.newSessionNameButton.TabIndex = 7;
            this.newSessionNameButton.Text = "Zmień nazwę";
            this.newSessionNameButton.UseVisualStyleBackColor = true;
            // 
            // removeSessionButton
            // 
            this.removeSessionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeSessionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeSessionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSessionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSessionButton.ForeColor = System.Drawing.Color.Red;
            this.removeSessionButton.Location = new System.Drawing.Point(29, 315);
            this.removeSessionButton.Name = "removeSessionButton";
            this.removeSessionButton.Size = new System.Drawing.Size(356, 38);
            this.removeSessionButton.TabIndex = 8;
            this.removeSessionButton.Text = "Usuń sesję";
            this.removeSessionButton.UseVisualStyleBackColor = true;
            // 
            // ActiveSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(418, 365);
            this.Controls.Add(this.removeSessionButton);
            this.Controls.Add(this.newSessionNameButton);
            this.Controls.Add(this.newSessionNameTextBox);
            this.Controls.Add(this.newSessionNameLabel);
            this.Controls.Add(this.actualSessionNameLabel);
            this.Controls.Add(this.sessionNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ActiveSessionForm";
            this.Text = "Aktywna sesja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label sessionNameLabel;
        private System.Windows.Forms.Label actualSessionNameLabel;
        private System.Windows.Forms.Label newSessionNameLabel;
        private System.Windows.Forms.TextBox newSessionNameTextBox;
        private System.Windows.Forms.Button newSessionNameButton;
        private System.Windows.Forms.Button removeSessionButton;
    }
}