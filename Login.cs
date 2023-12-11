using ExamenInterfaces.db;
using ExamenInterfaces.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenInterfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load -= new System.EventHandler(LoadForm);
            this.SubmitButton.Click -= new System.EventHandler(SubmitClicked);

            this.Load += new System.EventHandler(LoadForm);
            this.SubmitButton.Click += new System.EventHandler(SubmitClicked);
        }

        private void LoadForm(object? sender, EventArgs e)
        {
            UserLoader._instance.LoadListFromDatabase();
        }

        private void SubmitClicked(object? sender, EventArgs e)
        {
            if (this.UserTextBox.Text.Length == 0 || this.PasswordTextBox.Text.Length == 0) {
                MessageBox.Show("Debes introducir texto","ERROR",MessageBoxButtons.OK);
            }
            else if (SubmitOkay(this.UserTextBox.Text, this.PasswordTextBox.Text)) {
                MainForm window = this.Owner as MainForm ?? new();
                window.LoadAdminView();
                this.Hide();
            }
        }

        private bool SubmitOkay(string username, string pass) {
            User? user = UserLoader._instance.Users.GetUserByData(username, pass);
            if (user == null) {
                MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK);
                return false; 
            }
            return true;
        }
    }
}
