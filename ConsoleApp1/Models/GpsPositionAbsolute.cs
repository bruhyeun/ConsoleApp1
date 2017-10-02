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
            this.IsValidHeader(parameters);
        }

        // Properties
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

        public bool IsValidHeader(string[] parameters)
        {
            if (parameters.Length != this.GetType().GetProperties().Length)
            {
                Console.WriteLine("Number of columns(" + parameters.Length + ") does not match number of properties(" +
                    (this.GetType().GetProperties().Length) + ").");
                return false;
            }
            else
            {
                for (var i = 0; i < parameters.Length; i++)
                {
                    foreach (var prop in this.GetType().GetProperties())
                    {
                        if (parameters[i].ToUpper().Equals(prop.Name.ToUpper()))
                            Console.WriteLine("Header: " + parameters[i] + "; Property: " + prop.Name);
                    }
                }
                return true;
            }
        }
    }
}
