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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
            var HighScoreClassic = System.IO.File.ReadLines(@"D:\Documents\HighScores\HighScores.txt").Take(1).First();
            label5.Text = HighScoreClassic.ToString();
            var HighScoreClassic2 = System.IO.File.ReadLines(@"D:\Documents\HighScores\HighScores.txt").Skip(1).Take(1).First();
            label6.Text = HighScoreClassic2.ToString();
            var HighScoreMaze = System.IO.File.ReadLines(@"D:\Documents\HighScores\HighScores.txt").Skip(2).Take(1).First();
            label7.Text = HighScoreMaze.ToString();
            var HighScoreTraps = System.IO.File.ReadLines(@"D:\Documents\HighScores\HighScores.txt").Skip(3).Take(1).First();
            label8.Text = HighScoreTraps.ToString();
        }

        private void HighScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
