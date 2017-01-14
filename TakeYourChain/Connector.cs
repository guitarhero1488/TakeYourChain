using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TakeYourChain
{
    class Connector
    {        
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ReferenceDatabase.mdf;Integrated Security=True";
        private static string commandRead = "select * from [Reference]";
        public static DataSet receivedData;
        
        public static void Read()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commandRead, connection);
                    receivedData = new DataSet();
                    adapter.Fill(receivedData);                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddRow(params string[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commandRead, connection);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                    receivedData.Tables[0].Rows.Add(parameters);
                    adapter.Update(receivedData);
                    MessageBox.Show(cmdBuilder.GetUpdateCommand().CommandText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
