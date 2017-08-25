/// <summary>
/// Message Id : AlarmReport
/// Usage : Report vehicle error
/// Primary : Y
/// Secondary : CommonAck
/// Trigger : Vehicle has trouble and stop working
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
    public class AlarmReport
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
        /// ['ALM-'][0001...0099]
        /// ex : 'ALM-003'
        /// </summary>
        public string AlarmCode { get; set; }
        /// <summary>
        /// [error reason]
        /// ex : 'Left servo motor overflow.'
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// true : occur,false : release
        /// ex: true
        /// </summary>
        public bool State { get; set; }

    }
}
