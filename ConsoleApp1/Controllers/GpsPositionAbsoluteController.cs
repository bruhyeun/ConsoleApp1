using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleApp1.Models;

namespace ConsoleApp1.Controllers
{
    class GpsPositionAbsoluteController : DataRecordController
    {
        // Constructors
        public GpsPositionAbsoluteController(params string[] parameters)
        {
            GpsPositionAbsolute dataRecord = new GpsPositionAbsolute(parameters);
        }


        // Properties
        private string table = "GpsPositionAbsolute";
        private string columns = "INSERT INTO GpsPositionAbsolute (Time,Available,PositionType,PositionMode,Latitude,Longitude,Elevation,Nsats,NRefStations,ContinuousLock,GDOP,PDOP,HDOP,VDOP,NDOP,EDOP,RMSE,NorthVelocity,EastVelocity,VertVelocity,GpsHeading,CorrectionAge,UnitVariance,FTest,FNormalised,SDLatitude,SDLongitude,SDHeight,ExternalReliability,SDUW,DQI,LineName,ProcFlags) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
    }
}
