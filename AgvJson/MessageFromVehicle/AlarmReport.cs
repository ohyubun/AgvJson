/// <summary>
/// Message Id : AlarmReport
/// Usage : Report vehicle error
/// Primary : Y
/// Secondary : AlarmReportAck
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
        /// Trouble Level
        /// 1: warning - light trouble that ahs no impact on operation,
        /// 2: alarm- heavy trouble that causes operation suspend, but operator can recover
        /// 3: exception- heavy trouble that cause operation termination unexpectedly
        /// ex : 2
        /// </summary>
        public int Severity { get; set; }
        /// <summary>
        /// ['ALM-'][0001...9999]
        /// ex : 'ALM-0003'
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

    public class AlarmReportAck
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
