/// <summary>
/// Message Id : TransportStateReport 
/// Usage : Report transport command executing status
/// Primary : Y
/// Secondary : TransportStateReportAck
/// Trigger : (1)current transport command state
///
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
    public class TransportStateReport
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
        /// 'START'/'END'
        /// 'FROM_ARRIVED'/'FROM_LEFT'/'TO_ARRIVED'/'TO_LEFT'/'CARRIER_ID_CHECKED'/'CARRIER_ID_MISMATCH'
        /// ex : 'START'
        /// </summary>
        public string State { get; set; }
        /// <summary>
        ///[any]
        /// if <State> equals to 'FROM_LEFT','TO_LEFT','CARRIER_ID_CHECKED','CARRIER_ID_MISMATCH',this property is meaningful 
        /// (*)Reading error by fixed value 'CARRIER_ID_ERROR'
        /// ex : ECR-1233-34
        /// </summary>
        public string CarrierId { get; set; }
    }

    public class TransportStateReportAck
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
