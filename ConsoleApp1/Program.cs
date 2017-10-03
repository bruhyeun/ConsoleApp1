using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using ConsoleApp1.Controllers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\EclaveaB\\source\\repos\\ConsoleApp3\\ConsoleApp3\\test\\export\\ascii\\201706270903\\FugroSynergy-Survey_2-Starfix.XP2-10202Raw-GpsPositionAbsolute.csv";
            Console.WriteLine("Enter File Path: ");
            filePath = Console.ReadLine();

            filePath = "C:\\Users\\EclaveaB\\source\\repos\\ConsoleApp3\\ConsoleApp3\\test\\export\\ascii\\201706270903\\FugroSynergy-Survey_2-Starfix.XP2-10202Raw-GpsPositionAbsolute.csv";

            if (File.Exists(filePath))
            {
                string[] content = File.ReadAllLines(filePath);
                string[] header = content[0].Split(',');

                GpsPositionAbsoluteController dataRecordController = new GpsPositionAbsoluteController(true, header);

                bool isConnected = dataRecordController.SetConnection();

                if (isConnected)
                {
                    dataRecordController.OpenConnection();
                    dataRecordController.ExecuteQuery(dataRecordController.createGpsPositionAbsoluteTable);

                    Console.WriteLine("Data loading started (" + DateTime.Now + ")");
                    for (var i = 1; i < content.Length; i++)
                        dataRecordController.ExecuteQuery(dataRecordController.insertGpsPositionAbsoluteRecord, content[i].Split(','));

                    dataRecordController.CloseConnection();
                    Console.WriteLine("Data loading finished (" + DateTime.Now + ")");
                }
                else
                {
                    Console.WriteLine("Unable to connect.");
                }

                Console.ReadLine();

                Console.WriteLine("Number of Lines: " + content.Length);
                Console.WriteLine("Current header of file:");
                Console.WriteLine(content[0]);

                Console.ReadLine();
            }
        }
    }
}
