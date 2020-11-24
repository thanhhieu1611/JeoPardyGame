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
    public partial class ResultFr : Form
    {
        public List<Winner> Winners { get; set; }

        public int HighestScore { get; set; }
        public ResultFr(List<Winner> winners)
        {
            InitializeComponent();

            this.Winners = winners;

            //Clear current result history data
            resultsLstBox.Items.Clear();

            //Add intial Column Name for list box
            resultsLstBox.Items.Add($"{"Catch".PadRight(43)}{"Name".PadRight(47)}{"Score".PadRight(8)}");
        }

        //update result list box
        public void UpdateResultHistory()
        {
            //Preset highest score
            HighestScore = this.Winners[0].Score;
            foreach(Winner winner in this.Winners)
            {
                resultsLstBox.Items.Add($"{Convert.ToString(winner.Catch).PadRight(30)}{winner.Name.ToString().PadRight(50)}{Convert.ToString(winner.Score).PadRight(8)}");

                //Check highest score
                if(winner.Score > this.HighestScore)
                {
                    HighestScore = winner.Score;
                }
            }

            //Update highest score textbox
            highestScoreTxtBox.Text = HighestScore.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
