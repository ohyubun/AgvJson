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
}
