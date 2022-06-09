using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace FinalProjectSquareChaserAdvanced
{ 
    public partial class Form1 : Form
    {
        List<Rectangle> squares = new List<Rectangle>();
        List<int> squareSpeeds = new List<int>();
        List<string> squareColours = new List<string>();

        int time = 0;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upDown = false;
        bool downDown = false;
        bool leftDown = false;
        bool rightDown = false;

        Rectangle player1 = new Rectangle(10, 210, 10, 10);
        Rectangle player2 = new Rectangle(10, 130, 10, 10);

        int player1Score = 0;
        int player2Score = 0;
        int player1Speed = 6;
        int player2Speed = 6;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        Random randGen = new Random();

        int groundHeight = 50;
        string gameState = "waiting";


        public void GameInitialize()
        {
            titleLabel.Text = "";
            subtitleLabel.Text = "";
            gameTimer.Enabled = true;
            gameState = "running";
            time = 750;

            squares.Clear();
            squareColours.Clear();
            squareSpeeds.Clear();

            player1.X = this.Width / 2 - player1.Width / 2;
            player1.Y = this.Height - groundHeight - player1.Height;
            player2.X = this.Width / 2 - player2.Width / 2;
            player2.Y = this.Height - groundHeight - player2.Height;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upDown = true;
                    break;
                case Keys.Down:
                    downDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Space:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        GameInitialize();
                    }
                    break;
                case Keys.Escape:
                    if (gameState == "over")
                    {
                        Application.Exit();
                    }
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            time--;
            timeLabel.Text = $"Time: {time}";
            //move player 1
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }
            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }
            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }
            if (dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += player1Speed;
            }

            //move player2
            if (upDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }
            if (downDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }
            if (leftDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }
            if (rightDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }

            // create code that checks if player 1 collides with square and if it does
            // move ball1 to a different location.

            for (int i = 0; i < squares.Count(); i++)
            {
                if (player1.IntersectsWith(squares[i])) //blue guy
                {
                    if (squareColours[i] == "green")
                    {
                        player1Score += 1;
                        p1scoreLabel.Text = $"P1: {player1Score}";
                        // get code to delete/remove the square that was hit by player

                    }
                    else
                    {
                        player1Score -= 1;
                        p1scoreLabel.Text = $"P2: {player2Score}";
                    }
                }
            }
           
            for (int i = 0; i < squares.Count(); i++)
            {
                if (player2.IntersectsWith(squares[i])) //yellow guy
                {
                    if (squareColours[i] == "green")
                    {
                        player2Score += 1;
                        p1scoreLabel.Text = $"P1: {player2Score}";
                        //get code to delete/remove the square that was hit by player 
                    }
                    else
                    {
                        player2Score -= 1;
                    }
                }
            }

            // check if it is time to add a new dot

            int randValue = randGen.Next(0, 101);

            if (randValue < 3)
            {
                int x = randGen.Next(0, this.Width);
                int y = randGen.Next(0, this.Width);

                Rectangle newRec = new Rectangle(x, y, 10, 10);
                squares.Add(newRec);
                squareColours.Add("red");
            }

            if (randValue < 3)
            {
                int x = randGen.Next(0, this.Width);
                int y = randGen.Next(0, this.Width);

                Rectangle newRec = new Rectangle(x, y, 10, 10);
                squares.Add(newRec);
                squareColours.Add("green");
            }
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gameState == "waiting")
            {
                titleLabel.Text = "Welcome to Square Chaser Advanced.";
                subtitleLabel.Text = "Press Space Bar to Start!";
                timeLabel.Text = $"";
                p1scoreLabel.Text = $"";
                p2scoreLabel.Text = $"";
            }
            else if (gameState == "running")
            {
                p1scoreLabel.Text = $"P1: {player1Score}";
                p2scoreLabel.Text = $"P2: {player2Score}";
                titleLabel.Text = "";
                subtitleLabel.Text = "";
                winLabel.Text = "";
                e.Graphics.FillRectangle(blueBrush, player1);
                e.Graphics.FillRectangle(yellowBrush, player2);

                for (int i = 0; i < squares.Count(); i++)
                {
                    if (squareColours[i] == "red")
                    {
                        e.Graphics.FillEllipse(redBrush, squares[i]);
                    }
                    else if (squareColours[i] == "green")
                    {
                        e.Graphics.FillEllipse(greenBrush, squares[i]);
                    }

                    if (time == 0)
                    {
                        gameState = "over";
                    }
                }
            }
            else if (gameState == "over")
            {
                timeLabel.Text = "Time: 0";
                p1scoreLabel.Text = "";
                p2scoreLabel.Text = "";
                titleLabel.Text = "GAME OVER";
                subtitleLabel.Text += "\nPress Space Bar to Play Again or Escape to Exit";

                if (player1Score > player2Score)
                {
                    gameTimer.Enabled = false;
                    winLabel.Visible = true;
                    winLabel.Text = "Player 1 Wins!!";
                }
                else
                {
                    gameTimer.Enabled = false;
                    winLabel.Visible = true;
                    winLabel.Text = "Player 2 Wins!!";
                }
            }
        }
    }
}