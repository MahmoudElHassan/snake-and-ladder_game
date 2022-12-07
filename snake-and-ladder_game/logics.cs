using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_and_ladder_game
{
    internal class logics
    {
        public static int rolldice(PictureBox px)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);
            px.Image = Image.FromFile(@"D:\_Projects\snake-and-ladder_game\snake-and-ladder_game\Resources\" + dice +".png");
            px.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice;
        }

        public static int move(ref int x, ref int y, ref int p, int dice,Label l,PictureBox px)
        {
            if (dice + p > 101)
            {
                l.Text = "Can't Move";
                l.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                for (int i = 0; i < dice; i++)
                {
                    if (p == 10)
                    {
                        x = 3;
                        y = 439;
                    }
                    else if (p == 20)
                    {
                        x = 3;
                        y = 386;
                    }
                    else if (p == 30)
                    {
                        x = 3;
                        y = 333;
                    }
                    else if (p == 40)
                    {
                        x = 3;
                        y = 280;
                    }
                    else if (p == 50)
                    {
                        x = 3;
                        y = 220;
                    }
                    else if (p == 60)
                    {
                        x = 3;
                        y = 174;
                    }
                    else if (p == 70)
                    {
                        x = 3;
                        y = 127;
                    }
                    else if (p == 80)
                    {
                        x = 3;
                        y = 75;
                    }
                    else if (p == 90)
                    {
                        x = 3;
                        y = 15;
                    }
                    else
                    {
                        x += 72;
                        l.Text = p.ToString();
                    }

                    l.Text = p.ToString();
                    px.Location = new Point(x, y);
                    p++;
                }
            }
            return p;
        }

        public static int snake(ref int x,ref int y,int p,PictureBox px)
        {
            if (p == 25)
            {
                x = 291;
                y = 491;
                p = 5;
                px.Location = new Point(x, y);
            }
            else if (p == 34)
            {
                x = 3;
                y = 492;
                p = 1;
            }
            else if (p == 47)
            {
                x = 577;
                y = 491;
                p = 9;
            }
            else if (p == 65)
            {
                x = 78;
                y = 227;
                p = 52;
            }
            else if (p == 87)
            {
                x = 435;
                y = 227;
                p = 57;
            }
            else if (p == 91)
            {
                x = 3;
                y = 180;
                p = 61;
            }
            return p;
        }

        public static int ladder(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 3)
            {
                x = 3;
                y = 227;
                p = 51;
            }
            else if (p == 6)
            {
                x = 433;
                y = 386;
                p = 27;
            }
            else if (p == 20)
            {
                x = 648;
                y = 180;
                p = 70;
            }
            else if (p == 36)
            {
                x = 291;
                y = 227;
                p = 55;
            }
            else if (p == 63)
            {
                x = 291;
                y = 22;
                p = 95;
            }
            else if (p == 68)
            {
                x = 506;
                y = 22;
                p = 99;
            }
            return p;
        }
    }
}
