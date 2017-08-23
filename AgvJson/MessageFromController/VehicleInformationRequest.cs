using System.Collections.Generic;
/// <summary>
/// Message Id : VehicleInformationRequest
/// Usage : request vehicle to report current state
/// Primary : Y
/// Secondary : VehicleInformationRequestAck
/// Trigger : any
/// Direction : AGC -> Vehicle
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
    public class VehicleInformationRequest
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
        /// <summary>
        /// 'BatteryStateReport'/'StatusChangeReport'
        /// ex : 'BatteryStateReport'
        /// </summary>
        public string ReportId { get; set; }

    }
}
