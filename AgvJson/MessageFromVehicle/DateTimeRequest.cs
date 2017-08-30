/// <summary>
/// Message Id : DateTimeRequest
/// Usage : Request online/offline change
/// Primary : Y
/// Secondary : DateTimeRequestAck
/// Trigger : Vehicle truns Online or daily time sync
/// Direction : Vehicle -> VMS
/// JSON example :
/// 
/// 
/// 
/// 
/// 
/// 
/// </summary>
using System;

namespace AgvJson
{
    public class DateTimeRequest
    {
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
    }

    public class DateTimeRequestAck
    {
        /// <summary>
        /// ex : 2017-08-28T12:24:30.9816423+08:00
        /// </summary>
        public DateTime Now { get; set; }
    }
}
