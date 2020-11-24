using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add threading namespace
using System.Threading;
//Add Sterializer class
using XMLtoObject;
using System.IO;

/// <summary>
/// Need to convert music and dynamic picture
/// to make game more interesting
/// Need to add serilization class
/// Adjust answer, respond
/// </summary>

namespace TheGameOfJeopardy
{
    public partial class GameBoardFr : Form
    {
        #region Class variables
        //Create an instance variable to hold the splash form
        private SplashScreenFr splashForm;

        //Create an instance varialle to hole the options form
        private OptionFr optForm;
        //Create an instance varialle to hole the results form
        private ResultFr resultFr;
        //Player's name list
        public List<string> playerLst;
        public List<int> scoreLst;
        //List of winners
        public List<Winner> winners;

        //Create an instance varialle to hole the options form
        private AQFr aqForm;
        //Current value, name, indexes, answer, and respond of square
        public int squareValue;
        public string squareName;
        public string squareAnswer;
        public string squareRespond;

        //List of squares
        List<Button> squareLst;
        //List of categories from XML file
        CategoryList categoryLst;
        //Number of unclicked squares
        int numUnclickedSquare;
        //Name of XML file
        string fileName;
        //Number of player
        int numPlayer;

        //Winner index and score
        int winnerIndex;
        int winnerScore;

        //Declare list of Label and TxtBox controls
        //to store player's name and score
        Label playerLbl1;
        Label playerLbl2;
        Label playerLbl3;
        TextBox playerTxtBox1;
        TextBox playerTxtBox2;
        TextBox playerTxtBox3;

        //Time Limit for a game
        private int timeLimitOfARound;

        #endregion

        public GameBoardFr()
        {
            InitializeComponent();

            #region Splash screen thread
            //In this constructor, we're going the create a separate thread
            //so the main form will not lock up while the splash screen is running
            //Note: we not acctually calling a method, but we have a method name 
            //DoSplash (All of lines below is in a package)
            ParameterizedThreadStart pts = new ParameterizedThreadStart(DoSplash);
            Thread t = new Thread(pts);
            double time = 0.05d;
            t.Start(time);
            #endregion
        }

        #region Methods
        // Create Splash screen form and show it on screen
        private void DoSplash(object o)
        {
            double value = (double)o;
            splashForm = new SplashScreenFr();
            splashForm.ShowDialog();
        }

        //Splash Screen Load
        private void LoadSplashScreen()
        {
            //this loop here to prevent threading problem when myForm is not
            //have enough time to set up yet
            for (int i = 0; i < 10000; i++)
            {
                System.Diagnostics.Debug.WriteLine(i.ToString());
            }

            //raise event handler for close button
            splashForm.MakeCloseButtonVisible();

            //set up the sound player for the wave file in bin as default
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer("jeopardyTrim.wav");

            //play the sound
            myPlayer.Play();
        }

