using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data;
using System.Diagnostics;
using System.Media;

namespace RockPaperScissors
{
    public partial class MainGame : Form
    {
        //Global variables
        int rounds = 0;
        int you_points = 0;
        int pc_points = 0;
        string pc;
        string you;
        Random random = new Random();



        public MainGame()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainGame_Load);
            string soundFile = @"C:\Users\noutz\OneDrive\Documentos\TI\Projetos\CSharp.NET\RockPaperScissors\Sounds\start.wav";
            SoundPlayer player = new SoundPlayer(soundFile);
            player.Play();

            //Attach MouseDown handlers for dragging the form
            WinTitle.MouseDown += new MouseEventHandler(MainGame_MouseMove);
            WinName.MouseDown += new MouseEventHandler(MainGame_MouseMove);
            WinIcon.MouseDown += new MouseEventHandler(MainGame_MouseMove);
            this.MouseDown += new MouseEventHandler(MainGame_MouseMove);
        }

        //Import methods for window manipulation
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //Constants for window manipulation messages
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void MainGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Check if the left button is pressed
            {
                ReleaseCapture(); //Release the mouse capture from the form
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); //Send message to move the form

            }
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            // Create rounded corners for the window
            int radius = 20; // Radius of the rounded corners.
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseAllFigures();
            this.Region = new Region(path); // Apply the rounded path to the form’s region.
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimize the form
        }

        private void BtnGit_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/theuslimaa";

            try
            {
                Process.Start(url);
            }
            catch
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
        }

        private void BtnLink_Click(object sender, EventArgs e)
        {
            string url = "https://linkedin.com/in/theuslimaa";

            try
            {
                Process.Start(url);
            }
            catch
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            WinRounds.BringToFront();
            WinStart.SendToBack();
            WinStart.Height = (WinStart.Height == 5) ? WinStart.Height = 345 : 5;
            string soundFile = @"C:\Users\noutz\OneDrive\Documentos\TI\Projetos\CSharp.NET\RockPaperScissors\Sounds\button.wav";
            SoundPlayer player = new SoundPlayer(soundFile);
            player.Play();
        }

        private void BtnRnd3_Click(object sender, EventArgs e)
        {
            WinGame.BringToFront();
            WinRounds.SendToBack();
            WinRounds.Height = (WinRounds.Height == 5) ? WinRounds.Height = 345 : 5;
            Choose_Rounds("rounds3");
            string soundFile = @"C:\Users\noutz\OneDrive\Documentos\TI\Projetos\CSharp.NET\RockPaperScissors\Sounds\button.wav";
            SoundPlayer player = new SoundPlayer(soundFile);
            player.Play();
        }

        private void BtnRnd5_Click(object sender, EventArgs e)
        {
            WinGame.BringToFront();
            WinRounds.SendToBack();
            WinRounds.Height = (WinRounds.Height == 5) ? WinRounds.Height = 345 : 5;
            Choose_Rounds("rounds5");
            string soundFile = @"C:\Users\noutz\OneDrive\Documentos\TI\Projetos\CSharp.NET\RockPaperScissors\Sounds\button.wav";
            SoundPlayer player = new SoundPlayer(soundFile);
            player.Play();
        }

        private void BtnRnd7_Click(object sender, EventArgs e)
        {
            WinGame.BringToFront();
            WinRounds.SendToBack();
            WinRounds.Height = (WinRounds.Height == 5) ? WinRounds.Height = 345 : 5;
            Choose_Rounds("rounds7");
            string soundFile = @"C:\Users\noutz\OneDrive\Documentos\TI\Projetos\CSharp.NET\RockPaperScissors\Sounds\button.wav";
            SoundPlayer player = new SoundPlayer(soundFile);
            player.Play();
        }

        private void Choose_Rounds(string r)
        {
            if (r == "rounds3")
            {
                rounds += 3;
            }
            else if (r == "rounds5")
            {
                rounds += 5;
            }
            else if (r == "rounds7")
            {
                rounds += 7;
            }
        }
        private void Game(string i)
        {
            if (rounds > 0)
            {
                Console.Write(rounds);
                string[] options = { "rock", "paper", "scissors" };
                pc = options[random.Next(options.Length)];
                Dictionary<string, string> defeats = new Dictionary<string, string>
                {
                    { "rock", "scissors"},
                    { "paper", "rock" },
                    { "scissors", "paper" }
                };
                you = i;

                if (i == pc)
                {

                }
                else if (defeats[i] == pc)
                {
                    you_points += 10;
                    TxtPlayer.Text = you_points.ToString();

                }
                else
                {
                    pc_points += 10;
                    TxtPlayer.Text = you_points.ToString();
                }
            }
            else
            {
                EndGame(i);
            }

            rounds -= 1;
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            Game("rock");

        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            Game("paper");
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            Game("scissors");
        }

        private void EndGame(string i)
        {
            WinEndGame.BringToFront();
            WinGame.SendToBack();
            WinGame.Height = (WinGame.Height == 5) ? WinGame.Height = 345 : 5;

            if (you_points > pc_points)
            {
                TxtEndGame.Text = "YOU WIN!";
                string soundFile = @"C:\Users\noutz\OneDrive\Documentos\TI\Projetos\CSharp.NET\RockPaperScissors\Sounds\youwin.wav";
                SoundPlayer player = new SoundPlayer(soundFile);
                player.Play();
            }
            else if (you_points.Equals(pc_points))
            {
                TxtEndGame.Text = "DRAW GAME!";
                string soundFile = @"C:\Users\noutz\OneDrive\Documentos\TI\Projetos\CSharp.NET\RockPaperScissors\Sounds\drawgame.wav";
                SoundPlayer player = new SoundPlayer(soundFile);
                player.Play();
            }
            else
            {
                TxtEndGame.Text = "YOU LOSE!";
                string soundFile = @"C:\Users\noutz\OneDrive\Documentos\TI\Projetos\CSharp.NET\RockPaperScissors\Sounds\youlose.wav";
                SoundPlayer player = new SoundPlayer(soundFile);
                player.Play();
            }
        }



        private void BtnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit the application
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            rounds = 0;
            you_points = 0;
            TxtPlayer.Text = you_points.ToString();
            pc_points = 0;
            TxtPlayer.Text = you_points.ToString();


            WinGame.BringToFront();
            WinEndGame.SendToBack();
            WinEndGame.Height = (WinGame.Height == 5) ? WinGame.Height = 345 : 5;
        }

        private void BtnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
