/// <summary>
/// Message Id : StatusChangeReport
/// Usage : Report vehicle status
/// Primary : Y
/// Secondary : CommonAck
/// Trigger : (1)Vehicle status or mode changed
///           (2)AGC requests a current status report
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
    public class StatusChangeReport
    {
        /// <summary>
        /// Cyclic number that indicates this transaction is unique
        /// [1...65535]
        /// ex : 5
        /// </summary>
        public int TransactionNo { get; set; }
        /// <summary>
        /// ['AREA'][01...99]
        /// ex : 'AREA45'
        /// </summary>
        public string Area { get; set; } 
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
        /// 'RUN'/'DOWN'/'IDLE'/'WARNING'/'CHARGING'/'MAINTENANCE'
        /// ex : 'DOWN'
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 'OBSTACLE'/'TRAFFIC_JAM'/'COLLISION'/''
        /// ex : 'OBSTACLE'
        /// </summary>
        public string SubStatus { get; set; }
        /// <summary>
        /// ONLINE/OFFLINE
        /// ex : 'ONLINE'
        /// </summary>
        public string Mode { get; set; }
        /// <summary>
        /// radian difference from Virtual North Pole
        /// [0.0000...-1.5700]
        /// ex : -0.01
        /// </summary>
        public double VehicleDirection { get; set; }

    }
}