        // Display relevant player's scores controls
        private void DisplayPlayerScoreControls(int numPlayers)
        {
            //Set up control based on number players
            switch (numPlayers)
            {
                case 1:
                    //Create & add a label to control
                    //Then update the name of player
                    playerLbl1 = new Label();
                    playerLbl1.Text = playerLst[0];
                    playerLbl1.Location = new Point(395, 410);
                    playerLbl1.Size = new Size(70, 23);
                    playerLbl1.Font = new Font(playerLbl1.Font.FontFamily, 10);
                    playerLbl1.BackColor = Color.Blue;
                    playerLbl1.ForeColor = Color.White;
                    playerLbl1.TextAlign = ContentAlignment.MiddleLeft;
                    Controls.Add(playerLbl1);
                    playerLbl1.BringToFront();

                    //Create & add a textBox to control
                    playerTxtBox1 = new TextBox();
                    playerTxtBox1.Text = "0";
                    playerTxtBox1.Location = new Point(470, 410);
                    playerTxtBox1.Size = new Size(50, 20);
                    playerTxtBox1.Font = new Font(playerTxtBox1.Font.FontFamily, 10);
                    playerTxtBox1.BackColor = Color.Blue;
                    playerTxtBox1.ForeColor = Color.White;
                    Controls.Add(playerTxtBox1);
                    playerTxtBox1.BringToFront();

                    break;
                case 2:
                    //Create & add a label to control
                    //Then update the name of first player
                    playerLbl1 = new Label();
                    playerLbl1.Text = playerLst[0];
                    playerLbl1.Location = new Point(395, 395);
                    playerLbl1.Size = new Size(70, 23);
                    playerLbl1.Font = new Font(playerLbl1.Font.FontFamily, 10);
                    playerLbl1.BackColor = Color.Blue;
                    playerLbl1.ForeColor = Color.White;
                    playerLbl1.TextAlign = ContentAlignment.MiddleLeft;
                    Controls.Add(playerLbl1);
                    playerLbl1.BringToFront();

                    //Create & add a textBox of player 1
                    playerTxtBox1 = new TextBox();
                    playerTxtBox1.Text = "0";
                    playerTxtBox1.Location = new Point(470, 395);
                    playerTxtBox1.Size = new Size(50, 20);
                    playerTxtBox1.Font = new Font(playerTxtBox1.Font.FontFamily, 10);
                    playerTxtBox1.BackColor = Color.Blue;
                    playerTxtBox1.ForeColor = Color.White;
                    Controls.Add(playerTxtBox1);
                    playerTxtBox1.BringToFront();

                    //Create & add a label to control
                    //Then update the name of second player
                    playerLbl2 = new Label();
                    playerLbl2.Text = playerLst[1];
                    playerLbl2.Location = new Point(395, 423);
                    playerLbl2.Size = new Size(70, 23);
                    playerLbl2.Font = new Font(playerLbl2.Font.FontFamily, 10);
                    playerLbl2.BackColor = Color.Blue;
                    playerLbl2.ForeColor = Color.White;
                    playerLbl2.TextAlign = ContentAlignment.MiddleLeft;
                    Controls.Add(playerLbl2);
                    playerLbl2.BringToFront();

                    //Create & add a textBox of player 1
                    playerTxtBox2 = new TextBox();
                    playerTxtBox2.Text = "0";
                    playerTxtBox2.Location = new Point(470, 423);
                    playerTxtBox2.Size = new Size(50, 20);
                    playerTxtBox2.Font = new Font(playerTxtBox2.Font.FontFamily, 10);
                    playerTxtBox2.BackColor = Color.Blue;
                    playerTxtBox2.ForeColor = Color.White;
                    Controls.Add(playerTxtBox2);
                    playerTxtBox2.BringToFront();
                    break;
                case 3:
                    //Create & add a label to control
                    //Then update the name of first player
                    playerLbl1 = new Label();
                    playerLbl1.Text = playerLst[0];
                    playerLbl1.Location = new Point(270, 395);
                    playerLbl1.Size = new Size(70, 23);
                    playerLbl1.Font = new Font(playerLbl1.Font.FontFamily, 10);
                    playerLbl1.BackColor = Color.Blue;
                    playerLbl1.ForeColor = Color.White;
                    playerLbl1.TextAlign = ContentAlignment.MiddleLeft;
                    Controls.Add(playerLbl1);
                    playerLbl1.BringToFront();

                    //Create & add a textBox of first player
                    playerTxtBox1 = new TextBox();
                    playerTxtBox1.Text = "0";
                    playerTxtBox1.Location = new Point(345, 395);
                    playerTxtBox1.Size = new Size(50, 20);
                    playerTxtBox1.Font = new Font(playerTxtBox1.Font.FontFamily, 10);
                    playerTxtBox1.BackColor = Color.Blue;
                    playerTxtBox1.ForeColor = Color.White;
                    Controls.Add(playerTxtBox1);
                    playerTxtBox1.BringToFront();

                    //Create & add a label to control
                    //Then update the name of second player
                    playerLbl2 = new Label();
                    playerLbl2.Text = playerLst[1];
                    playerLbl2.Location = new Point(270, 423);
                    playerLbl2.Size = new Size(70, 23);
                    playerLbl2.Font = new Font(playerLbl2.Font.FontFamily, 10);
                    playerLbl2.BackColor = Color.Blue;
                    playerLbl2.ForeColor = Color.White;
                    playerLbl2.TextAlign = ContentAlignment.MiddleLeft;
                    Controls.Add(playerLbl2);
                    playerLbl2.BringToFront();

                    //Create & add a textBox of second player
                    playerTxtBox2 = new TextBox();
                    playerTxtBox2.Text = "0";
                    playerTxtBox2.Location = new Point(345, 423);
                    playerTxtBox2.Size = new Size(50, 20);
                    playerTxtBox2.Font = new Font(playerTxtBox2.Font.FontFamily, 10);
                    playerTxtBox2.BackColor = Color.Blue;
                    playerTxtBox2.ForeColor = Color.White;
                    Controls.Add(playerTxtBox2);
                    playerTxtBox2.BringToFront();

                    //Create & add a label to control
                    //Then update the name of third player
                    playerLbl3 = new Label();
                    playerLbl3.Text = playerLst[2];
                    playerLbl3.Location = new Point(405, 395);
                    playerLbl3.Size = new Size(70, 23);
                    playerLbl3.Font = new Font(playerLbl3.Font.FontFamily, 10);
                    playerLbl3.BackColor = Color.Blue;
                    playerLbl3.ForeColor = Color.White;
                    playerLbl3.TextAlign = ContentAlignment.MiddleLeft;
                    Controls.Add(playerLbl3);
                    playerLbl3.BringToFront();

                    //Create & add a textBox of player 3
                    playerTxtBox3 = new TextBox();
                    playerTxtBox3.Text = "0";
                    playerTxtBox3.Location = new Point(480, 395);
                    playerTxtBox3.Size = new Size(50, 20);
                    playerTxtBox3.Font = new Font(playerTxtBox3.Font.FontFamily, 10);
                    playerTxtBox3.BackColor = Color.Blue;
                    playerTxtBox3.ForeColor = Color.White;
                    Controls.Add(playerTxtBox3);
                    playerTxtBox3.BringToFront();
                    break;
            }
        }

