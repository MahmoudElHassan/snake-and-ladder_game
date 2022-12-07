using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_and_ladder_game
{
    public partial class Form1 : Form
    {
        int flag = 0;
        bool blue = false ,red = false;
        int x = 3, y = 492, diceValue, p=0;
        int bx = 39, by = 492, q = 0;


        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                button2.Enabled = false;
            }
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox3.Image = Image.FromFile(@"D:\_Projects\snake-and-ladder_game\snake-and-ladder_game\Resources\logo.jpeg");
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diceValue = logics.rolldice(pictureBox3);
            label8.Text = diceValue.ToString();

            if (blue == true)
            {
                p = logics.move(ref x, ref y, ref p, diceValue, label9 , pictureBox4);
                label9.Text = p.ToString();
            }

            if (label8.Text == "6" && blue == false)
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                blue = true;
                pictureBox4.Location = new Point(x,y);
                label4.Text = x.ToString();
                label6.Text = y.ToString();
                label9.Text = p.ToString();
                p++;
            }

            if (p == 101)
            {
                MessageBox.Show("WINNER");
                button1.Enabled = false;
            }
            p = logics.snake(ref x, ref y, p, pictureBox4);
            p = logics.ladder(ref x, ref y, p, pictureBox4);
            label9.Text = p.ToString();

            if (diceValue == 6)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diceValue = logics.rolldice(pictureBox3);
            label8.Text = diceValue.ToString();

            if (red == true)
            {
                q = logics.move(ref bx, ref by, ref q, diceValue, label11, pictureBox5);
                label11.Text = q.ToString();
            }

            if (label8.Text == "6" && red == false)
            {
                pictureBox5.Visible = true;
                pictureBox2.Visible = false;
                red = true;
                pictureBox5.Location = new Point(x, y);
                label4.Text = bx.ToString();
                label6.Text = by.ToString();
                label11.Text = q.ToString();
                q++;
            }

            if (q == 101)
            {
                MessageBox.Show("WINNER");
                button2.Enabled = false;
            }
            q = logics.snake(ref bx, ref by, q, pictureBox5);
            q = logics.ladder(ref bx, ref by, q, pictureBox5);
            label11.Text = q.ToString();

            if (diceValue == 6)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
                button2.Enabled = false;
                button1.Enabled = true;
            }
        }




    }
}
