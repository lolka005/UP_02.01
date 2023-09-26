using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBaseController;

namespace ЛР5
{
    public partial class AuthEditor : Form
    {
        private string Login;
        private string Password;
        private int ID;
        private DB dB;
        public AuthEditor(string login, string password)
        {
            InitializeComponent();
            Login = login;
            Password = password;
            button2.Visible = true;
            this.Text = "Добавление автора";
            dB = new DB(Login, Password);
        }

        public AuthEditor(string login, string password, int id)
        {
            InitializeComponent();
            Login = login;
            Password = password;
            ID = id;
            button1.Visible = true;
            this.Text = "Редактирование автора";
            dB = new DB(Login, Password);
            List<string> data = dB.SelectOneAuth(ID);
            textBox1.Text = data[0];
            textBox2.Text = data[1];
            textBox3.Text = data[2];
            textBox4.Text = data[3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sender == button1)
                dB.UpdateToAuth(ID, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            else if (sender == button2)
                dB.InsertToAuth(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            Close();
        }
    }
}