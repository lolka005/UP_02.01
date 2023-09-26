using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBaseController;

namespace ЛР5
{
    public partial class Logs : Form
    {
        private string UserLogin;
        private string Password;
        private DB dB;
        private List<string>[] Dots;
        private int ChosenID;
        public Logs(string login, string password)
        {
            InitializeComponent();
            this.UserLogin = login;
            this.Password = password;
            dB = new DB(login, password);
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            try
            {
                Dots = dB.ShowLog();
                dataGridView1.RowCount = Dots[0].Count;
                for (int i = 0; i < Dots[0].Count; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = Dots[j][i];
                    }
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dB.ClearLogs();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }
    }
}
