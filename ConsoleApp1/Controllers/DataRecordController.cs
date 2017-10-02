using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Controllers
{
    class DataRecordController
    {
        // Constructors
        public DataRecordController()
        {
        }

        // Methods
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
        //public bool TableExistence { get; set; }
    }
}
