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
        public int CreateDataRecord(params string[] dataRecord)
        {
            Console.WriteLine("Created: " + dataRecord.ToList().ToString());
            return 0;
        }

        public int ReadDataRecord(params string[] dataRecord)
        {
            Console.WriteLine("Read: " + dataRecord.ToString());
            return 0;
        }

        public int UpdateDataRecord(params string[] dataRecord)
        {
            Console.WriteLine("Updated: " + dataRecord.ToString());
            return 0;
        }

        public int DeleteDataRecord(params string[] dataRecord)
        {
            Console.WriteLine("Deleted: " + dataRecord.ToString());
            return 0;
        }
    }
}
