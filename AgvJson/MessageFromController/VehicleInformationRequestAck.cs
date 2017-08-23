/// <summary>
/// Message Id : VehicleInformationRequestAck
/// Usage : Acknowledge for VehicleInformationRequest
/// Primary : RequestVehicleReport
/// Secondary : Y
/// Trigger : Vehicle received VehicleInformationRequest
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
    public class VehicleInformationRequestAck
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
        /// 0 : Accepted,1 : Rejected, 99 : other reason
        /// ex : 0
        /// </summary>
        public int AckCode { get; set; } 
    }
}
