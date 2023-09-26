using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBaseController;

namespace ЛР5
{
    public partial class Recievers : Form
    {
        private string Login;
        private string Password;
        private DB dB;
        private List<string>[] Dots;
        private int ChosenID;
        public Recievers(string login, string password)
        {
            InitializeComponent();
            this.Login = login;
            this.Password = password;
            dB = new DB(login, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button2)
                dB.DeleteFromRec(ChosenID);
            else if (sender == button1)
            {
                RecEditor editor = new RecEditor(Login, Password, ChosenID);
                editor.ShowDialog();
            }
            else if (sender == button3)
            {
                RecEditor editor = new RecEditor(Login, Password);
                editor.ShowDialog();
            }
            Recievers_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChosenID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            button1.Enabled = true;
        }

        private void Recievers_Load(object sender, EventArgs e)
        {
            Dots = dB.FillRec();
            dataGridView1.RowCount = Dots[0].Count;
            for (int i = 0; i < Dots[0].Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Dots[j][i];
                }
            }
        }
    }
}
