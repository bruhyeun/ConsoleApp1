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
                //string sql = "CREATE TABLE highscores (name VARCHAR(20), score INT)";
                //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                //command.ExecuteNonQuery();
                //sql = "insert into highscores (name, score) values ('Me', 3000)";
                //command = new SQLiteCommand(sql, m_dbConnection);
                //command.ExecuteNonQuery();
                //sql = "insert into highscores (name, score) values ('Myself', 6000)";
                //command = new SQLiteCommand(sql, m_dbConnection);
                //command.ExecuteNonQuery();
                //sql = "insert into highscores (name, score) values ('And I', 9001)";
                //command = new SQLiteCommand(sql, m_dbConnection);
                //command.ExecuteNonQuery();
                //m_dbConnection.Close();


                string[] content = File.ReadAllLines(filePath);
                string[] header = content[0].Split(',');

                GpsPositionAbsoluteController dataRecordController = new GpsPositionAbsoluteController(true, header);
                dataRecordController.TableName = dataRecordController.tableName;
                bool isConnected = dataRecordController.SetConnection();

                if (isConnected)
                {
                    dataRecordController.OpenConnection();
                    dataRecordController.ExecuteQuery(dataRecordController.createGpsAbsoluteTable);
                    dataRecordController.CloseConnection();
                }
                else
                {
                    Console.WriteLine("Unable to connect.");
                }

                //int transaction;
                //for (var i = 1; i < content.Length; i++)
                //    transaction = dataRecordController.CreateDataRecord(dataRecordController.TableName, content[i].Split(','));


                //GpsPositionAbsolute record = new GpsPositionAbsolute(content[0].Split(','));
                Console.ReadLine();

                Console.WriteLine("Number of Lines: " + content.Length);
                Console.WriteLine("Current header of file:");
                Console.WriteLine(content[0]);

                Console.ReadLine();
            }
        }
    }
}
