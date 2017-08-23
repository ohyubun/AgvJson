﻿/// <summary>
/// Message Id : RouteRequest
/// Usage : Request route
/// Primary : Y
/// Secondary : RouteRequestAck
/// Trigger : Vehicle turns to Online
/// Direction : Vehicle -> AGC
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
        /// Cyclic number that indicates this transaction is unique
        /// [1...65535]
        /// ex : 5
        /// </summary>
        public int TransactionNo { get; set; }
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
    }
}