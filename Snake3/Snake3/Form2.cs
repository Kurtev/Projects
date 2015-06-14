using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Snake3
{
    public partial class Form2 : Form
    {
        Label food=new Label();
        Label[] maze = new Label []{};
        Label[] snake;
        Label[] rec = new Label[] { };

        int FoodLocX, FoodLocY;
        int score = 0;
        int mazeX, mazeY=150;
        int SnakeMoveX = 60;
        int SnakeMoveY = 0;
        int ESCenableDisable = 0;
        int TrapCount = 0;
        int TrapLocX, TrapLocY;
        int TrapX = 15, TrapY = 30;
        int MovementPress = 0;
        int SnakeLocX, SnakeLocY;
        public int style = 0;
        public int ClassicHighScore, Classic2HighScore, TrapHighScore, MazeHighScore,CorrectScore;
      
        bool DirectionUp = false;
        bool DirectionDown = false;
        bool DirectionLeft = false;
        bool keyEscape = false;
        bool DirectionRight = false;
        bool trapMaze = true;

        Graphics g;
        Point FoodPos = new Point();
        Brush brush = new SolidBrush(Color.Red);
        Random ran,ran2;

        public Form2()
        {
            InitializeComponent();
            generateFood();
            for (int i = 0; i < rec.Length; i++)
            {
                if (FoodPos == rec[i].Location||FoodPos==snake[i].Location)
                    generateFood();
            }
            for (int j = 0; j <= maze.Length - 1; j++)
            {
                generateFood();
            }
            generateSnake();
        }

        //DRAW THE SNAKE AT STARTING POINT
        public void generateSnake()
        {
         
            snake=new Label[3];
            SnakeLocX = 60;
            SnakeLocY = 0;
            for (int i = 0; i < snake.Length; i++)
            {
                if (i == 0)
                {
                    snake[i] = new Label();
                    snake[i].Location = new Point(SnakeLocX, SnakeLocY);
                    snake[i].Image = Properties.Resources.Right;
                    snake[i].Size = new Size(30, 30);
                    this.Controls.Add(snake[i]);
                    SnakeLocX -= 30;
                }
                else
                {
                    snake[i] = new Label();
                    snake[i].Location = new Point(SnakeLocX, SnakeLocY);
                    snake[i].Image = Properties.Resources.Horizontal;
                    snake[i].Size = new Size(30, 30);
                    this.Controls.Add(snake[i]);
                    SnakeLocX -= 30;
                }
                
            }

        }

        //CREATE A FOOD
        public void generateFood()
        {
            Random rand = new Random();
            FoodLocX = rand.Next(0, 20) * 30;
            FoodLocY = rand.Next(0, 13) * 30;
            FoodPos = new Point(FoodLocX, FoodLocY);
            food.Image = Properties.Resources.apple;
            food.Size = new Size(30, 30);
            food.Location = FoodPos;
            this.Controls.Add(food);
        }

        //ACTIONS WHEN PRESSING A KEY
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)

                if (ESCenableDisable == 0)
                {
                    keyEscape = true;
                    ESCenableDisable = 2;
                    panel1.Controls.Add(MainMenu);
                    panel1.Controls.Add(Exit);
                    panel1.Controls.Add(resumeGame);
                    MainMenu.Visible = true;
                    resumeGame.Visible = true;
                    Exit.Visible = true;
                    resumeGame.Focus();
                    label4.Enabled = true;
                }
                else if (ESCenableDisable == 2)
                {
                    keyEscape = false;
                    ESCenableDisable = 0;
                    panel1.Controls.Remove(MainMenu);
                    panel1.Controls.Remove(Exit);
                    panel1.Controls.Remove(resumeGame);
                    
                }
            if (SnakeMoveX == -30 || SnakeMoveX == 660 || SnakeMoveY == 480 || SnakeMoveY == -30)
            {
                MovementPress = 1;
            }

            switch (MovementPress)
            {
                case 0:
                    if (e.KeyCode == Keys.Down)
                    {
                        MovementPress++;
                        if (DirectionUp == true)
                        {
                            DirectionDown = false;
                            DirectionUp = true;
                            DirectionLeft = false;
                            DirectionRight = false;
                        }
                        else
                        {

                            DirectionDown = true;
                            DirectionUp = false;
                            DirectionLeft = false;
                            DirectionRight = false;
                        }

                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        MovementPress++;
                        if (DirectionDown == true)
                        {
                            DirectionDown = true;
                            DirectionUp = false;
                            DirectionLeft = false;
                            DirectionRight = false;
                        }
                        else
                        {

                            DirectionDown = false;
                            DirectionUp = true;
                            DirectionLeft = false;
                            DirectionRight = false;
                        }
                    }
                    if (e.KeyCode == Keys.Left)
                    {
                        MovementPress++;
                        if (DirectionRight == true)
                        {
                            DirectionDown = false;
                            DirectionUp = false;
                            DirectionLeft = false;
                            DirectionRight = true;
                        }
                        else
                        {

                            DirectionDown = false;
                            DirectionUp = false;
                            DirectionLeft = true;
                            DirectionRight = false;
                        }

                    }
                    if (e.KeyCode == Keys.Right)
                    {
                        MovementPress++;
                        if (DirectionLeft == true)
                        {
                            DirectionDown = false;
                            DirectionUp = false;
                            DirectionLeft = true;
                            DirectionRight = false;
                        }
                        else
                        {

                            DirectionDown = false;
                            DirectionUp = false;
                            DirectionLeft = false;
                            DirectionRight = true;
                        }
                    } break;


            }
        }

       //TIMER HANDLING THE MOVEMENT AND THE RULES OF THE GAME TYPE
        private void timer1_Tick(object sender, EventArgs e)
        {
            MovementPress = 0;
       
           
       
         
                if (DirectionDown == true) { moveDown(); }
                if (DirectionRight == true) { moveRight(); }
                if (DirectionLeft == true) { moveLeft(); }
                if (DirectionUp == true) { moveUp(); }
                GameType();
              
           
           
            for (int i = 0; i < snake.Length; i++)
            {
                if (snake[0].Location == food.Location)
                {
                    generateFood();
                    GrowSnake();
                    score += 5;
                    Score.Text = score.ToString();
                }
                else if (snake[i].Location == food.Location)
                {
                    generateFood();
                }
            }
                    for (int j=0; j <=rec.Length-1; j++)
                    {
                        if (FoodPos==rec[j].Location)
                        {
                            generateFood();
                        }
                    }
                    for (int l = 0; l <= maze.Length - 1; l++)
                    {
                        if (FoodPos == maze[l].Location)
                        {
                            generateFood();
                        }
                    }
                   
        }
        // MOVEMENTS
        public void moveDown()
        {

            for (int i = snake.Length - 1; i > 0; i--)
            {
                snake[i].Location = snake[i - 1].Location;
                snake[i].Image = snake[i - 1].Image;
            }
            snake[1].Image = Properties.Resources.Vertical;
            SnakeMoveY += 30;
            snake[0].Location = new Point(SnakeMoveX, SnakeMoveY);
            snake[0].Image = Properties.Resources.Down;
        }
        public void moveUp()
        {
            for (int i = snake.Length - 1; i > 0; i--)
            {
                snake[i].Location = snake[i - 1].Location;
                snake[i].Image = snake[i - 1].Image;
            }
            snake[1].Image = Properties.Resources.Vertical;
            SnakeMoveY -= 30;
            snake[0].Location = new Point(SnakeMoveX, SnakeMoveY);
            snake[0].Image = Properties.Resources.Up;
        }
        public void moveLeft()
        {
            for (int i = snake.Length - 1; i > 0; i--)
            {
                snake[i].Location = snake[i - 1].Location;
                snake[i].Image = snake[i - 1].Image;
            }
            snake[1].Image = Properties.Resources.Horizontal;
            SnakeMoveX -= 30;
            snake[0].Location = new Point(SnakeMoveX, SnakeMoveY);
            snake[0].Image = Properties.Resources.Left;
        }
        public void moveRight()
        {
            for (int i = snake.Length - 1; i > 0; i--)
            {
                snake[i].Location = snake[i - 1].Location;
                snake[i].Image = snake[i - 1].Image;
            }
            snake[1].Image = Properties.Resources.Horizontal;
            SnakeMoveX += 30;
            snake[0].Location = new Point(SnakeMoveX, SnakeMoveY);
            snake[0].Image = Properties.Resources.Right;
        }

        // GROW THE SNAKE WHEN FOOD EATEN
        public void GrowSnake()
        {
            Label label = new Label();
            label.Size = new Size(30, 30);
            this.Controls.Add(label);
            List<Label> lbl = snake.ToList();
            lbl.Add(label);
            snake = lbl.ToArray();
           
        }

        //METHOD HANDLING THE GAME TYPE
        public void GameType()
        {
            switch (style)
            {
                case 0: PassTrough(); break;
                case 1: Collision(); break;
                case 2: if (trapMaze) { Maze(); trapMaze = false; } mazeCollision(); PassTrough(); break;
                case 3: Collision(); if (trapMaze) { Traps(); trapMaze = false; } break;
            }
        }

        //COLLISIONS ON THE END OF THE SCREEN
        public void Collision()
        {
            for (int i = snake.Length - 1; i > 0; i--)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    timer1.Enabled = false;
                    keyEscape = true;
                    MessageBox.Show("Snake Died");
                    if (score > ClassicHighScore)
                    {
                        HighScore(style);

                    }
                }
            }
                if (snake[0].Location.X > 630 || snake[0].Location.X < 0 || snake[0].Location.Y > 420 || snake[0].Location.Y < 0)
                {
                    timer1.Enabled = false;
                    keyEscape = true;
                    MessageBox.Show("Snake Died");
                    if (score > ClassicHighScore)
                    {
                        HighScore(style);

                    }
                }
               
            
                for (int i = 0; i <= rec.Length - 1; i++)
                {
                    if (snake[0].Location == rec[i].Location)
                    {
                       
                        timer1.Enabled = false;
                        keyEscape = true;
                        MessageBox.Show("Snake Died");
                        if (score > ClassicHighScore)
                        {
                            HighScore(style);

                        }

                    }
                }
                
                
        }

        //COLLISIONS ON THE WALLS OF THE MAZE
        public void mazeCollision()
        {
            for (int i = 0; i<=maze.Length-1; i++)
            {
                if (snake[0].Location == maze[i].Location)
                {

                    timer1.Enabled = false;
                    keyEscape = true;
                    MessageBox.Show("Snake Died");
                    if (score > ClassicHighScore)
                    {
                        HighScore(style);

                    }
                }
            }
        }

       
        // METHOD FOR MOVING TROUG THE END OF THE FIELD
        public void PassTrough()
        {
            for (int i = snake.Length - 1; i > 0; i--)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    timer1.Enabled = false;
                    keyEscape = true;
                    MessageBox.Show("Snake Died");
                    if (score > ClassicHighScore)
                    {
                        HighScore(style);
                        
                    }
                }
            }
            if (snake[0].Location.X == 660)
            {
               
                SnakeMoveX = -30;
                
            }
            if (snake[0].Location.X == -30)
            {

                SnakeMoveX = 660;

            }
            if (snake[0].Location.Y ==-30)
            {
                SnakeMoveY = 480;
            }
            else if (snake[0].Location.Y == 480)
            {
                SnakeMoveY = -30;
            }
        }
       
        // METHOD FOR CREATING TRAPS
       public void Traps()
        {
            ran = new Random();
            TrapCount = ran.Next(2, 25);
            rec = new Label[TrapCount];
            ran2 = new Random();
            for (int i = 0; i < TrapCount; i++)
            {
                    
                    TrapLocX= ran2.Next(1,TrapX)*30;
                    TrapLocY = ran2.Next(1,TrapY)*30;
                    rec[i] = new Label();
                    rec[i].Location = new Point(TrapLocX, TrapLocY);
                    rec[i].Image = Properties.Resources.trap;
                    rec[i].Size = new Size(30, 30);
                    this.Controls.Add(rec[i]);
                    
            }

        }

        //METHOD FOR CREATING THE MAZE
       public void Maze()
       {
           maze = new Label[32];
           for (int i = 0; i < 4; i++)
           {
               mazeX = 90;
               mazeY = mazeY + 30;
               maze[i] = new Label();
               maze[i].Location=new Point (mazeX, mazeY);
               maze[i].Image = Properties.Resources.trap;
               maze[i].Size = new Size(30, 30);
               this.Controls.Add(maze[i]);
           }
           mazeY = 150;
           for (int i = 4; i<8 ; i++)
           {
               mazeX = 120;
               mazeY = mazeY + 30;
               maze[i] = new Label();
               maze[i].Location = new Point(mazeX, mazeY);
               maze[i].Image = Properties.Resources.trap;
               maze[i].Size = new Size(30, 30);
               this.Controls.Add(maze[i]);
           }
           mazeY = 150;
           for (int i = 8; i < 12; i++)
           {
               mazeX = 510;
               mazeY = mazeY + 30;
               maze[i] = new Label();
               maze[i].Location = new Point(mazeX, mazeY);
               maze[i].Image = Properties.Resources.trap;
               maze[i].Size = new Size(30, 30);
               this.Controls.Add(maze[i]);
           }
           mazeY = 150;
           for (int i = 12; i < 16; i++)
           {
               mazeX = 540;
               mazeY = mazeY + 30;
               maze[i] = new Label();
               maze[i].Location = new Point(mazeX, mazeY);
               maze[i].Image = Properties.Resources.trap;
               maze[i].Size = new Size(30, 30);
               this.Controls.Add(maze[i]);
           }
           mazeX = 240;
           for (int i = 16; i < 20; i++)
           {
               mazeY = 60;
               mazeX = mazeX + 30;
               maze[i] = new Label();
               maze[i].Location = new Point(mazeX, mazeY);
               maze[i].Image = Properties.Resources.trap;
               maze[i].Size = new Size(30, 30);
               this.Controls.Add(maze[i]);
           }
           mazeX = 240;
           for (int i = 20; i < 24; i++)
           {
               mazeY = 90;
               mazeX = mazeX + 30;
               maze[i] = new Label();
               maze[i].Location = new Point(mazeX, mazeY);
               maze[i].Image = Properties.Resources.trap;
               maze[i].Size = new Size(30, 30);
               this.Controls.Add(maze[i]);
           }
           mazeX = 240;
           for (int i = 24; i < 28; i++)
           {
               mazeY = 360;
               mazeX = mazeX + 30;
               maze[i] = new Label();
               maze[i].Location = new Point(mazeX, mazeY);
               maze[i].Image = Properties.Resources.trap;
               maze[i].Size = new Size(30, 30);
               this.Controls.Add(maze[i]);
           }
           mazeX = 240;
           for (int i = 28; i < 32; i++)
           {
               mazeY = 390;
               mazeX = mazeX + 30;
               maze[i] = new Label();
               maze[i].Location = new Point(mazeX, mazeY);
               maze[i].Image = Properties.Resources.trap;
               maze[i].Size = new Size(30, 30);
               this.Controls.Add(maze[i]);
           }
         
         
       }

        //TIMER FOR HANDLING GAME PAUSES
        private void timer2_Tick(object sender, EventArgs e)
        {
           
            if (keyEscape==true)
            {
                timer1.Enabled = false;
                label2.Visible = true;
             
               
            }
            if(keyEscape==false)
            {
                timer1.Enabled = true;
                label2.Visible = false;
          
               
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resumeGame_Click(object sender, EventArgs e)
        {

            keyEscape = false;
            ESCenableDisable = 0;
            resumeGame.FindForm().Activate();
            panel1.Controls.Remove(MainMenu);
            panel1.Controls.Remove(Exit);
            panel1.Controls.Remove(resumeGame);
            panel1.FindForm().Activate();
            label4.Focus();
            label4.Enabled = false;   
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void HighScore(int line)
        {

            var lines = File.ReadAllLines(@"D:\Documents\HighScores\HighScores.txt");
            lines[line] = score.ToString();
            File.WriteAllLines(@"D:\Documents\HighScores\HighScores.txt", lines);
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
       
}
}
       

