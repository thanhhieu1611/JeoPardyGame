using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameOfJeopardy
{
    public partial class OptionFr : Form
    {
        #region Class variables
        //Number of player selected
        private int numPlayer;

        //List of player's names
        public List<string> playerNameLst;

        #endregion

        public OptionFr()
        {
            InitializeComponent();

            //Hide all player's name labels, textbox and buttons
            //Show only Selection of number of players
            DisplayItems(0);

        }

        #region Methods
        //Display items based on number of players
        public void DisplayItems(int num)
        {
            switch (num)
            {
                case 0:
                    //Hide Player's names labels and textbox
                    playNameLbl.Hide();
                    player1Lbl.Hide();
                    player2Lbl.Hide();
                    player3Lbl.Hide();
                    player1TxtBox.Hide();
                    player2TxtBox.Hide();
                    player3TxtBox.Hide();

                    //Hide buttons
                    continueBtn.Hide();
                    cancelBtn.Hide();
                    break;
                case 1:
                    //Show buttons
                    continueBtn.Show();
                    cancelBtn.Show();
                    playNameLbl.Show();

                    //One player
                    player1Lbl.Show();
                    player1TxtBox.Show();

                    //Subsribe keypress event for last player's textbox
                    player1TxtBox.KeyPress += new KeyPressEventHandler(keyPressed);

                    break;
                case 2:
                    //Show buttons
                    continueBtn.Show();
                    cancelBtn.Show();
                    playNameLbl.Show();

                    //Two players
                    player1Lbl.Show();
                    player1TxtBox.Show();
                    player2Lbl.Show();
                    player2TxtBox.Show();

                    //Subsribe keypress event for last player's textbox
                    player2TxtBox.KeyPress += new KeyPressEventHandler(keyPressed);
                    break;
                case 3:
                    //Show buttons
                    continueBtn.Show();
                    cancelBtn.Show();
                    playNameLbl.Show();

                    //Three players
                    player1Lbl.Show();
                    player1TxtBox.Show();
                    player2Lbl.Show();
                    player2TxtBox.Show();
                    player3Lbl.Show();
                    player3TxtBox.Show();

                    //Subsribe keypress event for last player's textbox
                    player3TxtBox.KeyPress += new KeyPressEventHandler(keyPressed);
                    break;

            }
        }

        /// <summary>
        /// The keypressed method uses the KeyChar property to check
        /// whether the ENTER key is pressed.
        /// If the ENTER key is pressed
        /// run ContinueClickevent
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void keyPressed(Object o, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                continueBtn_Click(o,e);
            }
        }

        #endregion

        private void continueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Create (Reset) an empty list of player's names
                playerNameLst = new List<string>();

                //Check valid player's name input
                //Then add player's names into playerNameLst
                switch (numPlayer)
                {
                    case 1:
                        if (player1TxtBox.Text == "")
                        {
                            MessageBox.Show("Please fill the name of the player!", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            playerNameLst.Add(player1TxtBox.Text);
                            this.Close();
                        }
                        break;
                    case 2:
                        if (player1TxtBox.Text == "" || player2TxtBox.Text == "")
                        {
                            MessageBox.Show("Please fill the name of the players!", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            playerNameLst.Add(player1TxtBox.Text);
                            playerNameLst.Add(player2TxtBox.Text);
                            this.Close();
                        }
                        break;
                    case 3:
                        if (player1TxtBox.Text == "" || player2TxtBox.Text == "" || player3TxtBox.Text == "")
                        {
                            MessageBox.Show("Please fill the name of the players!", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            playerNameLst.Add(player1TxtBox.Text);
                            playerNameLst.Add(player2TxtBox.Text);
                            playerNameLst.Add(player3TxtBox.Text);
                            this.Close();
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numPlayersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Reset form
                DisplayItems(0);

                //Unsubcribe KeyPress event handler of all player's text box
                player1TxtBox.KeyPress -= keyPressed;
                player2TxtBox.KeyPress -= keyPressed;
                player3TxtBox.KeyPress -= keyPressed;

                //Show relevant fields for player's input
                numPlayer = Convert.ToInt32(numPlayersComboBox.Text);
                DisplayItems(numPlayer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
