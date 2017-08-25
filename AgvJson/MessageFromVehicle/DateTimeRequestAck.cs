/// <summary>
/// Message Id : DateTimeRequestAck
/// Usage : Acknowledge for DateTimeRequest
/// Primary : DateTimeRequest
/// Secondary : Y
/// Trigger : VMS received DateTimeRequest
/// Direction :  Vehicle -> VMS
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
    public class DateTimeRequestAck
    {
        /// <summary>
        /// 'BatteryStateReport'/'StatusChangeReport'
        /// ex : 'BatteryStateReport'
        /// </summary>
        public string ReportId { get; set; }
        /// <summary>
        /// [yyyy/MM/dd,hh:mm:ss]
        /// ex : 2017/11/15,14:35:42
        /// </summary>
        public string Now { get; set; } 
    }
}
