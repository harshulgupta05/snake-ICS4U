using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SnakeGame_HarshulGupta
{
    public partial class Form1 : Form
    {
        Snake P1, P2;
        Food food;
        bool twoPlayer;
        int iHighScore, iCurrScoreP1, iCurrScoreP2;
        int iP1Wins, iP2Wins, iTies;

        // TODO: Add save states?

        public Form1()
        {
            InitializeComponent();
            P1 = new Snake();
            P2 = new Snake();
            food = new Food();
            iHighScore = 0;
            iCurrScoreP1 = 0;
            iCurrScoreP2 = 0;
            iP1Wins = 0;
            iP2Wins = 0;
            iTies = 0;
        }

        // body part class
        public class bodyPart
        {
            // integer members for the x and y
            public int pX;
            public int pY;

            // color member for the bodyPart color
            public Color clr;

            // default constructor
            public bodyPart()
            {
                pX = 10;
                pY = 10;
                clr = Color.Black;
            }

            // constructor with x and y parameters
            public bodyPart(int x, int y)
            {
                pX = x;
                pY = y;
                clr = Color.Black;
            }

            // constructor with x, y, and color parameters
            public bodyPart(int x, int y, Color color)
            {
                pX = x;
                pY = y;
                clr = color;
            }

            // draw function for the body part
            public void Draw(Graphics g)
            {
                // create brush with the color member
                SolidBrush brush = new SolidBrush(clr);

                // draw circle for body part (20 x 20)
                g.FillEllipse(brush, pX * 20, pY * 20, 20, 20);
            }

            public void Draw(Graphics g, int direction)
            {
                // create brush with the color member
                SolidBrush brush = new SolidBrush(clr);

                switch (direction)
                {
                    case 0:
                        // create three points for the triangle head
                        Point p1_up, p2_up, p3_up;

                        // set the location of the three points
                        p1_up = new Point((pX * 20) + 10, pY * 20);
                        p2_up = new Point(pX * 20, (pY * 20) + 20);
                        p3_up = new Point((pX * 20) + 20, (pY * 20) + 20);

                        // add points to array
                        Point[] points_up = new Point[3];
                        points_up[0] = p1_up;
                        points_up[1] = p2_up;
                        points_up[2] = p3_up;

                        // create polygon with points
                        g.FillPolygon(brush, points_up);

                        break;
                    case 1:
                        // create three points for the triangle head
                        Point p1_right, p2_right, p3_right;

                        // set the location of the three points
                        p1_right = new Point(pX * 20, pY * 20);
                        p2_right = new Point(pX * 20, (pY * 20) + 20);
                        p3_right = new Point((pX * 20) + 20, (pY * 20) + 10);

                        // add points to array
                        Point[] points_right = new Point[3];
                        points_right[0] = p1_right;
                        points_right[1] = p2_right;
                        points_right[2] = p3_right;

                        // create polygon with points
                        g.FillPolygon(brush, points_right);

                        break;
                    case 2:
                        // create three points for the triangle head
                        Point p1_down, p2_down, p3_down;

                        // set the location of the three points
                        p1_down = new Point(pX * 20, pY * 20);
                        p2_down = new Point((pX * 20) + 10, (pY * 20) + 20);
                        p3_down = new Point((pX * 20) + 20, pY * 20);

                        // add points to array
                        Point[] points_down = new Point[3];
                        points_down[0] = p1_down;
                        points_down[1] = p2_down;
                        points_down[2] = p3_down;

                        // create polygon with points
                        g.FillPolygon(brush, points_down);

                        break;
                    case 3:
                        // create three points for the triangle head
                        Point p1_left, p2_left, p3_left;

                        // set the location of the three points
                        p1_left = new Point((pX * 20) + 20, pY * 20);
                        p2_left = new Point(pX * 20, (pY * 20) + 10);
                        p3_left = new Point((pX * 20) + 20, (pY * 20) + 20);

                        // add points to array
                        Point[] points_left = new Point[3];
                        points_left[0] = p1_left;
                        points_left[1] = p2_left;
                        points_left[2] = p3_left;

                        // create polygon with points
                        g.FillPolygon(brush, points_left);

                        break;
                }
            }
        }

        // snake class
        public class Snake
        {
            private int direction; // up = 0, right = 1, down = 2, left = 3

            // list member for the body parts of the snake
            private List<bodyPart> snakeBody = new List<bodyPart>();

            // color member for the color of the snake
            private Color clr;

            // default constructor
            public Snake()
            {
                // moves left
                direction = 3;

                // make the head of the snake
                bodyPart head = new bodyPart();

                // default color black
                clr = Color.Black;

                // add the head to the snakeBody list
                snakeBody.Add(head);
            }

            // constructor with initial x and y
            public Snake(int x, int y)
            {
                // moves right
                direction = 1;

                // make the head of the snake 
                bodyPart head = new bodyPart(x, y);

                // default color black
                clr = Color.Black;

                // add the head to the snakeBody list
                snakeBody.Add(head);
            }

            // getter for the snakeBody member
            public List<bodyPart> getBodyParts()
            {
                return snakeBody;
            }

            // getter for the x position of the snake
            public int getHeadX()
            {
                // if the list is empty return -1, else return the x
                if (snakeBody.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return snakeBody[0].pX;
                }
            }

            // getter for the y position of the snake
            public int getHeadY()
            {
                // if the list is empty return -1, else return the y
                if (snakeBody.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return snakeBody[0].pY;
                }
            }

            // getter for the direction of the snake
            public int getDirection()
            {
                return direction;
            }

            // reset the snake
            public void Reset()
            {
                // clear the snakeBody list
                snakeBody.Clear();

                // move left
                direction = 3;

                // create default head
                bodyPart head = new bodyPart();

                // add head to list
                snakeBody.Add(head);
            }

            // change direction of snake
            public void changeDirection(int dir)
            {
                // check that the direction is one of the options
                if (dir == 0 || dir == 1 || dir == 2 || dir == 3)
                {
                    // set direction to the parameter passed
                    direction = dir;
                }
            }

            // move snake
            public void Move()
            {
                // integers for the current and new head x and y
                int currHeadX, currHeadY, newHeadX, newHeadY;

                // set the current head x and y
                currHeadX = snakeBody[0].pX;
                currHeadY = snakeBody[0].pY;

                // default the new head x and y to the current head x and y
                newHeadX = currHeadX;
                newHeadY = currHeadY;

                // switch based on the current direction of movement
                switch (direction)
                {
                    case 0:
                        // set the new head x and y for moving up
                        newHeadX = currHeadX;
                        newHeadY = currHeadY - 1;
                        break;
                    case 1:
                        // set the new head x and y for moving right
                        newHeadX = currHeadX + 1;
                        newHeadY = currHeadY;
                        break;
                    case 2:
                        // set the new head x and y for moving down
                        newHeadX = currHeadX;
                        newHeadY = currHeadY + 1;
                        break;
                    case 3:
                        // set the new head x and y for moving right
                        newHeadX = currHeadX - 1;
                        newHeadY = currHeadY;
                        break;
                }

                // create new bodyPart for the new head
                bodyPart newHead = new bodyPart(newHeadX, newHeadY, clr);

                // insert the new head into the list
                snakeBody.Insert(0, newHead);

                // remove the last element in the list
                snakeBody.RemoveAt(snakeBody.Count - 1);
            }

            // grow the snake when food is eaten
            public void Grow()
            {
                // integers for the current and new head x and y
                int currHeadX, currHeadY, newHeadX, newHeadY;

                // set the current head x and y
                currHeadX = snakeBody[0].pX;
                currHeadY = snakeBody[0].pY;

                // default the new head x and y to the current head x and y
                newHeadX = currHeadX;
                newHeadY = currHeadY;

                // switch based on the current direction of movement
                switch (direction)
                {
                    case 0:
                        // set the new head x and y for moving up
                        newHeadX = currHeadX;
                        newHeadY = currHeadY - 1;
                        break;
                    case 1:
                        // set the new head x and y for moving right
                        newHeadX = currHeadX + 1;
                        newHeadY = currHeadY;
                        break;
                    case 2:
                        // set the new head x and y for moving down
                        newHeadX = currHeadX;
                        newHeadY = currHeadY + 1;
                        break;
                    case 3:
                        // set the new head x and y for moving right
                        newHeadX = currHeadX - 1;
                        newHeadY = currHeadY;
                        break;
                }

                // create new bodyPart for the new head
                bodyPart newHead = new bodyPart(newHeadX, newHeadY, clr);

                // insert the new head into the list
                snakeBody.Insert(0, newHead);
            }

            // draw snake method
            public void DrawSnake(Graphics g)
            {
                // create brush
                SolidBrush brush = new SolidBrush(clr);

                // switch direction of head graphic based on direction
                switch (direction)
                {
                    case 0:
                        // draw head of snake
                        snakeBody[0].Draw(g, 0);
                        break;
                    case 1:
                        // draw head of snake
                        snakeBody[0].Draw(g, 1);
                        break;
                    case 2:
                        // draw head of snake
                        snakeBody[0].Draw(g, 2);
                        break;
                    case 3:
                        // draw head of snake
                        snakeBody[0].Draw(g, 3);
                        break;
                }

                // loop through the entire list
                for (int i = 1; i < snakeBody.Count; i++)
                {
                    // draw each body part from the list
                    snakeBody[i].Draw(g);
                }
            }

            // check collision with self
            public bool checkSelfCollision()
            {
                // loop through everything except the head
                for (int i = 1; i < snakeBody.Count; i++)
                {
                    // check if the head is touching any part of the list
                    if (snakeBody[i].pX == snakeBody[0].pX && snakeBody[i].pY == snakeBody[0].pY)
                    {
                        // return true if it touches
                        return true;
                    }
                }

                // return false by default
                return false;
            }

            // check collision with other snake
            public int checkOtherCollision(Snake other)
            {
                // loop through everything except the head
                for (int i = 1; i < this.snakeBody.Count; i++)
                {
                    // check if the other snake head is touching this snake
                    if (other.snakeBody[0].pX == this.snakeBody[i].pX && other.snakeBody[0].pY == this.snakeBody[i].pY)
                    {
                        return 1;
                    }
                }

                // check if both heads are colliding
                if (other.snakeBody[0].pX == this.snakeBody[0].pX && other.snakeBody[0].pY == this.snakeBody[0].pY)
                {
                    return -1;
                }

                // return 0 if there's no collision
                return 0;
            }

            // change color of the snake
            public void changeColor(Color color)
            {
                // set the color member of the snake
                this.clr = color;
            }
        }

        // food class
        public class Food
        {
            // integers for the x and y of the food
            private int fX;
            private int fY;

            // color for the color of the food
            private Color clr;

            // random member to generate random locations
            private Random randGen = new Random();

            // constructor fod food
            public Food()
            {
                // set random x and y
                fX = randGen.Next(20);
                fY = randGen.Next(20);
                
                // set default color to red
                clr = Color.Red;
            }

            // getter for the x of the food
            public int getFoodX()
            {
                return fX;
            }

            // getter for the y of the food
            public int getFoodY()
            {
                return fY;
            }

            // make new food 
            public void CreateFood()
            {
                // randomize the x and y of the food
                fX = randGen.Next(20);
                fY = randGen.Next(20);
            }

            // make new food based on where the snake is
            public void CreateFood(List<bodyPart> snakeBodyParts)
            {
                // integer variables for the random x and y
                int iX, iY;

                // randomize the x and y
                iX = randGen.Next(20);
                iY = randGen.Next(20);

                // loop through the body parts list
                for (int i = 0; i < snakeBodyParts.Count; i++)
                {
                    // if the random x and y is in the snake, call CreateFood again
                    if (iX == snakeBodyParts[i].pX && iY == snakeBodyParts[i].pY)
                    {
                        // call CreateFood until a valid random is found
                        this.CreateFood(snakeBodyParts);
                        return;
                    }
                }

                // set the food x and y to the random numbers
                fX = iX;
                fY = iY;
            }

            // food draw function
            public void Draw(Graphics g)
            {
                // create brush with the color member
                SolidBrush brush = new SolidBrush(clr);

                // draw circle for body part (20 x 20)
                g.FillEllipse(brush, fX * 20, fY * 20, 20, 20);
            }
        }

        // ProcessCmdKey fucntion for key control
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // handle WASD and arrow keys for two player
            if (twoPlayer)
            {
                // switch based on the key and set direction based on keycode
                switch (keyData)
                {
                    case Keys.W:
                        if (P1.getDirection() == 2)
                        {
                            break;
                        }
                        P1.changeDirection(0);
                        break;
                    case Keys.A:
                        if (P1.getDirection() == 1)
                        {
                            break;
                        }
                        P1.changeDirection(3);
                        break;
                    case Keys.S:
                        if (P1.getDirection() == 0)
                        {
                            break;
                        }
                        P1.changeDirection(2);
                        break;
                    case Keys.D:
                        if (P1.getDirection() == 3)
                        {
                            break;
                        }
                        P1.changeDirection(1);
                        break;
                    case Keys.Up:
                        if (P2.getDirection() == 2)
                        {
                            break;
                        }
                        P2.changeDirection(0);
                        break;
                    case Keys.Left:
                        if (P2.getDirection() == 1)
                        {
                            break;
                        }
                        P2.changeDirection(3);
                        break;
                    case Keys.Down:
                        if (P2.getDirection() == 0)
                        {
                            break;
                        }
                        P2.changeDirection(2);
                        break;
                    case Keys.Right:
                        if (P2.getDirection() == 3)
                        {
                            break;
                        }
                        P2.changeDirection(1);
                        break;
                }
            }
            // handle WASD for one player
            else
            {
                // switch based on keyData and set direction based on keycode
                switch (keyData)
                {
                    case Keys.W:
                        if (P1.getDirection() == 2)
                        {
                            break;
                        }
                        P1.changeDirection(0);
                        break;
                    case Keys.A:
                        if (P1.getDirection() == 1)
                        {
                            break;
                        }
                        P1.changeDirection(3);
                        break;
                    case Keys.S:
                        if (P1.getDirection() == 0)
                        {
                            break;
                        }
                        P1.changeDirection(2);
                        break;
                    case Keys.D:
                        if (P1.getDirection() == 3)
                        {
                            break;
                        }
                        P1.changeDirection(1);
                        break;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // check if the game is in two player mode
            if (twoPlayer)
            {
                // check if player 1 touches the food
                if (P1.getHeadX() == food.getFoodX() && P1.getHeadY() == food.getFoodY())
                {
                    // grow and create new food
                    P1.Grow();

                    // create combined list
                    List<bodyPart> allParts_P1 = new List<bodyPart>(P1.getBodyParts());
                    List<bodyPart> P2Parts_P1 = new List<bodyPart>(P2.getBodyParts());
                    allParts_P1.AddRange(P2Parts_P1);

                    // create new food
                    food.CreateFood(allParts_P1);

                    // increment current score for P1 and update it on the screen
                    iCurrScoreP1++;
                    txtcurrScoreP1.Text = iCurrScoreP1.ToString();
                }
                else
                {
                    // move if no food is eaten 
                    P1.Move();
                }

                // check if player 2 touches the food
                if (P2.getHeadX() == food.getFoodX() && P2.getHeadY() == food.getFoodY())
                {
                    // grow and create new food
                    P2.Grow();

                    // create combined list
                    List<bodyPart> allParts_P2 = new List<bodyPart>(P1.getBodyParts());
                    List<bodyPart> P2Parts_P2 = new List<bodyPart>(P2.getBodyParts());
                    allParts_P2.AddRange(P2Parts_P2);

                    // create new food
                    food.CreateFood(allParts_P2);                    

                    // increment current score for P2 and update it on the screen
                    iCurrScoreP2++;
                    txtcurrScoreP2.Text = iCurrScoreP2.ToString();
                }
                else
                {
                    // move if no food is eaten 
                    P2.Move();
                }

                // redraw graphics
                pbGame.Invalidate();

                // check if P1 goes off the board or hits itself
                if (P1.getHeadX() < 0 || P1.getHeadX() > 19 || P1.getHeadY() < 0 || P1.getHeadY() > 19 || P1.checkSelfCollision())
                {
                    // stop the timer and display game over message
                    gameTimer.Stop();                 
                    MessageBox.Show("Game Over. Player 1 Lost.");

                    // update scores on scoreboard
                    iP2Wins++;
                    txtP2Wins.Text = iP2Wins.ToString();

                    // reset curent score variables
                    iCurrScoreP1 = 0;
                    iCurrScoreP2 = 0;

                    // update scores on screen
                    txtcurrScoreP1.Text = iCurrScoreP1.ToString();
                    txtcurrScoreP2.Text = iCurrScoreP2.ToString();

                    // reset both players
                    P1.Reset();
                    P2.Reset();

                    // enable one player and two player buttons
                    btnOnePlayer.Enabled = true;
                    btnTwoPlayer.Enabled = true;

                    return;
                }

                // check if P2 goes off the board or hits itself
                if (P2.getHeadX() < 0 || P2.getHeadX() > 19 || P2.getHeadY() < 0 || P2.getHeadY() > 19 || P2.checkSelfCollision())
                {
                    // stop the timer and display game over message
                    gameTimer.Stop();
                    MessageBox.Show("Game Over. Player 2 Lost.");

                    // update scores on scoreboard
                    iP1Wins++;
                    txtP1Wins.Text = iP1Wins.ToString();

                    // reset curent score variables
                    iCurrScoreP1 = 0;
                    iCurrScoreP2 = 0;

                    // update scores on screen
                    txtcurrScoreP1.Text = iCurrScoreP1.ToString();
                    txtcurrScoreP2.Text = iCurrScoreP2.ToString();

                    // reset both players
                    P1.Reset();
                    P2.Reset();

                    // enable one player and two player buttons
                    btnOnePlayer.Enabled = true;
                    btnTwoPlayer.Enabled = true;

                    return;
                }

                // check if P1 collides with P2
                if (P1.checkOtherCollision(P2) == 1)
                {                    
                    // stop timer and display P1 win message
                    gameTimer.Stop();
                    MessageBox.Show("Player 1 Won.");

                    // update scores on scoreboard
                    iP1Wins++;
                    txtP1Wins.Text = iP1Wins.ToString();

                    // reset curent score variables
                    iCurrScoreP1 = 0;
                    iCurrScoreP2 = 0;

                    // update scores on screen
                    txtcurrScoreP1.Text = iCurrScoreP1.ToString();
                    txtcurrScoreP2.Text = iCurrScoreP2.ToString();

                    // reset both players
                    P1.Reset();
                    P2.Reset();

                    // enable one player and two player buttons
                    btnOnePlayer.Enabled = true;
                    btnTwoPlayer.Enabled = true;

                    return;
                }

                // check if P2 collides with P1
                if (P2.checkOtherCollision(P1) == 1)
                {
                    // stop timer and display P2 win message
                    gameTimer.Stop();
                    MessageBox.Show("Player 2 Won.");

                    // update scores on scoreboard
                    iP2Wins++;
                    txtP2Wins.Text = iP2Wins.ToString();

                    // reset curent score variables
                    iCurrScoreP1 = 0;
                    iCurrScoreP2 = 0;

                    // update scores on screen
                    txtcurrScoreP1.Text = iCurrScoreP1.ToString();
                    txtcurrScoreP2.Text = iCurrScoreP2.ToString();

                    // reset both players
                    P1.Reset();
                    P2.Reset();

                    // enable one player and two player buttons
                    btnOnePlayer.Enabled = true;
                    btnTwoPlayer.Enabled = true;

                    return;
                }

                // check if both heads collide
                if (P1.checkOtherCollision(P2) == -1)
                {
                    // stop timer and display both players loss message
                    gameTimer.Stop();
                    MessageBox.Show("Both players lost. Game Over.");

                    // update scores on scoreboard
                    iTies++;
                    txtTies.Text = iTies.ToString();

                    // reset curent score variables
                    iCurrScoreP1 = 0;
                    iCurrScoreP2 = 0;

                    // update scores on screen
                    txtcurrScoreP1.Text = iCurrScoreP1.ToString();
                    txtcurrScoreP2.Text = iCurrScoreP2.ToString();

                    // reset both players
                    P1.Reset();
                    P2.Reset();

                    // enable one player and two player buttons
                    btnOnePlayer.Enabled = true;
                    btnTwoPlayer.Enabled = true;

                    return;
                }

                // redraw graphics
                pbGame.Invalidate();
            }
            else
            {
                // check if P1 is in the same position as food
                if (P1.getHeadX() == food.getFoodX() && P1.getHeadY() == food.getFoodY())
                {
                    // grow player 1 and create new food object
                    P1.Grow();
                    food.CreateFood(P1.getBodyParts());

                    // increment current score for P1 and update it on the screen
                    iCurrScoreP1++;
                    txtcurrScoreP1.Text = iCurrScoreP1.ToString();
                }
                else
                {
                    // move P1 if no food was eaten
                    P1.Move();
                }

                // redraw graphics
                pbGame.Invalidate();

                // check if P1 went outside of the grid or hit itself
                if (P1.getHeadX() < 0 || P1.getHeadX() > 19 || P1.getHeadY() < 0 || P1.getHeadY() > 19 || P1.checkSelfCollision())
                {
                    // check if the player has a new high score
                    if (iCurrScoreP1 > iHighScore)
                    {
                        // set new high score and update it on the screen
                        iHighScore = iCurrScoreP1;
                        txtHighScore.Text = iHighScore.ToString();                        
                    }

                    // reset current score
                    iCurrScoreP1 = 0;

                    // stop timer and display game over message
                    gameTimer.Stop();
                    MessageBox.Show("Game Over.");

                    // enable one player and two player buttons
                    btnOnePlayer.Enabled = true;
                    btnTwoPlayer.Enabled = true;

                    // reset player 1
                    P1.Reset();
                }
            }
        }

        private void pbGame_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // colors for background
                SolidBrush greyBrush = new SolidBrush(Color.FromArgb(255, 186, 186, 186));
                SolidBrush darkBrush = new SolidBrush(Color.FromArgb(255, 100, 100, 100));

                // loops to draw checkerboard pattern in pictureBox
                for (int i = 0; i < 20; i = i + 2)
                {
                    for (int j = 0; j < 20; j = j + 2)
                    {
                        e.Graphics.FillRectangle(greyBrush, i * 20, j * 20, 20, 20);
                    }
                }

                // loops to draw checkerboard pattern in pictureBox
                for (int i = 1; i < 20; i = i + 2)
                {
                    for (int j = 1; j < 20; j = j + 2)
                    {
                        e.Graphics.FillRectangle(greyBrush, i * 20, j * 20, 20, 20);
                    }
                }

                // loops to draw checkerboard pattern in pictureBox
                for (int i = 0; i < 20; i = i + 2)
                {
                    for (int j = 1; j < 20; j = j + 2)
                    {
                        e.Graphics.FillRectangle(darkBrush, i * 20, j * 20, 20, 20);
                    }
                }

                // loops to draw checkerboard pattern in pictureBox
                for (int i = 1; i < 20; i = i + 2)
                {
                    for (int j = 0; j < 20; j = j + 2)
                    {
                        e.Graphics.FillRectangle(darkBrush, i * 20, j * 20, 20, 20);
                    }
                }

                // check if in two player mode
                if (twoPlayer)
                {
                    // draw both snakes and the food
                    P1.DrawSnake(e.Graphics);
                    food.Draw(e.Graphics);
                    P2.DrawSnake(e.Graphics);
                }
                else
                {
                    // draw player 1 snake and food
                    P1.DrawSnake(e.Graphics);
                    food.Draw(e.Graphics);
                }
            }
            catch
            {
                // output error message
                MessageBox.Show("Error updating game display.");
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // stop game timer
            gameTimer.Stop();

            // make the continue button usable
            btnContinue.Visible = true;
            btnContinue.Enabled = true;
            
            // make pause button invisible
            btnPause.Visible = false;
            btnPause.Enabled = false;

            // only allow change color when paused
            if (twoPlayer)
            {
                btnColorP2.Enabled = true;
                btnColorP1.Enabled = true;
            }
            else
            {
                btnColorP1.Enabled = true;
            }

            // enable reset button
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // check if in two player mode
            if (twoPlayer)
            {
                // reset both players
                P1.Reset();
                P2.Reset();

                // reset scores
                iCurrScoreP1 = 0;
                iCurrScoreP2 = 0;

                txtcurrScoreP1.Text = iCurrScoreP1.ToString();
                txtcurrScoreP2.Text = iCurrScoreP2.ToString();
            }
            else
            {
                // reset player 1
                P1.Reset();

                // reset score
                iCurrScoreP1 = 0;
                txtcurrScoreP1.Text = iCurrScoreP1.ToString();
            }

            // disable pause button
            btnPause.Enabled = false;
            btnPause.Visible = true;
            btnContinue.Enabled = false;
            btnContinue.Visible = false;

            // disable reset button
            btnReset.Enabled = false;

            // enable one player and two player buttons
            btnOnePlayer.Enabled = true;
            btnTwoPlayer.Enabled = true;

            // disable color buttons
            btnColorP1.Enabled = false;
            btnColorP2.Enabled = false;
        }

        private void rdSlow_CheckedChanged(object sender, EventArgs e)
        {
            // set game timer interval
            gameTimer.Interval = 500;
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            // change game timer interval
            gameTimer.Interval = 200;
        }

        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            // recreate P1 snake
            P1 = new Snake(10, 10);

            // redraw graphics
            pbGame.Invalidate();

            // set two player to false
            twoPlayer = false;

            // set the current score P2 display to false
            txtcurrScoreP2.Visible = false;
            lblcurrScoreP2.Visible = false;

            // set the ties display to false
            txtTies.Visible = false;
            lblTies.Visible = false;

            // make wins info invisible
            txtP1Wins.Visible = false;
            txtP2Wins.Visible = false;
            lblP1Wins.Visible = false;
            lblP2Wins.Visible = false;

            // enable pause button
            btnPause.Enabled = true;

            // start the game timer
            gameTimer.Start();

            // disable one player and two player buttons
            btnOnePlayer.Enabled = false;
            btnTwoPlayer.Enabled = false;

            // disable color buttons
            btnColorP1.Enabled = false;
            btnColorP2.Enabled = false;
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            // re-create the P1 and P2 snakes with different starting positions
            P1 = new Snake(8, 10);
            P2 = new Snake(12, 10);

            // set two player to true
            twoPlayer = true;

            // redraw graphics
            pbGame.Invalidate();

            // set current score labels and textLabels to true
            txtcurrScoreP2.Visible = true;
            lblcurrScoreP2.Visible = true;

            // make wins info visible
            txtP1Wins.Visible = true;
            txtP2Wins.Visible = true;
            txtTies.Visible = true;
            lblP1Wins.Visible = true;
            lblP2Wins.Visible = true;
            lblTies.Visible = true;

            // enable pause button
            btnPause.Enabled = true;

            // start game timer
            gameTimer.Start();

            // disable one player and two player buttons
            btnOnePlayer.Enabled = false;
            btnTwoPlayer.Enabled = false;

            // disable color buttons
            btnColorP1.Enabled = false;
            btnColorP2.Enabled = false;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // start game timer again
            gameTimer.Start();

            // make the continue button invisible and disabled
            btnContinue.Visible = false;
            btnContinue.Enabled = false;

            // make the pause button invisible and disabled
            btnPause.Visible = true;
            btnPause.Enabled = true;

            // disable color controls
            if (twoPlayer)
            {
                btnColorP2.Enabled = false;
                btnColorP1.Enabled = false;
            }
            else
            {
                btnColorP1.Enabled = false;
            }

            // disable reset button again
            btnReset.Enabled = false;
        }

        private void btnResetScores_Click(object sender, EventArgs e)
        {
            // reset all score data
            iHighScore = 0;
            iP2Wins = 0;
            iP1Wins = 0;
            iTies = 0;

            // write all resetted data to the screen
            txtHighScore.Text = iHighScore.ToString();
            txtP1Wins.Text = iP1Wins.ToString();
            txtP2Wins.Text = iP2Wins.ToString();
            txtTies.Text = iTies.ToString();
        }

        private void btnColorP1_Click(object sender, EventArgs e)
        {
            // create new color dialog;
            ColorDialog clrDialog = new ColorDialog();

            // change color of player 1
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                P1.changeColor(clrDialog.Color);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // make file stream
                FileStream fs = new FileStream("data.bin", FileMode.Create);

                // make binary writer
                BinaryWriter fileBW = new BinaryWriter(fs);

                // write high score variable to binary file
                fileBW.Write(iHighScore);

                // write two player scoring data
                fileBW.Write(iP1Wins);
                fileBW.Write(iP2Wins);
                fileBW.Write(iTies);

                // flush and close binary writer
                fileBW.Flush();
                fileBW.Close();
            }
            catch
            {
                // display error message
                MessageBox.Show("Error saving game data.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // make file stream
                FileStream fs = new FileStream("data.bin", FileMode.Open);

                // make new binary reader
                BinaryReader fileBR = new BinaryReader(fs);

                // read high score variable from binary file
                iHighScore = fileBR.ReadInt32();

                // read scoring data
                iP1Wins = fileBR.ReadInt32();
                iP2Wins = fileBR.ReadInt32();
                iTies = fileBR.ReadInt32();

                // write high score to screen
                txtHighScore.Text = iHighScore.ToString();

                // update scores on screen
                txtP1Wins.Text = iP1Wins.ToString();
                txtP2Wins.Text = iP2Wins.ToString();
                txtTies.Text = iTies.ToString();

                // close binary reader
                fileBR.Close();

                // redraw graphics
                pbGame.Invalidate();

                // disable wins labels and textboxes by default
                txtP1Wins.Enabled = false;
                txtP2Wins.Enabled = false;
                txtTies.Enabled = false;

                // make wins info invisible
                txtP1Wins.Visible = false;
                txtP2Wins.Visible = false;
                txtTies.Visible = false;
                lblP1Wins.Visible = false;
                lblP2Wins.Visible = false;
                lblTies.Visible = false;

                // default medium speed
                rdMedium.Checked = true;

                // disable buttons
                btnColorP1.Enabled = false;
                btnColorP2.Enabled = false;
                btnPause.Enabled = false;
                btnReset.Enabled = false;
            }
            catch
            {
                // display error message
                MessageBox.Show("Error loading game data.");
            }            
        }

        private void btnColorP2_Click(object sender, EventArgs e)
        {
            // make new color dialog
            ColorDialog clrDialog = new ColorDialog();

            // change color of player 2
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                P2.changeColor(clrDialog.Color);
            }
        }

        private void rdFast_CheckedChanged(object sender, EventArgs e)
        {
            // set the timer interval for fast
            gameTimer.Interval = 100;
        }
    }
}
