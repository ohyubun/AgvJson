using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AgvJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //StatusChangeReport obj = new StatusChangeReport
            //{
            //    VehicleId = "AGV013",
            //    CommandId = "",
            //    Status = "IDLE",
            //};


            //DateTimeRequestAck obj = new DateTimeRequestAck
            //{
            //    Now = DateTime.Now
            //};
            //AlarmReport obj = new AlarmReport
            //{
            //    VehicleId = "AGV013",
            //    AlarmCode= "ALM-9001",
            //    Severity=2,
            //    CommandId= "CMD-201709131135001",
            //    Description="Lifting Motor bottom sensor error.",
            //    State=true
            //};
            //BatteryStateReport obj = new BatteryStateReport
            //{
            //    VehicleId = "AGV013",
            //    Capacity = 94.5,
            //    CommandId = "CMD-201709131135001",
            //    Current = 15.5,
            //    Power = 41.6,
            //    Temperature=52.7
            //};
            //NodeCheckReport obj = new NodeCheckReport
            //{
            //    VehicleId = "AGV013",
            //    CommandId = "CMD-201709131135001",
            //    NodeNo="N00121",
            //    Heading=90,
            //    X = 10094.5,
            //    Y = 21505.8,
            //    X_Angle_Shift = 0.12,
            //    Y_Angle_Shift = 0.12,
            //    X_Linear_Shift = 90.5,
            //    Y_Linear_Shift=-25.8,

            //};
            //TransportStateReport obj = new TransportStateReport
            //{
            //     VehicleId = "AGV013",
            //     CommandId = "CMD-201709131135001",
            //     CarrierId = "ECR-1233-34",
            //     State = "FROM_ARRIVED"

            //};
           RecipeRequestAck obj = new RecipeRequestAck
           {
                AckCode = 0,
                Reason = "",
                Nodes = new List<RouteNode>
                 {
                     new RouteNode{ NodeNo="A0001", Heading=90, NodeType=1,MotionType="R0", X=0,Y=0},
                     new RouteNode{ NodeNo="A0002", Heading=90, NodeType=1,MotionType="R0", X=100.0,Y=100.0},
                     new RouteNode{ NodeNo="A0003", Heading=90, NodeType=1,MotionType="R0", X=200.0,Y=200.0},
                     new RouteNode{ NodeNo="A0004", Heading=90, NodeType=1,MotionType="R0", X=300.0,Y=300.0},
                 },
               Settings = new Recipe
               {
                   BatterySafetyLevel = 5678,
                   ChargingCapacity = 95,
                   ChargingTime = 12,
                   ObstacleLevel1Length = 1.0,
                   ObstacleLevel2Length = 6.0,
                   TravelingSpeed = 1.5

               }
               //Settings = new Dictionary<string, double>
               // {
               //     { "BatterySafetyLevel" , 5678 },
               //     { "ChargingCapacity" , 95 },
               //     { "ChargingTime" , 12 },
               //     { "ObstacleLevel1Length" , 1.0 },
               //     { "ObstacleLevel2Length" , 6.0 },
               //     { "TravelingSpeed" , 1.5 }
               // }
           };

            //TransportCommand obj = new TransportCommand
            //{
            //    CommandId = "CMD - 201709131135001",
            //    VehicleId = "AGV0019",
            //    CommandType="TRANSPORT",
            //    CarrierId="ECA-6576-0671",
            //    FromNodeNo="A0017",
            //    ToNodeNo="A0035",
            //    Route = new List<string>
            //     {
            //        "A0008","A0009","A0010","A0011","A0012","A0013","A0014",
            //        "A0015","A0016","A0017","A0018","A0019","A0028","A0032",
            //        "A0033","A0034","A0035"
            //     }
            //};

            //ModeChangeRequestAck obj = new ModeChangeRequestAck
            //{
            //    AckCode=0,
            //    Reason="",
            //};
           
            string jsonText = JsonConvert.SerializeObject(obj);
            Console.WriteLine(jsonText);
            Console.ReadKey();
        }
    }
}
