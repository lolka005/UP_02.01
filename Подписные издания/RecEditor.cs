using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBaseController;

namespace ЛР5
{
    public partial class RecEditor : Form
    {
        private string Login;
        private string Password;
        private int ID;
        private DB dB;
        public RecEditor(string login, string password)
        {
            InitializeComponent();
            Login = login;
            Password = password;
            button2.Visible = true;
            this.Text = "Добавление получателя";
            dB = new DB(Login, Password);
        }

        public RecEditor(string login, string password, int id)
        {
            InitializeComponent();
            Login = login;
            Password = password;
            ID = id;
            button1.Visible = true;
            this.Text = "Редактирование получателя";
            dB = new DB(Login, Password);
            List<string> data = dB.SelectOneRec(ID);
            textBox1.Text = data[0];
            textBox2.Text = data[1];
            textBox3.Text = data[2];
            textBox4.Text = data[3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sender == button1)
                dB.UpdateToRec(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, ID);
            else if (sender == button2)
                dB.InsertToRec(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            Close();
        }
    }
}
