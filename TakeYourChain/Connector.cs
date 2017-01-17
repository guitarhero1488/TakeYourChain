using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TakeYourChain
{
    class Connector
    {        
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ReferenceDatabase.mdf;Integrated Security=True";
        private static string commandRead = "select * from Reference";
        public static DataSet receivedData;
        private static SqlConnection connection = new SqlConnection(connectionString);
        private static SqlDataAdapter adapter = new SqlDataAdapter(commandRead, connection);
        private static SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

        public static void Read()
        {
            try
            {
                receivedData = new DataSet();
                adapter.Fill(receivedData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    CloseConnection();
                }
            }
        }

        public static void UpdateTable()
        {
            try
            {
                adapter.Update(receivedData.Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    CloseConnection();
                }
            }
        }

        // Here a list of chain's links created and first two fields of links initialized.
        // Input parameters are source article and name
        public static LinkedList<Chain> CreateOriginalsList(string[] data)
        {
            LinkedList<Chain> list = new LinkedList<Chain>();
            foreach (DataRow row in receivedData.Tables[0].Rows)
            {
                if (string.Equals(data.GetValue(0).ToString(), row.ItemArray[1].ToString()) || string.Equals(data.GetValue(1).ToString(), row.ItemArray[2].ToString()))
                {
                    list.AddLast(new Chain(row.ItemArray[1].ToString(), row.ItemArray[2].ToString()));
                    list.Last.Value.InitLinkAnalog(row.ItemArray[3].ToString(), row.ItemArray[4].ToString());
                }
            }
            // Returned a list of chains of view: { { Article, Name, null, null }, ..., { Article, Name, null, null } }
            return list;
        }    
            
        public static void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
