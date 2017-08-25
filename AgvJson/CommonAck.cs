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
    public class PrimaryMessage
    {
        /// <summary>
        /// a copy transaction name of primary message from vehicle
        /// 'AlarmReport'/'StatusChangeReport'/...
        /// ex : 'AlarmReport'
        /// </summary>
        public string MessageId { get; set; }
        /// <summary>
        /// A copy transaction no of the primary 
        /// [1...65535]
        /// ex : 5
        /// </summary>
        public string ExpectedReply { get; set; }
        /// <summary>
        /// [0..99]
        /// 0 : OK,1 : NG, 99 : other reason
        /// ex : 0
        /// </summary>
        public int AckCode { get; set; } 
    }
}
