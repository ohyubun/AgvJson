/// <summary>
/// Message Id : StatusChangeReport
/// Usage : Report vehicle status
/// Primary : Y
/// Secondary : CommonAck
/// Trigger : (1)Vehicle status or mode changed
///           (2)VMS requests a current status report
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
    public class StatusChangeReport
    {
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
        /// <summary>
        /// a copy for executing command
        /// ['CMD'][yyyyMMddhh][0001...9999]
        /// ex : CMD-20170913113545001
        /// </summary>
        public string CommandId { get; set; }
        /// <summary>
        /// 'RUN'/'DOWN'/'IDLE'/'WARNING'/'CHARGING'/'MAINTENANCE/’WALKING'
        /// ex:'DOWN'
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 'OBSTACLE'/'TRAFFIC_JAM'/'COLLISION'/''
        /// ex : 'OBSTACLE'
        /// </summary>
        public string SubStatus { get; set; }
        /// <summary>
        /// radian difference from Virtual North Pole at virtual X-Y coordinate
        /// [0.0000...-1.5700]
        /// ex : -0.01
        /// </summary>
        public double Heading { get; set; }
        /// <summary>
        /// X position at virtual X-Y coordinate
        /// [any]
        /// ex : -0.01
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Y position at virtual X-Y coordinate
        /// [any]
        /// ex : -0.01
        /// </summary>
        public double Y { get; set; }
    }
}
