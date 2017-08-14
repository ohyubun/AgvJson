﻿/// <summary>
/// Message Id : TransportCommandAck
/// Usage : Acknowledge for TransportCommand
/// Primary : TransportCommand
/// Secondary : Y
/// Trigger : Vehicle received TransportCommand
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
    public class TransportCommandAck
    {
        /// <summary>
        /// a copy transaction name of primary message from vehicle
        /// 'TransportCommand'/'ModifyTransportCommand'
        /// ex : 'TransportCommand'
        /// </summary>
        public string AckTransactionName { get; set; }
        /// <summary>
        /// A copy transaction no of the primary 
        /// [1...65535]
        /// ex : 5
        /// </summary>
        public int TransactionNo { get; set; }
        /// <summary>
        /// a copy of primary message from controller
        /// ['CMD'][yyyyMMddhh][0001...9999]
        /// ex : CMD-20170913113545001
        /// </summary>
        public string CommandId { get; set; }
        /// <summary>
        /// [0..99]
        /// 0 : accepted,1 : Rejectd, 99 : other reason
        /// ex : 0
        /// </summary>
        public int AckCode { get; set; } 
    }
}