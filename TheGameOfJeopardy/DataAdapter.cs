using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Connect to SQL Client library
using System.Data.SqlClient;
//Connect to Array List collection
using System.Collections;
//Connect to XMLSerializer
using XMLtoObject;

namespace TheGameOfJeopardy
{
    /// <summary>
    /// Static Class
    /// Used to interact with SQL server
    /// </summary>
    static class DataAdapter
    {
        #region GLOBAL DECLARATION
        //Create a sqlConnection obj to connec tot DB
        //Data Source: server
        //Initial Catalog: name of the DB
        //Integrated Security is Window Authentication and no userName/password required????????
        static SqlConnection oConn = new SqlConnection("Data Source=cis.ckwia8qkgyyj.us-east-1.rds.amazonaws.com ; Initial Catalog=hd0917093 ; User ID=hd0917093 ; Password=917093 ");
        
        //Declare lists of DB objects
        static List<Winner> winners;

        #endregion

        #region SQL SERVER FUNCTIONS
        //Methods to connect to the DB
        public static void Initialize()
        {
            try
            {
                oConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Method to disconnect from the DB
        public static void Disconnect()
        {
            try
            {
                oConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region DATABASE FUNCTIONs
        //Queries the DB and return a set of winner objects
        public static List<Winner> GetWinners()
        {
            winners = new List<Winner>();

            //New transaction to execute the SELECT query
            string sqlSelect = "SELECT * FROM JeopardyWinners";

            try
            {
                //Open connection
                Initialize();

                //Create a sqlCommand object
                SqlCommand cmdSelect = new SqlCommand(sqlSelect, oConn);

                //Setup a sqlReader to receive the query respond from the DB
                SqlDataReader readerSelect = cmdSelect.ExecuteReader();

                //Declare a Winner object
                Winner myWinner;

                //Read() method will read the current record and advance us to the next record
                //While will be false when there is no more record
                while (readerSelect.Read())
                {
                    //Get my XMLstring of winner object from the readerSelect sqlReader
                    string XMLWinner = readerSelect["Data"].ToString();

                    //Create XMLSerializer instance
                    XMLSerializer ser = new XMLSerializer();

                    //Deserializer XML string and convert into winnerObject
                    myWinner = ser.Deserialize<Winner>(XMLWinner);

                    //Add a new winner into winners list
                    winners.Add(myWinner);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Disconnect to the server
                Disconnect();   
            }
            return winners;
        }

        //Adds data into the Database
        public static void Insert(string data)
        {
            string sqlIns = "INSERT INTO JeopardyWinners(Data) VALUES(@data)";

            try
            {
                Initialize();

                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                cmdIns.Parameters.AddWithValue("@data", data);

                cmdIns.ExecuteNonQuery();
                MessageBox.Show("Successful insert XML string of winner into DB", "Status Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        #endregion
    }
}
