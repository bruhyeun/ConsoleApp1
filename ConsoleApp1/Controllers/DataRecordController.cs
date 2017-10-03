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
                sqlConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void OpenConnection()
        {
            sqlConnection.Open();
        }

        public void CloseConnection()
        {
            sqlConnection.Close();
        }

        public void ExecuteQuery(string textQuery)
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = textQuery;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ExecuteQuery(string textQuery, params string[] parameters)
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = textQuery;
            columns = this.Columns.Split(',');
            for (int i = 0; i < columns.Length; i++)
            {
                sqlCommand.Parameters.AddWithValue(columns[i].ToString().Trim(), parameters[i]);
            }

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

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

        private string[] columns;
        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
    }
}