        //Hide player score controls
        private void HidePlayerScoreControls(int numPlayers)
        {
            switch (numPlayers)
            {
                case 1:             
                    Controls.Remove(playerLbl1);
                    playerLbl1.Hide();
                    Controls.Remove(playerTxtBox1);
                    playerTxtBox1.Hide();
                    break;
                case 2:
                    Controls.Remove(playerLbl1);
                    playerLbl1.Hide();
                    Controls.Remove(playerTxtBox1);
                    playerTxtBox1.Hide();
                    Controls.Remove(playerLbl2);
                    playerLbl2.Hide();
                    Controls.Remove(playerTxtBox2);
                    playerTxtBox2.Hide();
                    break;
                case 3:
                    Controls.Remove(playerLbl1);
                    playerLbl1.Hide();
                    Controls.Remove(playerTxtBox1);
                    playerTxtBox1.Hide();
                    Controls.Remove(playerLbl2);
                    playerLbl2.Hide();
                    Controls.Remove(playerTxtBox2);
                    playerTxtBox2.Hide();
                    Controls.Remove(playerLbl3);
                    playerLbl3.Hide();
                    Controls.Remove(playerTxtBox3);
                    playerTxtBox3.Hide();
                    break;
            }
        }

        // SquareClick method
        private void ClickSquares(object sender, EventArgs e)
        {
            //player music
            //set up the sound player for the wave file in bin as default
            System.Media.SoundPlayer myPlayer1 = new System.Media.SoundPlayer("jeopardyTrim.wav");

            //play the sound
            myPlayer1.Play();

            //Access to clicked square and get its name
            foreach(Button btn in squareLst)
            {
                if(sender == btn)
                {
                    //Unsubcribe click event
                    btn.Click -= ClickSquares;

                    //square Name
                    squareName = btn.Name;

                    //Change the color of the button text
                    btn.Text = "";

                    //Update number of unclicked squares
                    numUnclickedSquare--;

                    //Exit foreach loop
                    break;
                }
            }

            GetSquareInfos(squareName);

            //Initialize AandQForm and show its dialog
            //pass player's name list into AandQForm
            aqForm = new AQFr(playerLst, squareValue, scoreLst, squareAnswer, squareRespond);
            aqForm.ShowDialog();

            //Get updated scoreList
            UpdateScores(numPlayer, scoreLst);

            //Check to see if all squares have been clicked
            if (numUnclickedSquare == 0)
            {
                //Stop timer
                timer1.Enabled = false;

                //Get winner
                GetWinner();
            }
        }

