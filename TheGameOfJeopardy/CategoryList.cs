using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declare for using XDocument, XElement objects
using System.Xml.Linq;

namespace TheGameOfJeopardy
{
    class CategoryList:List<Category>
    {
        //load in an XML file
        public void Load(string xmlFile)
        {
            //XDocument object needed to call the Load()
            //XDocument is a representation of a XML file
            XDocument doc = XDocument.Load(xmlFile);

            //use LINQ to view and get the elements in the XML file
            var query = from XElem in doc.Descendants("category")
                select new Category
                {
                    Name = (string)XElem.Attribute("name"),
                    Value1 = (string)XElem.Element("first").Attribute("points").Value,
                    Answer1 = (string)XElem.Element("first").Attribute("answer").Value,
                    Question1 = (string)XElem.Element("first").Value,
                            
                    Value2 = (string)XElem.Element("second").Attribute("points").Value,
                    Answer2 = (string)XElem.Element("second").Attribute("answer").Value,
                    Question2 = (string)XElem.Element("second").Value,
                            
                    Value3 = (string)XElem.Element("third").Attribute("points").Value,
                    Answer3 = (string)XElem.Element("third").Attribute("answer").Value,
                    Question3 = (string)XElem.Element("third").Value,
                            
                    Value4 = (string)XElem.Element("fourth").Attribute("points").Value,
                    Answer4 = (string)XElem.Element("fourth").Attribute("answer").Value,
                    Question4 = (string)XElem.Element("fourth").Value,
                            
                    Value5 = (string)XElem.Element("fifth").Attribute("points").Value,
                    Answer5 = (string)XElem.Element("fifth").Attribute("answer").Value,
                    Question5 = (string)XElem.Element("fifth").Value,
                };

            //Make sure my current list is empty
            this.Clear();

            //All of the category objects created from element values
            //need to be added into the list
            AddRange(query);
        }
    }
}
