using SnakeClassic.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeClassic.PL
{
    /// <summary>
    /// Represents the main game form for the Snake Classic game.
    /// Provides the functionality and user control of the game.
    /// Manages the game state. Performs rendering of the game objects.
    /// </summary>
    public partial class GameForm : Form
    {
        /// <summary>
        /// The message is displayed to the user when the game is paused.
        /// </summary>
        private const string CONTINUE_MSG = "Press control key to continue";

        /// <summary>
        /// The message is displayed to the user when the game is going on.
        /// </summary>
        private const string PAUSE_MSG = "Press Space to pause";

        /// <summary>
        /// Predefined sleep intervals for different game levels.
        /// Higher sleep interval means slower snake movement.
        /// </summary>
        private enum LevelSleepInterval : int
        { First = 400, Second = 300, Third = 200, Fourth = 150, Fifth = 100, Sixth = 50 }

        /// <summary>
        /// Predefined borders of the game field.
        /// </summary>
        /// <remarks>As a future feature can be implemented the game field resizing in according to user's preferences.</remarks>
        private enum borders : int
        { Top = 0, Bottom = 600, Left = 0, Right = 600 }

        /// <summary>
        /// Instance of the <see cref="Food"/> class representing the current food object in the game.
        /// </summary>
        private Food food;

        /// <summary>
        /// Instance of the <see cref="Snake"/> class representing the current snake object in the game.
        /// </summary>
        private Snake snake;

        /// <summary>
        /// Interval of the current level sleep time in milliseconds.
        /// Initialized based on the selected game level by the user.
        /// </summary>
        private int currentLevelSleepInterval;

        /// <summary>
        /// Provides control over the key press events to allow or disallow snake movement.
        /// </summary>
        private bool isKeyPressAllowed = false;

        /// <summary>
        /// The group of 4 flags that indicate the current movement direction of the snake.
        /// </summary>
        private bool isMovingUp = false;
        private bool isMovingDown = false;
        private bool isMovingLeft = false;
        private bool isMovingRight = false;

        /// <summary>
        /// Instance of the <see cref="System.Windows.Forms.Timer"/> class used to provide the snake movement functionality.
        /// The key tool to bring dynamic behavior to the game.
        /// </summary>
        private Timer movementTimer = new Timer();

        /// <summary>
        /// Predefined the constant for the game field size.
        /// </summary>
        private const int FIELD_SELL = 20;

        /// <summary>
        /// Predefined the constant for the single cell size of the snake and the food.
        /// </summary>
        private const int SINGLE_SELL = 18;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameForm"/> class  and sets up the game panel.
        /// initializes the snake and food objects.
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            mainGamePanel.Width = (int)borders.Right;
            mainGamePanel.Height = (int)borders.Bottom;
            mainGamePanel.BackColor = Color.Black;
            scoreValueLabel.Text = "0";
            food = new Food((int)borders.Top, (int)borders.Bottom,
                    (int)borders.Left, (int)borders.Right, FIELD_SELL);
            InitSnake();
        }

        /// <summary>
        /// Initializes the snake with a default length, head position, and predefined cell size.
        /// </summary>
        private void InitSnake()
        {
            snake = new Snake(3, 100, 200, FIELD_SELL);
        }

        /// <summary>
        /// Clears the current movement state of the snake.
        /// </summary>
        private void ClearMovementState()
        {
            movementTimer.Tick -= MoveUpTick;
            movementTimer.Tick -= MoveDownTick;
            movementTimer.Tick -= MoveLeftTick;
            movementTimer.Tick -= MoveRightTick;
            isMovingUp = false;
            isMovingDown = false;
            isMovingRight = false;
            isMovingLeft = false;
        }

        /// <summary>
        /// Resets the game state after "Game Over".
        /// </summary>
        private void GameOverState()
        {
            movementTimer.Stop();
            ClearMovementState();
            isKeyPressAllowed = false;
            ProcessGameResult();
            clearRecordToolStripMenuItem.Enabled = true;
            levelValueLabel.Text = "  ";
            scoreValueLabel.Text = "0";
            pauseLabel.Text = "GAME OVER";
        }

        /// <summary>
        /// Form the game result message based on the current score.
        /// Compares the current score with the best score stored in settings.
        /// Sets the best score if the current score exceeds it.
        /// Outputs the game result message to the user.
        /// </summary>
        private void ProcessGameResult()
        {
            string resutlMsg = $"\tGAME OVER!\n\n\t Score: {scoreValueLabel.Text}";
            if (Properties.Settings.Default.BestScore < Int32.Parse(scoreValueLabel.Text))
            {
                Properties.Settings.Default.BestScore = Int32.Parse(scoreValueLabel.Text);
                Properties.Settings.Default.Save();
                recordValueLabel.Text = Properties.Settings.Default.BestScore.ToString();
                resutlMsg += "\n\n\tCongrats! You've got a new record";
            }
            MessageBox.Show(resutlMsg);
        }

        /// <summary>
        /// Checks if the snake has collided with itself.
        /// Invokes the GameOverState method if a collision is detected.
        /// </summary>
        private void CheckSnakeSelfCollide()
        {
            if (snake.IsSelfCollided())
            {
                GameOverState();
            }
        }

        /// <summary>
        /// Checks if the snake has caught the food.
        /// Increases the score and generates a new food location if caught.
        /// </summary>
        private void CheckCatchFood()
        {
            if (snake.IsFoodCatched(food.Location))
            {
                snake.GrowSnake();
                IncreaseScore();
                ManageNewFoodLocation();
            }
        }

        /// <summary>
        /// Processes the generation of a new food location. 
        /// If the new food location occurs on the snake's body generates a new location again recursively.
        /// </summary>
        private void ManageNewFoodLocation()
        {
            food.GenerateNewFoodLocation((int)borders.Top, (int)borders.Bottom,
                    (int)borders.Left, (int)borders.Right, FIELD_SELL);
            if (snake.IsNewFoodAppearsOnSnakeBody(food.Location))
            {
                ManageNewFoodLocation();
            }
        }

        /// <summary>
        /// Processes the increase of the score by one unit.
        /// Displays the updated score in the score value label.
        /// </summary>
        public void IncreaseScore()
        {
            int currentScore = Convert.ToInt32(scoreValueLabel.Text);
            currentScore++;
            scoreValueLabel.Text = Convert.ToString(currentScore);
        }

        /// <summary>
        /// Renders the food on the game panel. 
        /// Object is drawn using the System.Drawing.Graphics class.
        /// </summary>
        private void DrawFood()
        {
            using (Graphics graphics = mainGamePanel.CreateGraphics())
            {
                graphics.FillRectangle(Brushes.LightGreen, food.Location.X, food.Location.Y, SINGLE_SELL, SINGLE_SELL);
            }
        }

        /// <summary>
        /// Renders the snake on the game panel. 
        /// Invokes the DrawFood method to draw the food object during the snake rendering.
        /// Objects are drawn using the System.Drawing.Graphics class.
        /// </summary>
        private void DrawSnake()
        {
            using (Graphics graphics = mainGamePanel.CreateGraphics())
            {
                Refresh();
                DrawFood();

                graphics.FillRectangle(Brushes.Orange, snake.SnakeBody[0].X, snake.SnakeBody[0].Y, SINGLE_SELL, SINGLE_SELL);
                for (int i = 0; i < snake.SnakeBody.Count; i++)
                {
                    if (snake.SnakeBody[i] != null)
                    {
                        graphics.FillRectangle(Brushes.Orange, snake.SnakeBody[i].X, snake.SnakeBody[i].Y, SINGLE_SELL, SINGLE_SELL);
                    }
                }
            }
        }

        /// <summary>
        /// Starts the snake movement in the upward direction.
        /// Sets timer interval based on the current level sleep interval.
        /// Starts the movement timer and assigns the MoveUpTick method to handle the timer ticks.
        /// </summary>
        private void StartMovingUp()
        {
            ClearMovementState();

            isMovingUp = true;
            movementTimer.Interval = currentLevelSleepInterval;
            movementTimer.Tick += MoveUpTick;
            movementTimer.Start();
        }

        /// <summary>
        /// Provides a single step movement of the snake in the upward direction.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveUpTick(object sender, EventArgs e)
        {
            if (isMovingUp)
            {
                CheckCatchFood();
                CheckSnakeSelfCollide();
                // Top border collision check
                if (snake.SnakeBody[0].Y == (int)borders.Top)
                {
                    GameOverState();
                }
                else
                {
                    snake.MakeOneStepUp();
                    DrawSnake();
                }
            }
        }

        /// <summary>
        /// Starts the snake movement in the downward direction.
        /// Sets timer interval based on the current level sleep interval.
        /// Starts the movement timer and assigns the MoveDownTick method to handle the timer ticks.
        /// </summary>
        private void StartMovingDown()
        {
            ClearMovementState();

            isMovingDown = true;
            movementTimer.Interval = currentLevelSleepInterval;
            movementTimer.Tick += MoveDownTick;
            movementTimer.Start();
        }

        /// <summary>
        /// Provides a single step movement of the snake in the downward direction.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveDownTick(object sender, EventArgs e)
        {
            if (isMovingDown)
            {
                CheckCatchFood();
                CheckSnakeSelfCollide();
                // Bottom border collision check
                if (snake.SnakeBody[0].Y == (int)borders.Bottom - FIELD_SELL)
                {
                    GameOverState();
                }
                else
                {
                    snake.MakeOneStepDown();
                    DrawSnake();
                }
            }
        }

        /// <summary>
        /// Starts the snake movement in the left direction.
        /// Sets timer interval based on the current level sleep interval.
        /// Starts the movement timer and assigns the MoveLeftTick method to handle the timer ticks.
        /// </summary>
        private void StartMovingLeft()
        {
            ClearMovementState();

            isMovingLeft = true;
            movementTimer.Interval = currentLevelSleepInterval;
            movementTimer.Tick += MoveLeftTick;
            movementTimer.Start();
        }

        /// <summary>
        /// Provides a single step movement of the snake in the left direction.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveLeftTick(object sender, EventArgs e)
        {
            if (isMovingLeft)
            {
                CheckCatchFood();
                CheckSnakeSelfCollide();
                // Left border collision check
                if (snake.SnakeBody[0].X == (int)borders.Left)
                {
                    GameOverState();
                }
                else
                {
                    snake.MakeOneStepLeft();
                    DrawSnake();
                }
            }
        }

        /// <summary>
        /// Starts the snake movement in the right direction.
        /// Sets timer interval based on the current level sleep interval.
        /// Starts the movement timer and assigns the MoveRightTick method to handle the timer ticks.
        /// </summary>
        private void StartMovingRight()
        {
            ClearMovementState();

            isMovingRight = true;
            movementTimer.Interval = currentLevelSleepInterval;
            movementTimer.Tick += MoveRightTick;
            movementTimer.Start();
        }

        /// <summary>
        /// Provides a single step movement of the snake in the right direction.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveRightTick(object sender, EventArgs e)
        {
            if (isMovingRight)
            {
                CheckCatchFood();
                CheckSnakeSelfCollide();
                // Right border collision check
                if (snake.SnakeBody[0].X == (int)borders.Right - FIELD_SELL)
                {
                    GameOverState();
                }
                else
                {
                    snake.MakeOneStepRight();
                    DrawSnake();
                }
            }
        }

        /// <summary>
        /// Provides the key event handler for user game control.
        /// Invokes the appropriate movement methods based on the key pressed.
        /// Performs the pause functionality when the space key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (isKeyPressAllowed)
            {
                if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                    && snake.SnakeBody[0].Y <= snake.SnakeBody[1].Y)
                {
                    StartMovingUp();
                    if (movementTimer.Enabled)
                    {
                        pauseLabel.Text = PAUSE_MSG;
                    }
                }
                if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                    && snake.SnakeBody[0].Y >= snake.SnakeBody[1].Y)
                {
                    StartMovingDown();
                    if (movementTimer.Enabled)
                    {
                        pauseLabel.Text = PAUSE_MSG;
                    }
                }
                if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                    && snake.SnakeBody[0].X <= snake.SnakeBody[1].X)
                {
                    StartMovingLeft();
                    if (movementTimer.Enabled)
                    {
                        pauseLabel.Text = PAUSE_MSG;
                    }
                }
                if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                    && snake.SnakeBody[0].X >= snake.SnakeBody[1].X)
                {
                    StartMovingRight();
                    if (movementTimer.Enabled)
                    {
                        pauseLabel.Text = PAUSE_MSG;
                    }
                }
                if (e.KeyCode == Keys.Space && movementTimer.Enabled)
                {
                    pauseLabel.Text = CONTINUE_MSG;
                    movementTimer.Stop();
                }
            }
        }

        /// <summary>
        /// Performs the game start functionality when the "Start" menu item is clicked.
        /// Provides the level selection dialog to the user.
        /// Sets the initial game state, invokes methods to start the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movementTimer = new Timer();
            LevelForm levelForm = new LevelForm();
            levelForm.ShowDialog();

            switch (levelForm.SelectedLevel)
            {
                case LevelForm.LEVEL_1:
                    currentLevelSleepInterval = (int)LevelSleepInterval.First;
                    levelValueLabel.Text = LevelForm.LEVEL_1;
                    break;
                case LevelForm.LEVEL_2:
                    currentLevelSleepInterval = (int)LevelSleepInterval.Second;
                    levelValueLabel.Text = LevelForm.LEVEL_2;
                    break;
                case LevelForm.LEVEL_3:
                    currentLevelSleepInterval = (int)LevelSleepInterval.Third;
                    levelValueLabel.Text = LevelForm.LEVEL_3;
                    break;
                case LevelForm.LEVEL_4:
                    currentLevelSleepInterval = (int)LevelSleepInterval.Fourth;
                    levelValueLabel.Text = LevelForm.LEVEL_4;
                    break;
                case LevelForm.LEVEL_5:
                    currentLevelSleepInterval = (int)LevelSleepInterval.Fifth;
                    levelValueLabel.Text = LevelForm.LEVEL_5;
                    break;
                case LevelForm.LEVEL_6:
                    currentLevelSleepInterval = (int)LevelSleepInterval.Sixth;
                    levelValueLabel.Text = LevelForm.LEVEL_6;
                    break;
                default:
                    currentLevelSleepInterval = (int)LevelSleepInterval.First;
                    levelValueLabel.Text = LevelForm.LEVEL_1;
                    break;
            }

            InitSnake();
            DrawSnake();
            isKeyPressAllowed = true;
            clearRecordToolStripMenuItem.Enabled = false;
            // Initial movement direction
            StartMovingUp();
            pauseLabel.Text = PAUSE_MSG;
        }

        /// <summary>
        /// Provides the functionality to clear the best score record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("\tAre you sure??",
                "Confirm Delete!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Properties.Settings.Default.BestScore = 0;
                Properties.Settings.Default.Save();
                recordValueLabel.Text = "0";
            }
            movementTimer.Start();
        }

        /// <summary>
        /// Pauses the game when the "Game" menu item is clicked to open.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isKeyPressAllowed)
            {
                movementTimer.Stop();
                pauseLabel.Text = CONTINUE_MSG;
            }
        }

        /// <summary>
        /// Ends the game safely when the user closes the <see cref="GameForm"/> after confirmation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isKeyPressAllowed)
            {
                movementTimer.Stop();
                var confirmResult = MessageBox.Show("\tDo you really want to interrupt the game?",
                    "Confirm Exit!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    GameOverState();
                    Close();
                }
                else if (confirmResult == DialogResult.No)
                {
                    e.Cancel = true;
                    movementTimer.Start();
                    pauseLabel.Text = PAUSE_MSG;
                }
            }
        }

        /// <summary>
        /// Reads the best score from the settings and displays it when the <see cref="GameForm"/> loads. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            recordValueLabel.Text = Properties.Settings.Default.BestScore.ToString();
        }
    }
}
