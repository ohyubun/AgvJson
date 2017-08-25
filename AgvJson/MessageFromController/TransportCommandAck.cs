/// <summary>
/// Message Id : TransportCommandAck
/// Usage : Acknowledge for TransportCommand
/// Primary : TransportCommand
/// Secondary : Y
/// Trigger : Vehicle received TransportCommand
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
    public class TransportCommandAck
    {
        /// <summary>
        /// a copy transaction name of primary message from vehicle
        /// 'TransportCommand'/'ModifyTransportCommand'
        /// ex : 'TransportCommand'
        /// </summary>
        public string AckTransactionName { get; set; }
        /// <summary>
        /// a copy of primary message from controller
        /// ['CMD'][yyyyMMddhh][0001...9999]
        /// ex : CMD-20170913113545001
        /// </summary>
        public string CommandId { get; set; }
        /// <summary>
        /// [0..99]
        /// 0 : Accepted,1 : Rejected, 99 : other reason
        /// ex : 0
        /// </summary>
        public int AckCode { get; set; } 
    }
}
