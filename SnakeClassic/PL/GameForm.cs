using SnakeClassic.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeClassic.PL
{
    public partial class GameForm : Form
    {
        Food food;
        Snake snake;
        private Timer movementTimer = new Timer();
        private enum LevelSleepInterval : int
        { First = 400, Second = 300, Third = 200, Fourth = 150, Fifth = 100, Sixth = 50 }
        private int currentLevelSleepInterval;
        private bool isKeyPressAllowed = false;
        private bool isMovingUp = false;
        private bool isMovingDown = false;
        private bool isMovingLeft = false;
        private bool isMovingRight = false;

        private enum borders : int
        { Top = 0, Bottom = 600, Left = 0, Right = 600 }
        private const int FIELD_SELL = 20;
        private const int SINGLE_SELL = 18;
        private const string PAUSE_MSG = "Press Space to pause";
        private const string CONTINUE_MSG = "Press control key to continue";

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

        private void InitSnake()
        {
            snake = new Snake(3, 100, 200, FIELD_SELL);
        }

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

        private void CheckSnakeSelfCollide()
        {
            if (snake.IsSelfCollided())
            {
                GameOverState();
            }
        }

        private void CheckCatchFood()
        {
            if (snake.IsFoodCatched(food.Location))
            {
                snake.GrowSnake();
                IncreaseScore();
                ManageNewFoodLocation();
            }
        }

        private void ManageNewFoodLocation()
        {
            food.GenerateNewFoodLocation((int)borders.Top, (int)borders.Bottom,
                    (int)borders.Left, (int)borders.Right, FIELD_SELL);
            if (snake.IsNewFoodAppearsOnSnakeBody(food.Location))
            {
                ManageNewFoodLocation();
            }
        }
        public void IncreaseScore()
        {
            int currentScore = Convert.ToInt32(scoreValueLabel.Text);
            currentScore++;
            scoreValueLabel.Text = Convert.ToString(currentScore);
        }

        private void DrawFood()
        {
            using (Graphics graphics = mainGamePanel.CreateGraphics())
            {
                graphics.FillRectangle(Brushes.LightGreen, food.Location.X, food.Location.Y, SINGLE_SELL, SINGLE_SELL);
            }
        }

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

        private void StartMovingUp()
        {
            ClearMovementState();

            isMovingUp = true;
            movementTimer.Interval = currentLevelSleepInterval;
            movementTimer.Tick += MoveUpTick;
            movementTimer.Start();
        }

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

        private void StartMovingDown()
        {
            ClearMovementState();

            isMovingDown = true;
            movementTimer.Interval = currentLevelSleepInterval;
            movementTimer.Tick += MoveDownTick;
            movementTimer.Start();
        }

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
        private void StartMovingLeft()
        {
            ClearMovementState();

            isMovingLeft = true;
            movementTimer.Interval = currentLevelSleepInterval;
            movementTimer.Tick += MoveLeftTick;
            movementTimer.Start();
        }

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

        private void StartMovingRight()
        {
            ClearMovementState();

            isMovingRight = true;
            movementTimer.Interval = currentLevelSleepInterval;
            movementTimer.Tick += MoveRightTick;
            movementTimer.Start();
        }

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


        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isKeyPressAllowed)
            {
                movementTimer.Stop();
                pauseLabel.Text = CONTINUE_MSG;
            }
        }

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

        private void GameForm_Load(object sender, EventArgs e)
        {
            recordValueLabel.Text = Properties.Settings.Default.BestScore.ToString();
        }
    }
}
