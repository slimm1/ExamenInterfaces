namespace ExamenInterfaces
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopMenu = new MenuStrip();
            UserItem = new ToolStripMenuItem();
            AdminItem = new ToolStripMenuItem();
            LeftPanel = new FlowLayoutPanel();
            FirstCombo = new ComboBox();
            FirstTextBox = new RichTextBox();
            RightPanel = new FlowLayoutPanel();
            SecondCombo = new ComboBox();
            SecondTextBox = new RichTextBox();
            BottomPanel = new FlowLayoutPanel();
            CheckButton = new Button();
            PercentageLabel = new Label();
            ResetButton = new Button();
            TopMenu.SuspendLayout();
            LeftPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenu
            // 
            TopMenu.Items.AddRange(new ToolStripItem[] { UserItem, AdminItem });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Size = new Size(913, 24);
            TopMenu.TabIndex = 0;
            TopMenu.Text = "TopMenu";
            // 
            // UserItem
            // 
            UserItem.Name = "UserItem";
            UserItem.Size = new Size(42, 20);
            UserItem.Text = "User";
            // 
            // AdminItem
            // 
            AdminItem.Name = "AdminItem";
            AdminItem.Size = new Size(55, 20);
            AdminItem.Text = "Admin";
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(FirstCombo);
            LeftPanel.Controls.Add(FirstTextBox);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.FlowDirection = FlowDirection.TopDown;
            LeftPanel.Location = new Point(0, 24);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(444, 476);
            LeftPanel.TabIndex = 2;
            // 
            // FirstCombo
            // 
            FirstCombo.FormattingEnabled = true;
            FirstCombo.Location = new Point(150, 20);
            FirstCombo.Margin = new Padding(150, 20, 3, 3);
            FirstCombo.Name = "FirstCombo";
            FirstCombo.Size = new Size(171, 23);
            FirstCombo.TabIndex = 0;
            // 
            // FirstTextBox
            // 
            FirstTextBox.Location = new Point(100, 66);
            FirstTextBox.Margin = new Padding(100, 20, 3, 3);
            FirstTextBox.Name = "FirstTextBox";
            FirstTextBox.Size = new Size(298, 373);
            FirstTextBox.TabIndex = 1;
            FirstTextBox.Text = "";
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(SecondCombo);
            RightPanel.Controls.Add(SecondTextBox);
            RightPanel.Dock = DockStyle.Right;
            RightPanel.Location = new Point(445, 24);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(468, 476);
            RightPanel.TabIndex = 3;
            // 
            // SecondCombo
            // 
            SecondCombo.FormattingEnabled = true;
            SecondCombo.Location = new Point(150, 20);
            SecondCombo.Margin = new Padding(150, 20, 3, 3);
            SecondCombo.Name = "SecondCombo";
            SecondCombo.Size = new Size(171, 23);
            SecondCombo.TabIndex = 2;
            // 
            // SecondTextBox
            // 
            SecondTextBox.Location = new Point(100, 66);
            SecondTextBox.Margin = new Padding(100, 20, 3, 3);
            SecondTextBox.Name = "SecondTextBox";
            SecondTextBox.Size = new Size(298, 373);
            SecondTextBox.TabIndex = 3;
            SecondTextBox.Text = "";
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(CheckButton);
            BottomPanel.Controls.Add(PercentageLabel);
            BottomPanel.Controls.Add(ResetButton);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 500);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(913, 87);
            BottomPanel.TabIndex = 1;
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(200, 10);
            CheckButton.Margin = new Padding(200, 10, 3, 3);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(101, 58);
            CheckButton.TabIndex = 0;
            CheckButton.Text = "Check";
            CheckButton.UseVisualStyleBackColor = true;
            // 
            // PercentageLabel
            // 
            PercentageLabel.AutoSize = true;
            PercentageLabel.Location = new Point(454, 20);
            PercentageLabel.Margin = new Padding(150, 20, 3, 0);
            PercentageLabel.Name = "PercentageLabel";
            PercentageLabel.Size = new Size(17, 15);
            PercentageLabel.TabIndex = 1;
            PercentageLabel.Text = "%";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(654, 10);
            ResetButton.Margin = new Padding(180, 10, 3, 3);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(102, 58);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 587);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Controls.Add(BottomPanel);
            Controls.Add(TopMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = TopMenu;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Turnitin";
            TopMenu.ResumeLayout(false);
            TopMenu.PerformLayout();
            LeftPanel.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TopMenu;
        private ToolStripMenuItem UserItem;
        private ToolStripMenuItem AdminItem;
        private FlowLayoutPanel LeftPanel;
        private FlowLayoutPanel RightPanel;
        private FlowLayoutPanel BottomPanel;
        private Button CheckButton;
        private Label PercentageLabel;
        private Button ResetButton;
        private ComboBox FirstCombo;
        private RichTextBox FirstTextBox;
        private ComboBox SecondCombo;
        private RichTextBox SecondTextBox;
    }
}