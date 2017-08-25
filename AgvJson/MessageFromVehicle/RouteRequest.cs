﻿/// <summary>
/// Message Id : RouteRequest
/// Usage : Request route
/// Primary : Y
/// Secondary : RouteRequestAck
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

namespace AgvJson
{
    public class RouteRequest
    {
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
    }
}
