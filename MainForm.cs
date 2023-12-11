
using ExamenInterfaces.http;
using ExamenInterfaces.utils;

namespace ExamenInterfaces
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeEvents();
        }
        public void InitializeEvents() {
            this.Load -= new System.EventHandler(LoadThisForm);
            this.FirstCombo.SelectedValueChanged -= new System.EventHandler(ComboValueChanged);
            this.SecondCombo.SelectedValueChanged -= new System.EventHandler(ComboValueChanged);
            this.ResetButton.Click -= new System.EventHandler(ResetClicked);
            this.CheckButton.Click -= new System.EventHandler(CheckClicked);
            this.UserItem.Click -= new System.EventHandler(Relaunch);
            this.AdminItem.Click -= new System.EventHandler(LaunchLogin);

            this.Load += new System.EventHandler(LoadThisForm);
            this.FirstCombo.SelectedValueChanged += new System.EventHandler(ComboValueChanged);
            this.SecondCombo.SelectedValueChanged += new System.EventHandler(ComboValueChanged);
            this.ResetButton.Click += new System.EventHandler(ResetClicked);
            this.CheckButton.Click += new System.EventHandler(CheckClicked);
            this.UserItem.Click += new System.EventHandler(Relaunch);
            this.AdminItem.Click += new System.EventHandler(LaunchLogin);
        }

        private void Relaunch(object? sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void LaunchLogin(object? sender, EventArgs e)
        {
            new Login().ShowDialog(this);
        }

        private async void CheckClicked(object? sender, EventArgs e)
        {
            if (this.FirstCombo.SelectedIndex > 0 && this.SecondCombo.SelectedIndex > 0) {
                var num = await ApiLoader.DoSomethingAsync(this.FirstTextBox.Text, this.SecondTextBox.Text);
                this.PercentageLabel.Text = num.ToString() + " %";
            }
        }

        private void ResetClicked(object? sender, EventArgs e)
        {
            this.FirstCombo.SelectedIndex = 0;
            this.SecondCombo.SelectedIndex = 0;
            this.FirstTextBox.Clear();
            this.SecondTextBox.Clear();
        }

        private void ComboValueChanged(object? sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox?? new();
            if (combo.SelectedIndex>0)
            {
                if (combo.Name.Equals("FirstCombo"))
                {
                    LoadTextField(true, (string)combo.SelectedItem);
                }
                else {
                    LoadTextField(false, (string)combo.SelectedItem);
                }
            }
        }

        private void LoadTextField(bool first, string path)
        {
            if (first)
            {
                this.FirstTextBox.Text = FileManager.GetFileContent(path);
            }
            else { 
                this.SecondTextBox.Text = FileManager.GetFileContent(path);
            }
        }

        private void LoadThisForm(object? sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            this.FirstCombo.Items.AddRange(FileManager.GetFilesInPath());
            this.SecondCombo.Items.AddRange(FileManager.GetFilesInPath());
        }

        public void LoadAdminView() {
            this.Controls.Remove(this.LeftPanel);
            this.Controls.Remove(this.RightPanel);
            this.Controls.Remove(this.BottomPanel);
            FlowLayoutPanel ItemContainer = new();
            ItemContainer.Dock = DockStyle.Fill;
            string[] files = FileManager.GetFilesInPath();
            for (int i = 0; i<files.Length; i++) {
                FlowLayoutPanel MiniPanel = new();
                MiniPanel.Name = files[i];
                MiniPanel.FlowDirection = FlowDirection.TopDown;
                MiniPanel.Size = new Size(100,100);
                MiniPanel.Margin = new Padding(0,50,0,0);
                Label Percentage = new();
                //int value = GetItemPercentage();
                Percentage.Text = "X %";
                Label FileName = new();
                FileName.Text = files[i];
                MiniPanel.Controls.Add(Percentage);
                MiniPanel.Controls.Add(FileName);
                MiniPanel.Click -= new System.EventHandler(AdminItemClicked);
                MiniPanel.Click += new System.EventHandler(AdminItemClicked);
                ItemContainer.Controls.Add(MiniPanel);
            }
            this.Controls.Add(ItemContainer);
        }

        private void AdminItemClicked(object? sender, EventArgs e)
        {
            FlowLayoutPanel clicked = sender as FlowLayoutPanel ?? new();
            MessageBox.Show(clicked.Name);
        }
    }
}