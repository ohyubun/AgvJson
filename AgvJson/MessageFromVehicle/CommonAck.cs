/// <summary>
/// Message Id : CommonAck
/// Usage : Acknowledge for general primary message
/// Primary : any
/// Secondary : Y
/// Trigger : VMS received primary message
/// Direction :  VMS -> Vehicle
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
    public class CommonAck
    {
        /// <summary>
        /// a copy transaction name of primary message from vehicle
        /// 'AlarmReport'/'StatusChangeReport'/...
        /// ex : 'AlarmReport'
        /// </summary>
        public string AckTransactionName { get; set; }
        /// <summary>
        /// [0..99]
        /// 0 : Accepted,1 : NG, 99 : other reason
        /// ex : 0
        /// </summary>
        public int AckCode { get; set; } 
    }
}
