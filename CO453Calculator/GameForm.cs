using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453Forms
{
    /// <summary>
    /// This class is responsible for getting input from the player
    /// and passing it to the game. It is also responsible for 
    /// getting the result back from the game and displaying it 
    /// to the user. IT SHOULD NOT EVER DO ANY OF THE GAME LOGIC ITSELF.
    /// </summary>
    public partial class GameForm : Form
    {
        private string playerName;
        private string computerName;

        public GameForm()
        {
            InitializeComponent();
            GameStart();
        }
        
        private void SelectScissors(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("scissors.jpg");
            Game.PlayerChoice = Game.SCISSORS;
            EnablePlayButton();
        }

        private void SelectPaper(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("paper.jpg");
            Game.PlayerChoice = Game.PAPER;
            EnablePlayButton();
        }

        private void SelectStone(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("stone.jpg");
            Game.PlayerChoice = Game.STONE;
            EnablePlayButton();
        }

        /// <summary>
        /// This method is called when the play button is clicked
        /// </summary>
        private void SelectComputerChoice(object sender, EventArgs e)
        {
            Game.GetComputerChoice();
            if(Game.ComputerChoice == Game.SCISSORS)
            {
                computerPictureBox.Image = Image.FromFile("scissors.jpg");
            }
            else if(Game.ComputerChoice == Game.PAPER)
            {
                computerPictureBox.Image = Image.FromFile("paper.jpg");
            }
            else if (Game.ComputerChoice == Game.STONE)
            {
                computerPictureBox.Image = Image.FromFile("stone.jpg");
            }
            ShowResults();
        }

        private void ShowResults()
        {
            Game.WorkoutWinner();
            if (Game.Winner == playerName)
            {
                resultsLabel.Text = "The user has won!!!";

            }
            else if (Game.Winner == computerName)
            {
                resultsLabel.Text = "The computer has won!!!";
            }
            else
            {
                resultsLabel.Text = "It's a draw!!!";

            }

            computerScoreLabel.Text = "Computer = " + Game.ComputerScore;
            userScoreLabel.Text = "User = " + Game.PlayerScore;

        }

        private void EnablePlayButton()
        {
            playButton.Enabled = true;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameStart()
        {
            Game.Start();
            playerName = Game.PlayerName;
            computerName = Game.ComputerName;
        }
    }
}
