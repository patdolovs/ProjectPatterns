using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace TestProjekt
{
    class Postgre
    {
        string server;
        string port;
        string id;
        string password;
        string database;
        string connectionString;
        private NpgsqlConnection conn;
        public Postgre(string server = "127.0.0.1", string port = "5432", string id = "postgres", string password = "postgres", string database = "postgres")
        {
            this.server = server;
            this.port = port;
            this.id = id;
            this.password = password;
            this.database = database;
            connectionString = "Server = " + server + "; " + " Port = " + port + "; " + "User Id = " + id + "; " + "Password = " + password + "; " + " Database = " + database + ";";
            openConnection();
        }


        public NpgsqlConnection openConnection() {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            
            return conn;
        }

        public void executeQuery(string query) {

            NpgsqlCommand npCommand = new NpgsqlCommand(query, conn);
            npCommand.ExecuteNonQuery();
            conn.Close();

        }

        public DataTable fetchAllDataFromTable(string tableName) {

            string sql = $"select * from {tableName}";

            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataSet dataSet = new DataSet();

                dataSet.Reset();
                da.Fill(dataSet);
                DataTable dataTable = new DataTable();

                dataTable = dataSet.Tables[0];

                conn.Close();
           

                return dataTable;
            }

            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }

           

        }


    }
}
