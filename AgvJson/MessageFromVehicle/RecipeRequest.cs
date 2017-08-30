/// <summary>
/// Message Id : RecipeRequest
/// Usage : Request Map
/// Primary : Y
/// Secondary : RecipeRequestAck
/// Trigger : Vehicle turns to Online
/// Direction : Vehicle -> VMS
/// JSON example :
/// 
/// 
/// 
/// 
/// 
/// 
/// </summary>
using System.Collections.Generic;

namespace AgvJson
{
    public class RecipeRequest
    {
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
    }

    public class RecipeRequestAck
    {
        /// <summary>
        /// [0..99]
        /// 0 : Accepted,1 : NG, 99 : other reason
        /// ex : 0
        /// </summary>
        public int AckCode { get; set; }
        /// <summary>
        /// any string
        /// '', 'Busy','Alarm'.....
        /// ex : 'Busy'
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// all nodes list
        /// </summary>
        public List<RouteNode> Nodes { get; set; }

        /// <summary>
        /// parameter from VMS
        /// </summary>
        public Recipe Settings { get; set; }
        //public Dictionary<string, double> Settings { get; set; }
    }

    public class RouteNode {
        /// <summary>
        ///[A...Z][0001...9999]
        /// ex : 002
        /// </summary>
        public string NodeNo { get; set; }
        /// <summary>
        /// 1:normal,2:corner,3:branch,4:charging,5:standby,6:load/unload
        /// ex: 1
        /// </summary>
        public int NodeType { get; set; }
        /// <summary>
        /// X position at virtual X-Y coordinate
        ///  unit :mm
        /// ex: 1.05
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Y position at virtual X-Y coordinate
        ///  unit :mm
        /// ex: 1.05
        public double Y { get; set; }
        /// <summary>
        /// angle of this from virtual North Pole
        /// unit : degree
        /// ex: 1.05
        public double Heading { get; set; }
        /// <summary>
        /// 2 differential speed wheels control
        /// R0: no rotation,R90: enable rotating by +90/-90,R180:enable rotating by +180
        /// ex: R0
        /// </summary>
        public string MotionType { get; set; }
        /// <summary>
        /// reserved for future
        /// </summary>
        public string Parameter { get; set; }
        /// <summary>
        ///[A...Z][0001...9999]
        /// ex : 002
        /// </summary>
        public string PrevNo { get; set; }
        /// <summary>
        ///[A...Z][0001...9999]
        /// ex : 002
        /// </summary>
        public string NextNo { get; set; }
        /// <summary>
        ///[A...Z][0001...9999]
        /// ex : 002
        /// </summary>
        public string LeftNo { get; set; }
        /// <summary>
        ///[A...Z][0001...9999]
        /// ex : 002
        /// </summary>
        public string RightNo { get; set; }
        /// <summary>
        /// length from this to previous(mm)
        /// ex : 100
        /// </summary>
        public int PrevLength { get; set; }
        /// <summary>
        /// length from this to next(mm)
        /// ex : 100
        /// </summary>
        public int NextLength { get; set; }
        /// <summary>
        /// length from this to Left(mm)
        /// ex : 100
        /// </summary>
        public int LeftLength { get; set; }
        /// <summary>
        /// length from this to Right(mm)
        /// ex : 100
        /// </summary>
        public int RightLength { get; set; }
        /// <summary>
        /// angle from this to previous(degree)
        /// ex : 180
        /// </summary>
        public double PrevAngle { get; set; }
        /// <summary>
        /// angle from this to Next(degree)
        /// ex : 0
        /// </summary>
        public double NextAngle { get; set; }
        /// <summary>
        /// angle from this to Left(degree)
        /// ex : 270
        /// </summary>
        public double LeftAngle { get; set; }
        /// <summary>
        /// angle from this to Left(degree)
        /// ex : 90
        /// </summary>
        public double RightAngle { get; set; }
        /// <summary>
        /// break distance before stop at Prev(mm)
        /// ex : 500
        /// </summary>
        public int PrevBrakeLength { get; set; }
        /// <summary>
        /// break distance before stop at Next(mm)
        /// ex : 500
        /// </summary>
        public int NextBrakeLength { get; set; }
        /// <summary>
        /// break distance before stop at Left(mm)
        /// ex : 500
        /// </summary>
        public int LeftBrakeLength { get; set; }
        /// <summary>
        /// break distance before stop at Righ(mm)
        /// ex : 500
        /// </summary>
        public int RightBrakeLength { get; set; }
        /// <summary>
        /// Ratio of traveling speed for going to prev
        /// ex : 1
        /// </summary>
        public double PrevSpeedRatio { get; set; }
        /// <summary>
        /// Ratio of traveling speed for going to Next
        /// ex : 1
        /// </summary>
        public double NextSpeedRatio { get; set; }
        /// <summary>
        /// Ratio of traveling speed for going to Left
        /// ex : 1
        /// </summary>
        public double LeftSpeedRatio { get; set; }
        /// <summary>
        /// Ratio of traveling speed for going to Right
        /// ex : 1
        /// </summary>
        public double RightSpeedRatio { get; set; }
        /// <summary>
        /// Cost of traveling  for going to prev
        /// ex : 1
        /// </summary>
        public double PrevCost { get; set; }
        /// <summary>
        /// Cost of traveling  for going to Next
        /// ex : 0
        /// </summary>
        public double NextCost { get; set; }
        /// <summary>
        /// Cost of traveling  for going to Left
        /// ex : 0
        /// </summary>
        public double LeftCost { get; set; }
        /// <summary>
        /// Cost of traveling  for going to Right
        /// ex : 0
        /// </summary>
        public double RightCost { get; set; }
    }



    public class Recipe
    {
        /// <summary>
        /// Battery Working time safety waterlevel(hours)
        /// ex : 16000
        /// </summary>
        public double BatterySafetyLevel { get; set; }
        /// <summary>
        /// Battery capacity after charging(%)
        /// ex : 95
        /// </summary>
        public double ChargingCapacity { get; set; }
        /// <summary>
        /// Battery capacity time limit
        /// ex : 12
        /// </summary>
        public double ChargingTime { get; set; }
        /// <summary>
        /// TravelingSpeed (M/s)
        /// ex : 1.20
        /// </summary>
        public double TravelingSpeed { get; set; }
        /// <summary>
        /// Obstacle Level 1 Length (M)
        /// ex : 1.0
        /// </summary>
        public double ObstacleLevel1Length { get; set; }
        /// <summary>
        /// Obstacle Level 2 Length (M)
        /// ex : 6.0
        /// </summary>
        public double ObstacleLevel2Length { get; set; }
    }
}
