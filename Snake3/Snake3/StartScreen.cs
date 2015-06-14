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
    public partial class StartScreen : Form
    {
        settings settingsMenu = new settings();
        HighScores highScore;

         public StartScreen()
        {
            InitializeComponent();
        }

         private void Settings_Click(object sender, EventArgs e)
         {
             settingsMenu.Show();
             StartScreen startScreen = new StartScreen();
             startScreen.Visible = false;
         }

         private void button1_Click(object sender, EventArgs e)
         {
             settingsMenu.form2 = new Form2();
             settingsMenu.checkBox1_CheckedChanged(sender, e);
             settingsMenu.checkBox2_CheckedChanged(sender, e);
             settingsMenu.checkBox3_CheckedChanged(sender, e);
             settingsMenu.radioButton1_CheckedChanged(sender, e);
             settingsMenu.radioButton2_CheckedChanged(sender, e);
             settingsMenu.radioButton3_CheckedChanged(sender, e);
             settingsMenu.radioButton4_CheckedChanged(sender, e);
             settingsMenu.form2.ShowDialog();
             settingsMenu.form2.Activate();
            
         }

         private void button3_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }

         private void HighScores_Click(object sender, EventArgs e)
         {
             highScore = new HighScores();
             highScore.ShowDialog();
         }

         private void StartScreen_FormClosed(object sender, FormClosedEventArgs e)
         {
             Application.Exit();
         }

    }
}
