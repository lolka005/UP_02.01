using System;
using System.Windows.Forms;

namespace ЛР5
{
    public partial class MainMenu : Form
    {
        private string Login;
        private string Password;
        public MainMenu(string login, string password)
        {
            InitializeComponent();
            Login = login;
            Password = password;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Application.Restart();
            Environment.Exit(0);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (sender == subBtn)
            {
                Subscribes subs = new Subscribes(Login, Password);
                subs.ShowDialog();
            }
            else if (sender == authBtn) 
            {
                Authors authors = new Authors(Login, Password);
                authors.ShowDialog();
            }
            else if (sender == pubBtn)
            {
                Publications publications = new Publications(Login, Password);
                publications.ShowDialog();
            }
            else if (sender == recBtn)
            {
                Recievers recievers = new Recievers(Login, Password);
                recievers.ShowDialog();
            }
            else if (sender == logBtn)
            {
                Logs logs = new Logs(Login, Password);
                logs.ShowDialog();
            }
        }
    }
}