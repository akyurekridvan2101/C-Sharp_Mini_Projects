using System;
using System.Drawing;
using System.Windows.Forms;

namespace XoxGame
{
    public partial class Form1 : Form
    {
        // Variable to keep track of the current player
        private int currentPlayer = 1;

        public Form1()
        {
            InitializeComponent();

            // Set initial background colors for players
            this.Player1.BackColor = Color.Green;
            this.Player2.BackColor = Color.Red;
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        // Similar event handlers for other buttons...

        // Event handler for the restart button
        private void RestartGame_Click(object sender, EventArgs e)
        {
            ResetGame_Click(sender, e);
        }

        // Checks if the game has ended
        private void CheckIfGameEnded()
        {
            // Checks all possible winning combinations and if the game is a draw
            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
                DeclareWinnerAndEndGame();
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
                DeclareWinnerAndEndGame();
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
                DeclareWinnerAndEndGame();
            else if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "")
                DeclareWinnerAndEndGame();
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "")
                DeclareWinnerAndEndGame();
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "")
                DeclareWinnerAndEndGame();
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
                DeclareWinnerAndEndGame();
            else if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "")
                DeclareWinnerAndEndGame();
            else if (A1.Text != "" && A2.Text != "" && A3.Text != "" && B1.Text != "" && B2.Text != "" && B3.Text != "" && C1.Text != "" && C2.Text != "" && C3.Text != "")
            {
                MessageBox.Show("It's a draw!");
                DisableAllButtons();
            }
        }

        // Declares the winner and ends the game
        private void DeclareWinnerAndEndGame()
        {
            if (currentPlayer == 1)
                MessageBox.Show("Player 1 Wins!");
            else
                MessageBox.Show("Player 2 Wins!");

            DisableAllButtons();
        }

        // Event handler for button clicks
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Text == "")
            {
                if (currentPlayer == 1)
                {
                    this.Player1.BackColor = Color.Red;
                    this.Player2.BackColor = Color.Green;

                    clickedButton.Text = "X";
                    currentPlayer = 2;
                }
                else
                {
                    this.Player1.BackColor = Color.Green;
                    this.Player2.BackColor = Color.Red;

                    clickedButton.Text = "O";
                    currentPlayer = 1;
                }
            }

            CheckIfGameEnded();
        }

        // Resets the game
        private void ResetGame_Click(object sender, EventArgs e)
        {
            this.currentPlayer = 1;

            this.Player1.BackColor = Color.Green;
            this.Player2.BackColor = Color.Red;

            ResetButtons();
        }

        // Resets all buttons to their initial state
        private void ResetButtons()
        {
            A1.Text = ""; A2.Text = ""; A3.Text = ""; B1.Text = ""; B2.Text = ""; B3.Text = ""; C1.Text = ""; C2.Text = ""; C3.Text = "";

            EnableAllButtons();
        }

        // Disables all buttons
        private void DisableAllButtons()
        {
            A1.Enabled = false; A2.Enabled = false; A3.Enabled = false; B1.Enabled = false; B2.Enabled = false; B3.Enabled = false;
            C1.Enabled = false; C2.Enabled = false; C3.Enabled = false;
        }

        // Enables all buttons
        private void EnableAllButtons()
        {
            A1.Enabled = true; A2.Enabled = true; A3.Enabled = true; B1.Enabled = true; B2.Enabled = true; B3.Enabled = true;
            C1.Enabled = true; C2.Enabled = true; C3.Enabled = true;
        }
    }
}
