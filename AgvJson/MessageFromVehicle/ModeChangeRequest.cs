/// <summary>
/// Message Id : ModeChangeRequest
/// Usage : Request online/offline change
/// Primary : Y
/// Secondary : CommonAck
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
}
