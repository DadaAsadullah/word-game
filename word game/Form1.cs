using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace word_game
{
    public partial class Form1 : Form
    {
        public static int point = 0;
        public static int hints = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] words = { "P_E__CT", "A_Y_S_", "B_H_M__H", "CA__L_Y_T", "D__OU_", "EX__AP_L_T_" };
            Random rnd = new Random();
            int i = rnd.Next(0, 5);
            answer1.Text = words[i];
            background.BackColor = Color.Red;
            background.Image = Image.FromFile("background.png");
            var colour = background.BackColor;
            if (colour == Color.Green)
            {
               submit.Enabled = false;                
            }
             
        }
        private void submit_Click(object sender, EventArgs e)
        {
            string[] answers = { "PREDICT", "ABYSS", "BOHEMOTH", "CATALYST", "DEVOUR", "EXTRAPOLATE" };
            string[] words = { "P_E__CT", "A_Y_S_", "B_H_M__H", "CA__L_Y_T", "D__OU_", "EX__AP_L_T_" };
            string guess = Userguess.Text.ToUpper();
            var thingy = answer1.Text.ToUpper();
            var start = guess[0];
            var begin = thingy[0];

            if (start == begin && answers.Contains(guess))
            {
                answer1.Text = guess;
                Userguess.Text = "";
                background.BackColor = Color.Green;
                start = '\0';
                point = point + 1;
                points.Text = ("points:" + point.ToString());
                if(point == 5)
                {
                    background.Image = Image.FromFile("win.png");
                    
                }
            }
            
            
        }
        private void clear_Click(object sender, EventArgs e)
        {
            Userguess.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = { "P_E__CT", "A_Y_S_", "B_H_M__H", "CA__L_Y_T", "D__OU_", "EX__AP_L_T_" };
            Random rnd = new Random();
            int x = rnd.Next(0, 5);
            answer1.Text = words[x];
            background.BackColor = Color.Red;
            background.Image = Image.FromFile("background.png");

        }

        private void hint_Click(object sender, EventArgs e)
        {
            string[] answers = { "PREDICT", "ABYSS", "BEHEMOTH", "CATALYST", "DEVOUR", "EXTRAPOLATE" };
            string[] words = { "P_E__CT", "A_Y_S_", "B_H_M__H", "CA__L_Y_T", "D__OU_", "EX__AP_L_T_" };
            string guess = Userguess.Text.ToUpper();
            var thingy = answer1.Text.ToUpper();
            var begin = thingy[0];
            hints = hints - 1;
            label1.Text = ("hints: " + hints.ToString());
            if (hints <= 3 && hints > 0)
            {
                if (begin == 'A')
                {
                    background.Image = Image.FromFile("abyss.png");
                }
                else if (begin == 'P')
                {
                    background.Image = Image.FromFile("predict.png");
                }
                else if (begin == 'B')
                {
                    background.Image = Image.FromFile("big.png");
                }
                else if (begin == 'C')
                {
                    background.Image = Image.FromFile("catalyst.png");
                }
                else if (begin == 'D')
                {
                    background.Image = Image.FromFile("devour.png");
                }
                else if (begin == 'E')
                {
                    background.Image = Image.FromFile("extrapolate.png");
                }
            }
            else if (hints < 0)
            {
                background.Image = Image.FromFile("scare.png");
                label1.Text = ("NO MORE LEFT");
            }           
    
        }

    }
}