        // Add list of square button into its list
        private void AddSquareToList()
        {
            squareLst.Add(c1r1Btn);
            squareLst.Add(c1r2Btn);
            squareLst.Add(c1r3Btn);
            squareLst.Add(c1r4Btn);
            squareLst.Add(c1r5Btn);
            squareLst.Add(c2r1Btn);
            squareLst.Add(c2r2Btn);
            squareLst.Add(c2r3Btn);
            squareLst.Add(c2r4Btn);
            squareLst.Add(c2r5Btn);
            squareLst.Add(c3r1Btn);
            squareLst.Add(c3r2Btn);
            squareLst.Add(c3r3Btn);
            squareLst.Add(c3r4Btn);
            squareLst.Add(c3r5Btn);
            squareLst.Add(c4r1Btn);
            squareLst.Add(c4r2Btn);
            squareLst.Add(c4r3Btn);
            squareLst.Add(c4r4Btn);
            squareLst.Add(c4r5Btn);
            squareLst.Add(c5r1Btn);
            squareLst.Add(c5r2Btn);
            squareLst.Add(c5r3Btn);
            squareLst.Add(c5r4Btn);
            squareLst.Add(c5r5Btn);
        }

        //Square List setup
        private void SetUpSquareList()
        {
            //Initialize list of squares
            squareLst = new List<Button>();
            AddSquareToList();

            //Number of unclicked squares
            numUnclickedSquare = squareLst.Count();

            //Subcribe click event to all squares
            foreach (Button btn in squareLst)
            {
                btn.Click += ClickSquares;
            }
        }

        //Load XML file, then store in squareList
        private void LoadXMLFileIntoSquareList()
        {
            //call the CategoryList Load() method 
            //passing the name of the XML file chosen in the dialog
            categoryLst = new CategoryList();
            fileName = "Jeopardy.xml";
            categoryLst.Load(fileName);
        }

        //Display relevant score textbox into Game Board Form
        private void DisplayScoreTextBox()
        {
            if (playerLst != null)
            {
                numPlayer = playerLst.Count();

                //Initialize scoreLst
                scoreLst = new List<int>();
                foreach (string player in playerLst)
                {
                    scoreLst.Add(500);
                }
                //Display relevant player's score txtboxes
                DisplayPlayerScoreControls(numPlayer);

                //Update initial scores
                UpdateScores(numPlayer, scoreLst);
            }
        }

        // Populate data from XML file (categoryLst) into GameBoardFr
        private void PopulateDataIntoGameBoard(CategoryList list)
        {
            //Category 1
            catBtn1.Text = list[0].Name;
            c1r1Btn.Text = '$' + list[0].Value1;
            c1r2Btn.Text = '$' + list[0].Value2;
            c1r3Btn.Text = '$' + list[0].Value3;
            c1r4Btn.Text = '$' + list[0].Value4;
            c1r5Btn.Text = '$' + list[0].Value5;
            //Category 2
            catBtn2.Text = '$' + list[1].Name;
            c2r1Btn.Text = '$' + list[1].Value1;
            c2r2Btn.Text = '$' + list[1].Value2;
            c2r3Btn.Text = '$' + list[1].Value3;
            c2r4Btn.Text = '$' + list[1].Value4;
            c2r5Btn.Text = '$' + list[1].Value5;
            //Category 3
            catBtn3.Text = '$' + list[2].Name;
            c3r1Btn.Text = '$' + list[2].Value1;
            c3r2Btn.Text = '$' + list[2].Value2;
            c3r3Btn.Text = '$' + list[2].Value3;
            c3r4Btn.Text = '$' + list[2].Value4;
            c3r5Btn.Text = '$' + list[2].Value5;
            //Category 4
            catBtn4.Text = '$' + list[3].Name;
            c4r1Btn.Text = '$' + list[3].Value1;
            c4r2Btn.Text = '$' + list[3].Value2;
            c4r3Btn.Text = '$' + list[3].Value3;
            c4r4Btn.Text = '$' + list[3].Value4;
            c4r5Btn.Text = '$' + list[3].Value5;
            //Category 5
            catBtn5.Text = '$' + list[4].Name;
            c5r1Btn.Text = '$' + list[4].Value1;
            c5r2Btn.Text = '$' + list[4].Value2;
            c5r3Btn.Text = '$' + list[4].Value3;
            c5r4Btn.Text = '$' + list[4].Value4;
            c5r5Btn.Text = '$' + list[4].Value5;
        }

