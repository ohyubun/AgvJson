/// <summary>
/// Message Id : ModeChangeRequest
/// Usage : Request online/offline change
/// Primary : Y
/// Secondary : ModeChangeRequestAck
/// Trigger : Vehicle truns Online/Offline
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
    public class ModeChangeRequest
    {
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
        /// <summary>
        /// ONLINE/OFFLINE
        /// ex : 'ONLINE'
        /// </summary>
        public string Mode { get; set; }
        /// <summary>
        /// [mode change reason]
        /// ex : '','PM','TroubleShooting',''
        /// </summary>
        public string Reason { get; set; }
    }

    public class ModeChangeRequestAck
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
