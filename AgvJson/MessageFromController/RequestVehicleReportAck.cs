/// <summary>
/// Message Id : RequestVehicleReportAck
/// Usage : Acknowledge for RequestVehicleReport
/// Primary : RequestVehicleReport
/// Secondary : Y
/// Trigger : Vehicle received RequestVehicleReport
/// Direction :  Vehicle -> AGC
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
    public class RequestVehicleReportAck
    {
        /// <summary>
        /// A copy transaction no of the primary 
        /// [1...65535]
        /// ex : 5
        /// </summary>
        public int TransactionNo { get; set; }
        /// <summary>
        /// 'BatteryStateReport'/'StatusChangeReport'
        /// ex : 'BatteryStateReport'
        /// </summary>
        public string ReportId { get; set; }
        /// <summary>
        /// [0..99]
        /// 0 : accepted,1 : Rejectd, 99 : other reason
        /// ex : 0
        /// </summary>
        public int AckCode { get; set; } 
    }
}
