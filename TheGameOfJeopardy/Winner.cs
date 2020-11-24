using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization; //needed to ID XML Elements

namespace TheGameOfJeopardy
{
    /// <summary>
    /// Public Winner class will store information about winners of each round
    /// Winner information include attributes: "Catch", "Winner Name", "Score"
    /// </summary>
    public class Winner
    {
        //Recorded time of the winner
        [XmlElement(ElementName = "Catch")]
        public DateTime Catch { get; set; }

        //Winner name
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        //Winner score
        [XmlElement(ElementName = "Score")]
        public int Score { get; set; }

        //Set empty constructor to use in Serializer
        public Winner(){}

        public Winner(DateTime catchTime, string name, int score)
        {
            this.Catch = catchTime;
            this.Name = name;
            this.Score = score;
        }
    }
}
