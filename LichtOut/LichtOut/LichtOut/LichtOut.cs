using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LichtOut
{
    enum Sounds
    {
        Click = 0,
        GameWon = 1,
        HighScoreChange = 2
    }
    public partial class LichtOut : Form
    {
        private const string HIGHSCORE_FILE_PATH = @"Resources/HighScores.txt";
        private const char SEPARATOR = '|';
        private GameMode mode;
        private LightTile[,] grid;
        private Stopwatch stopwatch = new Stopwatch();
        private int clicks;
        private static SoundPlayer[] sounds = { 
            new SoundPlayer(@"Resources/click.wav"), 
            new SoundPlayer(@"Resources/taDa.wav"), 
            new SoundPlayer(@"Resources/highscoreChange.wav") };

        public LichtOut()
        {
            InitializeComponent();
        }

        private void game_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "EASY")
            {
                this.mode = GameMode.EASY;
            }
            else
            {
                this.mode = GameMode.CLASSIC;
            }
            this.pnl_chooseTileColor.Visible = true;
        }

        private void rb_on_color(object sender, EventArgs e)
        {
            RadioButton input = (RadioButton)sender;

            switch (input.Text)
            {
                case "YELLOW":
                    this.pnl_OnLight.BackColor = Color.LightYellow;
                    break;
                case "GREEN":
                    this.pnl_OnLight.BackColor = Color.LightGreen;
                    break;
                case "BLUE":
                    this.pnl_OnLight.BackColor = Color.LightBlue;
                    break;
                case "PINK":
                    this.pnl_OnLight.BackColor = Color.LightPink;
                    break;
                default:
                    break;
            }
        }

        private void rb_off_color(object sender, EventArgs e)
        {
            RadioButton input = (RadioButton)sender;

            switch (input.Text)
            {
                case "GRAY":
                    this.pnl_OffLight.BackColor = Color.DarkGray;
                    break;
                case "DARK GREEN":
                    this.pnl_OffLight.BackColor = Color.Green;
                    break;
                case "DARK BLUE":
                    this.pnl_OffLight.BackColor = Color.Blue;
                    break;
                case "DEEP PINK":
                    this.pnl_OffLight.BackColor = Color.DeepPink;
                    break;
                default:
                    break;
            }
        }

        private void btn_sartGame_Click(object sender, EventArgs e)
        {
            Grid gameGrid = new Grid(this.mode, this.pnl_OnLight.BackColor, this.pnl_OffLight.BackColor);
            this.grid = gameGrid.CreateGrid();
            this.clicks = 0;
            GetNeighbours();
            Random rand = new Random();
            while (AllLightsAreOff())
                CreatePattern(this.grid, rand);


            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    this.pnl_startGame.Controls.Add(this.grid[row, col]);
                }
            }

            Button btn_back = new Button();
            btn_back.Left = 12;
            btn_back.Top = this.Height - 90;
            btn_back.Width = 200;
            btn_back.Height = 40;
            btn_back.Text = "GO BACK";
            btn_back.Font = new System.Drawing.Font("Palatino Linotype", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_back.Click += new EventHandler(this.GoBack);

            this.pnl_startGame.Controls.Add(btn_back);

            this.pnl_startGame.Visible = true;
            this.stopwatch.Start();
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.FinishGame();
        }

        private static void CreatePattern(LightTile[,] grid, Random rand)
        {
            int number;
            for (int row = 0; row < grid.GetLength(0) * 2; row++)
            {
                for (int col = 0; col < grid.GetLength(1) * 2; col++)
                {
                    number = rand.Next(0, 200);
                    if (number % 5 == 0)
                        grid[row % grid.GetLength(0), col % grid.GetLength(1)]
                            .SwitchLight();
                }
            }
        }

        private void GetNeighbours()
        {
            for (int row = 0; row < this.grid.GetLength(0); row++)
            {
                for (int col = 0; col < this.grid.GetLength(1); col++)
                {
                    this.grid[row, col].Click += new EventHandler(this.SwitchLight);

                    this.grid[row, col].Neighbours.Add(this.grid[row, col]);
                    if (row > 0)
                        this.grid[row, col].Neighbours.Add(this.grid[row - 1, col]);
                    if (row < this.grid.GetLength(0) - 1)
                        this.grid[row, col].Neighbours.Add(this.grid[row + 1, col]);
                    if (col > 0)
                        this.grid[row, col].Neighbours.Add(this.grid[row, col - 1]);
                    if (col < this.grid.GetLength(1) - 1)
                        this.grid[row, col].Neighbours.Add(this.grid[row, col + 1]);
                }
            }
        }

        private void SwitchLight(object sender, EventArgs e)
        {
            try
            {
                sounds[(int)Sounds.Click].Play();
            }
            catch (FileLoadException)
            {
                Console.WriteLine("File load ex.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            
            LightTile tempTile = (LightTile)sender;
            tempTile.SwitchLight();

            if (AllLightsAreOff() && clicks > 0)
            {
                try
                {
                    sounds[(int)Sounds.GameWon].Play();
                }
                catch (FileLoadException)
                {
                    Console.WriteLine("File load ex.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found.");
                }

                FinishGame();
            }
            ++clicks;
        }



        private void FinishGame()
        {
            this.stopwatch.Stop();

            double elapsedTime = this.stopwatch.Elapsed.TotalSeconds;
            StringBuilder result = new StringBuilder();

            if (AllLightsAreOff())
            {
                ShowForm(elapsedTime, this.clicks);
            }

            this.stopwatch.Reset();

            this.pnl_startGame.Controls.Clear();
            this.pnl_startGame.Visible = false;
            this.pnl_chooseTileColor.Visible = false;
        }

        private bool AllLightsAreOff()
        {
            foreach (var tile in this.grid)
            {
                if (tile.On)
                    return false;
            }
            return true;
        }

        public static string ShowForm(double time, int score)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            StringBuilder displayScore = new StringBuilder();
            displayScore.AppendFormat("Seconds:\t\t{0:F3}", time);
            displayScore.AppendLine();
            displayScore.AppendFormat("Clicks:\t\t{0}", score);
            displayScore.AppendLine();
            displayScore.AppendLine();
            displayScore.AppendFormat("Enter your nickname:");

            Label scoreLabel = new Label();
            scoreLabel.Text = displayScore.ToString();
            scoreLabel.MinimumSize = new Size(200, 100);

            TextBox textBox = new TextBox() { Left = 4, Top = 60, Width = 272 };
            Button confirmation = new Button() { Text = "Ok", Left = 180, Width = 100, Top = 85 };

            Action<string> onBetterHighscore = BeatPreviousHighscore;
            confirmation.Click += (sender, e) => 
            { HandleUserHighscore(
                (String.IsNullOrWhiteSpace(textBox.Text) ? "anonymous" : textBox.Text), time, score, onBetterHighscore); };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(scoreLabel);

            prompt.AcceptButton = confirmation;

            prompt.ShowDialog();
            return prompt.Text;
        }

        private static void BeatPreviousHighscore(string name)
        {
            try
            {
                sounds[(int)Sounds.HighScoreChange].Play();
            }
            catch (FileLoadException)
            {
                Console.WriteLine("File load ex.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

            MessageBox.Show(
                string.Format("Congrats, {0}! You beat your previous HIGHSCORE!", name), 
                "NEW HIGHSCORE", MessageBoxButtons.OK);
        }

        private static void HandleUserHighscore(string playerName, double currentTime, int currentScore, Action<string> onBetterHighscore)
        {
            //create the file if it doesn't exist
            OpenOrCreateHighscoreFile(HIGHSCORE_FILE_PATH);

            //add player to dictionary
            var highscores = new Dictionary<string, Tuple<double, int>>();
            highscores[playerName] = new Tuple<double, int>(currentTime, currentScore);

            //read file and push players in dictionary
            using (var fs = File.Open(HIGHSCORE_FILE_PATH, FileMode.Open, FileAccess.ReadWrite))
            {
                var reader = new StreamReader(fs);

                bool fileIsEmpty = true;
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    fileIsEmpty = false;
                    string name = GetNameFromLine(line);
                    double prevTime = GetTimeFromLine(line);
                    int prevScore = GetScoreFromLine(line);

                    highscores[name] = new Tuple<double, int>(prevTime, prevScore);

                    if (playerName == name)
                    {
                        if (IfUserHasBetterScore(currentScore, prevScore) ||
                            IfUserHasBetterTime(currentTime, prevTime))
                        {
                            highscores[name] = SaveNewPlayerHighscore(currentTime, currentScore);
                            onBetterHighscore(playerName);
                        }
                    }
                }

                if (fileIsEmpty)
                {
                    //write the first entry
                    var writer = new StreamWriter(fs);

                    string currentLineToAppendToFile = string.Format("{1}{0}{2}{0}{3}", SEPARATOR, playerName, currentTime, currentScore);
                    writer.WriteLine(currentLineToAppendToFile);

                    writer.Close();
                }
                reader.Close();
            }

            //clear file content
            File.WriteAllText(HIGHSCORE_FILE_PATH, string.Empty);

            var writerStream = new StreamWriter(HIGHSCORE_FILE_PATH);

            var sortedHighscrores = highscores.OrderBy(p => p.Key) //by name
                        .ThenBy(p => p.Value.Item2) //then by score
                        .ThenBy(p => p.Value.Item1) //then by time
                        .Select(p => new
                        {
                            nickName = p.Key,
                            playerTime = p.Value.Item1,
                            playerScore = p.Value.Item2
                        });

            //write new highscores
            foreach (var playerInfo in sortedHighscrores)
            {
                writerStream.WriteLine(string.Format("{1}{0}{2}{0}{3}", SEPARATOR, playerInfo.nickName, playerInfo.playerTime, playerInfo.playerScore));
            }

            writerStream.Close();
        }

        private static Tuple<double, int> SaveNewPlayerHighscore(double currentTime, int currentScore)
        {
            var newHighscoreResult = new Tuple<double, int>(currentTime, currentScore);
            return newHighscoreResult;
        }

        private static bool IfUserHasBetterScore(int currentScore, int prevScore)
        {
            if (prevScore <= currentScore)
            {
                return false;
            }
            return true;
        }

        private static bool IfUserHasBetterTime(double currentTime, double prevTime)
        {
            if (prevTime <= currentTime)
            {
                return false;
            }
            return true;
        }

        private static string GetNameFromLine(string line)
        {
            int startOfName = 0;
            int nameLength = line.IndexOf(SEPARATOR);

            string name = line.Substring(startOfName, nameLength);
            return name;
        }

        private static double GetTimeFromLine(string line)
        {
            int startOfTimeIndex = line.IndexOf(SEPARATOR) + 1;
            int endOfTimeIndex = line.LastIndexOf(SEPARATOR);
            int lengthOfTime = endOfTimeIndex - startOfTimeIndex;

            string time = line.Substring(startOfTimeIndex, lengthOfTime);
            double timeExact = double.Parse(time);
            return timeExact;
        }

        private static int GetScoreFromLine(string line)
        {
            int startOfScoreIndex = line.LastIndexOf(SEPARATOR) + 1;

            string score = line.Substring(startOfScoreIndex);
            int scoreExact = int.Parse(score);
            return scoreExact;
        }

        private static void OpenOrCreateHighscoreFile(string HIGHSCORE_FILE_PATH)
        {
            new FileStream(HIGHSCORE_FILE_PATH, FileMode.OpenOrCreate).Close();
        }
    }
}
