using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        int playerWins = 0; // Will hold the number of times the player wins.
        int playerChoice;   // Will hold the value of the player's choice whether it be rock, paper, scissors.
        int cpuWins = 0;    // Will hold the number of times the computer wins.
        int draws = 0;      // Will hold the number of times the computer and player draw.
        int cpuChoice;      // Will hold the random number that is generated for the computer.
        public Form1()
        {
             ();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            playerChoice = 0;
        }
        // Function determines who wins and keeps track of number of wins and draws and selections.
        private void Winner()
        { 
            // The if statements determine who will win in each round. 1 is rock, 2 is paper, 3 is scissors.
            if ((cpuChoice == 1) && (playerChoice == 2))
            {
                CPURockPictureBox.Visible = true;       // The picture will be shown for the rock.
                CPUPaperPictureBox.Visible = false;     // The pictures for scissors and paper will be hidden.
                CPUScissorsPictureBox.Visible = false;
                playerWins++;                           // In this round, the player won so it will keep track of that.
                MessageBox.Show("You win! Paper beats rock.");
            } 
            if ((cpuChoice == 1) && (playerChoice == 3))
            {
                CPURockPictureBox.Visible = true;       // Only the rock picture will be shown, others hidden.
                CPUPaperPictureBox.Visible = false;
                CPUScissorsPictureBox.Visible = false;
                cpuWins++;                              // In this round, computer won so it will keep track of that.
                MessageBox.Show("CPU wins! Rock beats scissors.");
            } 
            if ((cpuChoice == 2) && (playerChoice == 1))
            {
                CPUPaperPictureBox.Visible = true;      // Only the paper image is shown.
                CPURockPictureBox.Visible = false;
                CPUScissorsPictureBox.Visible = false;
                cpuWins++;
                MessageBox.Show("CPU wins! Paper beats rock.");
            } 
            if ((cpuChoice == 2) && (playerChoice == 3))
            {
                CPUPaperPictureBox.Visible = true;
                CPURockPictureBox.Visible = false;
                CPUScissorsPictureBox.Visible = false;
                playerWins++;
                MessageBox.Show("You win! Scissors beats paper.");
            }
            if ((cpuChoice == 3) && (playerChoice == 1))
            {
                CPUScissorsPictureBox.Visible = true;   // Only the scissors image is shown.
                CPURockPictureBox.Visible = false;
                CPUPaperPictureBox.Visible = false;
                playerWins++;
                MessageBox.Show("You win! Rock beats scissors.");
            }
            if ((cpuChoice == 3) && (playerChoice == 2))
            {
                CPUScissorsPictureBox.Visible = true;
                CPURockPictureBox.Visible = false;
                CPUPaperPictureBox.Visible = false;
                cpuWins++;
                MessageBox.Show("CPU wins! Scissors beats paper.");
            } 
            if (cpuChoice == playerChoice) // If the computer and play pick the same item, this is executed.
            {
                if (cpuChoice == 1)        // Since it is nested inside another if statement, both have rock selected.
                {
                    CPURockPictureBox.Visible = true;
                    CPUPaperPictureBox.Visible = false;
                    CPUScissorsPictureBox.Visible = false;
                } 
                else if (cpuChoice == 2)    // Both have paper selected.
                {
                    CPUPaperPictureBox.Visible = true;
                    CPURockPictureBox.Visible = false;
                    CPUScissorsPictureBox.Visible = false;
                } 
                else if (cpuChoice == 3)    // Both have scissors selected.
                {
                    CPUScissorsPictureBox.Visible = true;
                    CPURockPictureBox.Visible = false;
                    CPUPaperPictureBox.Visible = false;
                }
                draws++;                    // Each time that both pick the same item, draws++ keeps track of the count.
                MessageBox.Show("Your choice is the same as the CPU. Play again.");
            }
            yourScoreLabel.Text = "Score: " + playerWins;   // Will display the number of times player wins.
            CPUScoreLabel.Text = "Score: " + cpuWins;       // Will display the number of times computer wins.
            drawCountLabel.Text = "Number of draws: " + draws;  // Will display the number of times they draw.
        } 
        // Generates a choice for the computer.
        private void Generate_CPU_Choice()
        {   // Randomizes the choice between 1 and 3.
            Random rand = new Random();
            cpuChoice = rand.Next(1, 4);
        }
        // The user selects rock, this will be executed.
        private void RockButton_Click(object sender, EventArgs e)
        {
            playerChoice = 1;                       // Player chose rock, rock is 1.
            yourRockPictureBox.Visible = true;      // Will only show the rock image.
            yourPaperPictureBox.Visible = false;
            yourScissorsPictureBox.Visible = false;
            Generate_CPU_Choice();                  // Calls the computer's choice 
            Winner();                               // Calls the function that determines who wins, etc.
        }
        // The user selects paper, this will be executed.
        private void PaperButton_Click(object sender, EventArgs e)
        {
            playerChoice = 2;                       // Player chose paper, paper is 2.
            yourPaperPictureBox.Visible = true;     // Will only show the paper image.
            yourScissorsPictureBox.Visible = false;
            yourRockPictureBox.Visible = false;
            Generate_CPU_Choice();                  // Calls the computer's choice.
            Winner();                               // Calls the function that determines who wins, etc.
        }
        // The user selects scissors, this will be executed.
        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            playerChoice = 3;                       // The player chose scissors, scissors is 3.
            yourScissorsPictureBox.Visible = true;  // Will only show the image of the scissors.
            yourPaperPictureBox.Visible = false;
            yourRockPictureBox.Visible = false;
            Generate_CPU_Choice();                  // Calls the computer's choice.
            Winner();                               // Calls the function that determines who wins, etc.
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
