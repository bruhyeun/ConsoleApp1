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
        public GpsPositionAbsoluteController()
        {
            this.TableName = tableName;
        }

        public GpsPositionAbsoluteController(params string[] parameters) : this()
        {
            GpsPositionAbsolute dataRecord = new GpsPositionAbsolute(parameters);
        }

        public GpsPositionAbsoluteController(bool headerFlag, params string[] parameters) : this()
        {
            GpsPositionAbsolute dataRecord = new GpsPositionAbsolute(headerFlag, parameters);
            dataRecord.IsValidHeader(parameters);
            
        }

        // Properties
        public string tableName = "GpsPositionAbsolute";
        public string createGpsAbsoluteTable = "CREATE TABLE GpsPositionAbsolute (" +
            "Time DATETIME," +
            "Available INT," +
            "PositionType VARCHAR(20)," +
            "PositionMode VARCHAR(20)," +
            "Latitude VARCHAR(20)," +
            "Longitude VARCHAR(20)," +
            "Elevation FLOAT," +
            "Nsats INT," +
            "NRefStations INT," +
            "ContinuousLock INT," +
            "GDOP FLOAT," +
            "PDOP FLOAT," +
            "HDOP FLOAT," +
            "VDOP FLOAT," +
            "NDOP FLOAT," +
            "EDOP FLOAT," +
            "RMSE FLOAT," +
            "NorthVelocity FLOAT," +
            "EastVelocity FLOAT," +
            "VertVelocity FLOAT," +
            "GpsHeading FLOAT," +
            "CorrectionAge INT," +
            "UnitVariance FLOAT," +
            "FTest FLOAT," +
            "FNormalised FLOAT," +
            "SDLatitude FLOAT," +
            "SDLongitude FLOAT," +
            "SDHeight FLOAT," +
            "ExternalReliability FLOAT," +
            "SDUW FLOAT," +
            "DQI FLOAT," +
            "LineName VARCHAR(50)," +
            "ProcFlags VARCHAR(10)" +
            ")";
        public string insertGpsAbsoluteRecord = "INSERT INTO GpsPositionAbsolute (" +
            "Time," +
            "Available," +
            "PositionType," +
            "PositionMode," +
            "Latitude," +
            "Longitude," +
            "Elevation," +
            "Nsats," +
            "NRefStations," +
            "ContinuousLock," +
            "GDOP," +
            "PDOP," +
            "HDOP," +
            "VDOP," +
            "NDOP," +
            "EDOP," +
            "RMSE," +
            "NorthVelocity," +
            "EastVelocity," +
            "VertVelocity," +
            "GpsHeading," +
            "CorrectionAge," +
            "UnitVariance," +
            "FTest," +
            "FNormalised," +
            "SDLatitude," +
            "SDLongitude," +
            "SDHeight," +
            "ExternalReliability," +
            "SDUW," +
            "DQI," +
            "LineName," +
            "ProcFlags" +
            ") VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
    }
}
