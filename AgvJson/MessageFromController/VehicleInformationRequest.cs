using System.Collections.Generic;
/// <summary>
/// Message Id : VehicleInformationRequest
/// Usage : request vehicle to report current state
/// Primary : Y
/// Secondary : VehicleInformationRequestAck
/// Trigger : any
/// Direction : VMS -> Vehicle
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
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
        /// <summary>
        /// A specified message list that vehicle needs to report all
        /// 'BatteryStateReport'/'StatusChangeReport'
        /// ex : {'BatteryStateReport','StatusChangeReport'}
        /// </summary>
        public List<string> ReportIdList { get; set; }

    }

    public class VehicleInformationRequestAck
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
    }
}
