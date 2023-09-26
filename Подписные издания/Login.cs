using System;
using System.Drawing;
using System.Windows.Forms;
using DataBaseController;

namespace ЛР5
{
    public partial class Login : Form
    {

        private int Count = 0; 
        private string Captcha;
        private DB dB;
        int tik = 1;
        public Login()
        {
            InitializeComponent();
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };
            Graphics g = Graphics.FromImage(result);
            g.Clear(Color.Gray);
            Captcha = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                Captcha += ALF[rnd.Next(ALF.Length)];
            g.DrawString(Captcha,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dB = new DB(textBox1.Text, textBox2.Text);
            if (!dB.CanOpen())
            {
                dB.AddLog(textBox1.Text, DateTime.Now, "Denied");
                MessageBox.Show("Доступ запрещён!");
                ErrorEnter(Count);
            }
            else
            {
                if (pictureBox1.Visible)
                {
                    if (Captcha != textBox3.Text)
                    {
                        dB.AddLog(textBox1.Text, DateTime.Now, "Denied");
                        MessageBox.Show("Доступ запрещён!");
                        ErrorEnter(Count);
                    }
                    else
                    {
                        dB.AddLog(textBox1.Text, DateTime.Now, "Success");
                        MessageBox.Show("Доступ разрешён!");
                        MainMenu mainMenu = new MainMenu(textBox1.Text, textBox2.Text);
                        this.Hide();
                        mainMenu.ShowDialog();
                    }
                }
                else
                {
                    dB.AddLog(textBox1.Text, DateTime.Now, "Success");
                    MessageBox.Show("Доступ разрешён!");
                    MainMenu mainMenu = new MainMenu(textBox1.Text, textBox2.Text);
                    this.Hide();
                    mainMenu.ShowDialog();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
                button1.Enabled = true;
        }

        private void ErrorEnter(int count)
        {
            if (count == 0)
            {
                Count++;
                button2.Visible = pictureBox1.Visible = textBox3.Visible = true;
                pictureBox1.Image = CreateImage(pictureBox1.Width, pictureBox1.Height);
            }
            else if (count == 1)
            {
                button1.Enabled= false;
                timer1.Interval = 1000;
                timer1.Start();
                Count++;
            }
            else if (count == 2)
            {
                MessageBox.Show("Доступ в систему запрещён!");
                button1.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = tik + " Секунд осталось";
            if (tik > 0)
                tik--;
            else
            {
                label3.Text = "Время кончилось";
                button1.Enabled = true;
            }
        }
    }
}