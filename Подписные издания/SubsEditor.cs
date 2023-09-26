using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBaseController;

namespace ЛР5
{
    public partial class SubsEditor : Form
    {
        private string Login;
        private string Password;
        private int ID;
        private DB dB;

        public SubsEditor(string login, string password)
        {
            InitializeComponent();
            Login = login;
            Password = password;
            button2.Visible = true;
            this.Text = "Добавление подписки";
            dB = new DB(Login, Password);
        }

        public SubsEditor(string login, string password, int id)
        {
            InitializeComponent();
            Login = login;
            Password = password;
            ID = id;
            button1.Visible = true;
            this.Text = "Редактирование подписки";
            dB = new DB(Login, Password);
            List<string> data = dB.SelectOneSub(ID);
            comboBox1.Text = data[0];
            comboBox2.Text = data[1];
            textBox4.Text = data[2];
            textBox5.Text = data[3];
            textBox6.Text = data[4];
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == comboBox1 || sender == comboBox2)
            {
                e.Handled = true;            
            }
            else
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sender == button1)
                dB.UpdateToSubs(ID, int.Parse(comboBox1.Text),int.Parse(comboBox2.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            else if (sender == button2)
                dB.InsertToSubs(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            Close();
        }

        private void SubsEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            e.Cancel = true;
        }

        private void SubsEditor_Load(object sender, EventArgs e)
        {
            List<string> Index = dB.SelectAllIndex();
            List<string> IDs = dB.SelectAllRecID();
            foreach (string item in Index)
            {
                comboBox2.Items.Add(item);
            }
            foreach (string item in IDs)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}