using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;

namespace ConsoleApp1.Controllers
{
    class DataRecordController
    {
        // Constructors
        public DataRecordController()
        {
        }

        // Methods
        public bool SetConnection()
        {
            try
            {
                this.sqlConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void OpenConnection()
        {
            this.sqlConnection.Open();
        }

        public void CloseConnection()
        {
            this.sqlConnection.Close();
        }

        public void ExecuteQuery(string textQuery)
        {
            //db = new SQLiteDataAdapter(textQuery, this.sqlConnection);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = textQuery;

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetHashCode()); // I finished here.
                Console.WriteLine(ex.Message);
            }
            
        }
        //string sql = "CREATE TABLE highscores (name VARCHAR(20), score INT)";
        //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        //command.ExecuteNonQuery();
        public bool TableExists(string table)
        {
            return true;
        }

        public int CreateDataRecord(string table, params string[] parameters)
        {
            string headerList = "";
            foreach (var record in parameters)
                headerList = headerList + record + '\n';

            Console.WriteLine("Created in "+ this.TableName + ":\n" + headerList);
            return 0;
        }

        public int ReadDataRecord(string table, params string[] parameters)
        {
            Console.WriteLine("Read: " + parameters.ToString());
            return 0;
        }

        public int UpdateDataRecord(string table, params string[] parameters)
        {
            Console.WriteLine("Updated: " + parameters.ToString());
            return 0;
        }

        public int DeleteDataRecord(string table, params string[] parameters)
        {
            Console.WriteLine("Deleted: " + parameters.ToString());
            return 0;
        }

        // Properties
        public string TableName { get; set; }
        public string Columns { get; set; }

        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        //private SQLiteDataAdapter db;
        //private DataSet DS = new DataSet();
        //private DataTable DT = new DataTable();



        //private void LoadData()
        //{
        //    SetConnection();
        //    this.sqlConnection.Open();
        //    sqlCommand = this.sqlConnection.CreateCommand();
        //    string CommandText = "select id, desc from mains";
        //    DB = new SQLiteDataAdapter(CommandText, sql_con);
        //    DS.Reset();
        //    DB.Fill(DS);
        //    DT = DS.Tables[0];
        //    Grid.DataSource = DT;
        //    this.sqlConnection.Close();
        //}

        //private void Add()
        //{
        //    string textSQLQuery = "insert into  mains (desc) values ('" + txtDesc.Text + "')";
        //    ExecuteQuery(textSQLQuery);
        //}
    }
}
