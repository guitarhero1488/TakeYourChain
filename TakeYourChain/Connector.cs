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

        public static void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
