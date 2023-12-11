namespace ExamenInterfaces
{
    partial class Login
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
            MainPanel = new FlowLayoutPanel();
            UserLabel = new Label();
            UserTextBox = new TextBox();
            PassLabel = new Label();
            PasswordTextBox = new TextBox();
            SubmitButton = new Button();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(UserLabel);
            MainPanel.Controls.Add(UserTextBox);
            MainPanel.Controls.Add(PassLabel);
            MainPanel.Controls.Add(PasswordTextBox);
            MainPanel.Controls.Add(SubmitButton);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(321, 366);
            MainPanel.TabIndex = 0;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(50, 50);
            UserLabel.Margin = new Padding(50, 50, 3, 0);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(30, 15);
            UserLabel.TabIndex = 0;
            UserLabel.Text = "User";
            // 
            // UserTextBox
            // 
            UserTextBox.Location = new Point(86, 50);
            UserTextBox.Margin = new Padding(3, 50, 3, 3);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(174, 23);
            UserTextBox.TabIndex = 1;
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Location = new Point(50, 126);
            PassLabel.Margin = new Padding(50, 50, 3, 0);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(57, 15);
            PassLabel.TabIndex = 2;
            PassLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(113, 126);
            PasswordTextBox.Margin = new Padding(3, 50, 3, 3);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(147, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(120, 202);
            SubmitButton.Margin = new Padding(120, 50, 3, 3);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(89, 62);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 366);
            Controls.Add(MainPanel);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel MainPanel;
        private Label UserLabel;
        private TextBox UserTextBox;
        private Label PassLabel;
        private TextBox PasswordTextBox;
        private Button SubmitButton;
    }
}