        //Load Option form
        private void LoadOptionForm()
        {
            //Initial Options Form then show it
            optForm = new OptionFr();
            optForm.ShowDialog();
            optForm.BringToFront();

            ////Wait to update playLst until optionForm is closed
            //while (optForm.IsAccessible)
            //{
            //    MessageBox.Show("Loading...");
            //}

            //Update playerLst
            playerLst = new List<string>();
            playerLst = optForm.playerNameLst;
        }

        //Load Results form
        //Load results history into the form
        private void LoadResultsForm(List<Winner> winners)
        {
            //Initial Results Form then show it
            resultFr = new ResultFr(winners);
            //Inital set up for results textbox
            resultFr.UpdateResultHistory();
            resultFr.ShowDialog();
            resultFr.BringToFront();

            

        }


        //Update score of players in GameBoard Form
        private void UpdateScores(int numberPlayer, List<int> scoreList)
        {
            switch (numPlayer)
            {
                case 1:
                    playerTxtBox1.Text = scoreList[0].ToString();
                    break;
                case 2:
                    playerTxtBox1.Text = scoreList[0].ToString();
                    playerTxtBox2.Text = scoreList[1].ToString();
                    break;
                case 3:
                    playerTxtBox1.Text = scoreList[0].ToString();
                    playerTxtBox2.Text = scoreList[1].ToString();
                    playerTxtBox3.Text = scoreList[2].ToString();
                    break;
            }
        }

        //Get square value, answer, and respond of click
        private void GetSquareInfos(string squareName)
        {
            //Indexes Column (1-5), Row (1, 5)
            int columnIndex = Convert.ToInt32(Char.GetNumericValue(squareName[1]));
            int rowIndex = Convert.ToInt32(Char.GetNumericValue(squareName[3]));   

            //Answer, question, and value of square
            switch (rowIndex)
            {
                case 1:
                    squareRespond = categoryLst[columnIndex - 1].Question1;
                    squareAnswer = categoryLst[columnIndex - 1].Answer1;
                    squareValue = Convert.ToInt32(categoryLst[columnIndex - 1].Value1.TrimStart(' ', '$').TrimEnd(' ', '$'));
                    break;
                case 2:
                    squareRespond = categoryLst[columnIndex - 1].Question2;
                    squareAnswer = categoryLst[columnIndex - 1].Answer2;
                    squareValue = Convert.ToInt32(categoryLst[columnIndex - 1].Value2.TrimStart(' ', '$').TrimEnd(' ', '$'));
                    break;
                case 3:
                    squareRespond = categoryLst[columnIndex - 1].Question3;
                    squareAnswer = categoryLst[columnIndex - 1].Answer3;
                    squareValue = Convert.ToInt32(categoryLst[columnIndex - 1].Value3.TrimStart(' ', '$').TrimEnd(' ', '$'));
                    break;
                case 4:
                    squareRespond = categoryLst[columnIndex - 1].Question4;
                    squareAnswer = categoryLst[columnIndex - 1].Answer4;
                    squareValue = Convert.ToInt32(categoryLst[columnIndex - 1].Value4.TrimStart(' ', '$').TrimEnd(' ', '$'));
                    break;
                case 5:
                    squareRespond = categoryLst[columnIndex - 1].Question5;
                    squareAnswer = categoryLst[columnIndex - 1].Answer5;
                    squareValue = Convert.ToInt32(categoryLst[columnIndex - 1].Value5.TrimStart(' ', '$').TrimEnd(' ', '$'));
                    break;
            }
        }

        //Get winner and populate its data into Winner class
        //Popular the winner data into SQL Server DB
        private void GetWinner()
        {
            //Winner names
            string winnerNames;

            //Find the highest score and index
            winnerIndex = 0;
            winnerScore = scoreLst[winnerIndex];
            for (int i = 1; i < numPlayer; i++)
            {
                if (scoreLst[i] > winnerScore)
                {
                    winnerScore = scoreLst[i];
                    winnerIndex = i;
                }
            }
            winnerNames = playerLst[winnerIndex];

            //Check to see if more than 1 player has 
            //same highest score
            for (int i = 1; i < numPlayer; i++)
            {
                if (scoreLst[i] == winnerScore && i != winnerIndex)
                {
                    winnerNames += (" and " + playerLst[i]);
                }
            }

            MessageBox.Show($"The winner: {winnerNames} with ${winnerScore}");

            //Recorded time of the winner
            DateTime localDate = DateTime.Now;

            //Create Winner object and populate its data
            Winner winner = new Winner(localDate, winnerNames, winnerScore);

            //Serializer winner into xmlString
            string xmlInputData = SerializerWinnerObject(winner);

            //Send it into SQL Server Database
            PopulateXMLStringIntoSQLServerBD(xmlInputData);
        }

