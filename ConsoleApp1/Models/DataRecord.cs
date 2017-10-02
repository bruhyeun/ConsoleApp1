using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Models
{
    class DataRecord
    {
        // Constructors
        public DataRecord()
        {
        }

        public DataRecord(string timestamp, string procFlag)
        {
            this.TimeStamp = timestamp;
            this.ProcFlags = procFlag;
            Console.WriteLine("Constructor with parameters.");
        }

        // Properties
        public string TimeStamp { get; set; }
        public string ProcFlags { get; set; }
    }
}
