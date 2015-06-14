using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake3
{
    public partial class settings : Form
    {
        public Form2 form2 = new Form2();
  

        public settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.AutoCheck = false;
                checkBox2.AutoCheck = true;
                checkBox3.AutoCheck = true;
                form2.Dfficulty.Text = "Easy";
                form2.timer1.Interval = 1700;
            }

     

        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = true;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox2.AutoCheck = false;
                checkBox1.AutoCheck = true;
                checkBox3.AutoCheck = true;
                form2.timer1.Interval = 500;
                form2.Dfficulty.Text = "Normal";
            }
          
        }

        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.AutoCheck = false;
                checkBox1.AutoCheck = true;
                checkBox2.AutoCheck = true;
                form2.Dfficulty.Text = "Hard";
                form2.timer1.Interval = 40;
            }
        }

     
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
               form2.style = 0;
               form2.GType.Text = "Classic";
               var HighScore = System.IO.File.ReadLines(@"D:\Documents\HighScores\HighScores.txt").Take(1).First();
               form2.CorrectScore = Convert.ToInt32(HighScore);
               form2.ClassicHighScore = Convert.ToInt32(HighScore);
            
            }
        }
        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                form2.style = 1;
                form2.GType.Text = "Classic 2";
                var HighScore = System.IO.File.ReadLines(@"D:\Documents\HighScores\HighScores.txt").Skip(1).Take(1).First();
                form2.CorrectScore = Convert.ToInt32(HighScore);
                form2.ClassicHighScore = Convert.ToInt32(HighScore);
            }
        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                form2.style = 2;
                form2.GType.Text = "Maze";
                var HighScore = System.IO.File.ReadLines(@"D:\Documents\HighScores\HighScores.txt").Skip(2).Take(1).First();
                form2.CorrectScore = Convert.ToInt32(HighScore);
                form2.ClassicHighScore = Convert.ToInt32(HighScore);
            }
        }

        public void radioButton4_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButton4.Checked == true)
            {
                form2.style = 3;
                form2.GType.Text = "Rand Traps";
                var HighScore = System.IO.File.ReadLines(@"D:\Documents\HighScores\HighScores.txt").Skip(3).Take(1).First();
                form2.CorrectScore = Convert.ToInt32(HighScore);
                form2.ClassicHighScore = Convert.ToInt32(HighScore);
            }
            
        }

    }
}