        //Reset game
        private void ResetGame()
        {
            //reset timer
            timer1.Enabled = false;

            HidePlayerScoreControls(numPlayer);

            //Number of unclicked squares
            numUnclickedSquare = squareLst.Count();

            //Subcribe click event to all squares
            foreach (Button btn in squareLst)
            {
                //Remove all clicksquare event from buttons
                //To prevent double events
                btn.Click -= ClickSquares;
                //Add click event again
                btn.Click += ClickSquares;
            }

            //Populate into GameBoardForm
            PopulateDataIntoGameBoard(categoryLst);

            //Initialize time limit for a round (in second)
            timeLimitOfARound = 150;
            gameRemaingTime.Text = timeLimitOfARound.ToString();

            LoadOptionForm();
            numPlayer = playerLst.Count();

            //Initialize scoreLst
            scoreLst = new List<int>();
            foreach (string player in playerLst)
            {
                scoreLst.Add(500);
            }

            //Prevent case: option form is closed
            if (playerLst != null)
            {
                //Display relevant player's score txtboxes
                DisplayPlayerScoreControls(numPlayer);
            }

            //Update initial scores
            UpdateScores(numPlayer, scoreLst);

            //Start timer of the round
            timer1.Enabled = true;
        }

        //Serializer Winner Object into XML string
        private string SerializerWinnerObject(Winner winner)
        {
            //create a new instance of our XML Serializer class
            XMLSerializer ser = new XMLSerializer();

            //XML string input
            string xmlInputData = ser.Serialize<Winner>(winner);

            return xmlInputData;
        }

        //Populate XMLString of winner into SQL Server DB
        private void PopulateXMLStringIntoSQLServerBD(string xmlInput)
        {
            DataAdapter.Insert(xmlInput);
        }

        #endregion

        #region Events
        private void GameBoardFr_Load(object sender, EventArgs e)
        {
            try
            {
                //Splash Screen Form Load
                LoadSplashScreen();

                //Initialize list of squares
                SetUpSquareList();

                LoadXMLFileIntoSquareList();

                //Populate into GameBoardForm
                PopulateDataIntoGameBoard(categoryLst);

                //Initialize time limit for a round (in second)
                timeLimitOfARound = 30;
                gameRemaingTime.Text = timeLimitOfARound.ToString();

                //Options Form load
                LoadOptionForm();

                //Display relevant score txtbox
                DisplayScoreTextBox();

                //Start timer of the round
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Timer 1 update remaining time of each round
        //Get winner if running out of time
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Update remaining time
                timeLimitOfARound -= 1;
                gameRemaingTime.Text = timeLimitOfARound.ToString();

                //Warning player that game is running out of time
                if (timeLimitOfARound == 10)
                {
                    MessageBox.Show("The game will be ended in 10 seconds!", "Time Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //End the game and declare the winner
                if (timeLimitOfARound == 0)
                {
                    //Stop timer
                    timer1.Enabled = false;

                    //Close AandQ form if currently openning
                    this.aqForm.Hide();

                    MessageBox.Show("The Game has ended!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Show winner
                    GetWinner();

                    //Unsubcribe click event to all squares
                    foreach (Button btn in squareLst)
                    {
                        //Remove all clicksquare event from buttons
                        btn.Click -= ClickSquares;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResetGame();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void endGameBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scoreHistoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Stop timer 1 & Reset timer box
                this.timer1.Stop();
                this.gameRemaingTime.Text = "0";


                //Remove click event of all squareButtons
                //And hide the Text of squares
                foreach (Button square in squareLst)
                {
                    square.Click -= ClickSquares;
                    square.Text = "";
                }

                //List of winners
                winners = new List<Winner>();

                //Get data from DB using DataAdapter
                //Deserializer data from SQL server BD
                winners = DataAdapter.GetWinners();

                //Load result Form
                //Update into Result from winners list
                LoadResultsForm(winners);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
