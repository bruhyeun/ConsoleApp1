using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Models
{
    class GpsPositionAbsolute : DataRecord
    {
        // Constructors
        public GpsPositionAbsolute()
        {
        }

        public GpsPositionAbsolute(params string[] parameters)
        {
            this.data = parameters;
            this.TimeStamp = data[0];
            this.Available = int.Parse(data[1]);
            this.PositionType = data[2];
            this.PositionMode = data[3];
            this.Latitude = data[4];
            this.Longitude = data[5];
            this.Elevation = float.Parse(data[6]);
            this.NSats = int.Parse(data[7]);
            this.NRefStations = int.Parse(data[8]);
            this.ContinuousLock = int.Parse(data[9]);
            this.Gdop = float.Parse(data[10]);
            this.Pdop = float.Parse(data[11]);
            this.Hdop = float.Parse(data[12]);
            this.Vdop = float.Parse(data[13]);
            this.Ndop = float.Parse(data[14]);
            this.Edop = float.Parse(data[15]);
            this.Rmse = float.Parse(data[16]);
            this.NorthVelocity = float.Parse(data[17]);
            this.EastVelocity = float.Parse(data[18]);
            this.VertVelocity = float.Parse(data[19]);
            this.GpsHeading = float.Parse(data[20]);
            this.CorrectionAge = int.Parse(data[21]);
            this.UnitVariance = float.Parse(data[22]);
            this.FTest = float.Parse(data[23]);
            this.FNormalised = float.Parse(data[24]);
            this.SDLatitude = float.Parse(data[25]);
            this.SDLongitude = float.Parse(data[26]);
            this.SDHeight = float.Parse(data[27]);
            this.ExternalReliability = float.Parse(data[28]);
            this.Sduw = float.Parse(data[29]);
            this.Dqi = float.Parse(data[30]);
            this.LineName = data[31];
            this.ProcFlags = data[32];

            this.DisplayParams();
        }

        public GpsPositionAbsolute(bool headerFlag, params string[] parameters)
        {
            if (headerFlag)
            {
                if (this.IsValidHeader(parameters))
                {
                    Console.WriteLine("Header: ");
                    Console.WriteLine(parameters);
                }
                else
                {
                    Console.WriteLine("Invalid header.");
                }
            }
        }

        // Properties
        private string[] data;

        public int Available { get; set; }
        public string PositionType { get; set; }
        public string PositionMode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public float Elevation { get; set; }
        public int NSats { get; set; }
        public int NRefStations { get; set; }
        public int ContinuousLock { get; set; }
        public float Gdop { get; set; }
        public float Pdop { get; set; }
        public float Hdop { get; set; }
        public float Vdop { get; set; }
        public float Ndop { get; set; }
        public float Edop { get; set; }
        public float Rmse { get; set; }
        public float NorthVelocity { get; set; }
        public float EastVelocity { get; set; }
        public float VertVelocity { get; set; }
        public float GpsHeading { get; set; }
        public int CorrectionAge { get; set; }
        public float UnitVariance { get; set; }
        public float FTest { get; set; }
        public float FNormalised { get; set; }
        public float SDLatitude { get; set; }
        public float SDLongitude { get; set; }
        public float SDHeight { get; set; }
        public float ExternalReliability { get; set; }
        public float Sduw { get; set; }
        public float Dqi { get; set; }
        public string LineName { get; set; }

        public bool IsValidHeader(params string[] parameters)
        {
            if (parameters.Length != this.GetType().GetProperties().Length)
            {
                Console.WriteLine("Number of columns(" + parameters.Length + ") does not match number of properties(" +
                    (this.GetType().GetProperties().Length) + ").");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DisplayParams()
        {
            foreach (var prop in this.GetType().GetProperties())
                Console.WriteLine(prop.Name + ": ");
        }
    }
}
