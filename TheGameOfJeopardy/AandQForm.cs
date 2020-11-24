using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TheGameOfJeopardy
{
    public partial class AQFr : Form
    {
        #region Class variables
        //List of player's name
        private List<string> playerLst;

        //List of player's score
        public List<int> scoreLst;

        //Selected Player
        public int selectedPlayerIndex;

        //Value of question
        private int questionValue;

        //Adjusted value of selected player
        public int adjustValue;

        //Square answer
        private string answer;

        //Square respond
        private string respond;

        //Time Limite for each question
        private int timeLimitPerQuestion;

        #endregion
        public AQFr(List<string> playerList, int value, List<int> scoreList, string answer, string respond)
        {
            InitializeComponent();
            //Reset adjusted value for selected player

            //Initialize player list
            playerLst = new List<string>();
            playerLst = playerList;

            //Get value of question
            questionValue = value;

            //Initialize score list
            scoreLst = new List<int>();
            scoreLst = scoreList;

            //Get square answer and respond
            this.answer = answer;
            this.respond = respond;
            

        }

        #region Methods
        // Pass player name list into Select Player combobox
        private void PassPlayerNameIntoComboBox()
        {
            if (playerLst.Count() == 1)
            {
                //Only one player
                playerComboBox.Items.Add(playerLst[0]);

                //Select the default value for playerComboBox
                playerComboBox.SelectedItem = playerLst[0];
            }
            else
            {
                foreach (string name in playerLst)
                {
                    playerComboBox.Items.Add(name);
                }
            }
        }
        
        //Pass Answer into AandQ Form
        private void PassAnswerIntoAQForm()
        {
            answerTxtBox.Text = this.respond;
        }

        #endregion

        private void AQFr_Load(object sender, EventArgs e)
        {
            try
            {
                //Preload Form with player names, answer
                PassPlayerNameIntoComboBox();
                PassAnswerIntoAQForm();

                //Intialize setup for AandQ form
                resultGroupBox.Enabled = false;
                checkBtn.Enabled = false;

                //Initialize time limit for each question (in second)
                timeLimitPerQuestion = 30;

                //Enable timer 1
                timer1.Enabled = true;

                //Update remaining time
                questionRemaingTime.Text = timeLimitPerQuestion.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Show relevant respond click event
        private void checkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Show result selection
                resultGroupBox.Enabled = true;

                //Show right response
                rightReponseTxtBox.Text = this.answer;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Continue and return to GameBoardForm
        private void continueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Test selected player
                if (playerComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select player", "Missing Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Selected index in player list
                    selectedPlayerIndex = playerComboBox.SelectedIndex;

                    //Update player's score
                    if (rightRadioBtn.Checked == true)
                    {
                        scoreLst[selectedPlayerIndex] += questionValue;

                        //Stop timer1
                        timer1.Enabled = false;

                        //Close AandQ form
                        this.Close();
                    }
                    else if (wrongRatioBtn.Checked == true)
                    {
                        scoreLst[selectedPlayerIndex] -= questionValue;

                        //Stop timer1
                        timer1.Enabled = false;

                        //Close AandQ form
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please check result", "Missing Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void playerRespondTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Re-enable check button
                checkBtn.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Happen every second to update remaining time
        //If out of time, update player's core
        //based on selected player
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Update remaining time (in second)
                timeLimitPerQuestion -= 1;

                //Update remaining time
                questionRemaingTime.Text = timeLimitPerQuestion.ToString();

                //Check time-out and stop timer
                if (timeLimitPerQuestion == 0)
                {
                    timer1.Enabled = false;

                    //Specify player
                    if (playerComboBox.SelectedItem == null)
                    {
                        //Close the AandQ form
                        this.Close();
                    }
                    else
                    {
                        //Selected index in player list
                        selectedPlayerIndex = playerComboBox.SelectedIndex;

                        //Update player's score
                        scoreLst[selectedPlayerIndex] -= questionValue;

                        //Stop timer1
                        timer1.Enabled = false;

                        //Close AandQ form
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
