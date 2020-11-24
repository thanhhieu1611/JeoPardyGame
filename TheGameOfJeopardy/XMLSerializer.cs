using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //needed for stringreader/stringwriter
using System.Xml.Serialization; //needed for XML-based tasks
//Originally from Dr.Ford in CIS151 class

namespace XMLtoObject
{
    class XMLSerializer
    {
        /// <summary>
        /// This method takes in XML structure data and walks through it node, by node
        /// receives a string containing the xml to deserialize and returns an object of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">XML string</param>
        /// <returns>object T</returns>
        public T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        /// <summary>
        /// Takes an object and converts it to XML structure
        /// receives an object of type T and converts this into xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ObjectToSerialize"></param>
        /// <returns>XML string</returns>
        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer ser = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter sw = new StringWriter())
            {
                ser.Serialize(sw, ObjectToSerialize);
                return sw.ToString();
            }
        }
    }
}
