using System.Collections.Generic;
/// <summary>
/// Message Id : ModifyTransportCommand
/// Usage : request vehicle to change transport command
/// Primary : Y
/// Secondary : TransportCommandAck
/// Trigger : any
/// Direction : AGC -> Vehicle
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
    public class ModifyTransportCommand
    {
        /// <summary>
        /// Cyclic number that indicates this transaction is unique
        /// [1...65535]
        /// ex : 5
        /// </summary>
        public int TransactionNo { get; set; }
        /// <summary>
        /// a unique Id for tracking transportation
        /// ['CMD'][yyyyMMddhh][0001...9999]
        /// ex : CMD-20170913113545001
        /// </summary>
        public string CommandId { get; set; }
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : AGV0034
        /// </summary>
        public string VehicleId { get; set; }
        /// <summary>
        /// 'CANCEL'/'ABORT'/'FORCE_END'/'SUSPEND'/'RESUME'/'CHANGE_PATH'
        /// ex : 'ABORT'
        /// </summary>
        public string ModifyType { get; set; }
        /// <summary>
        /// it indicates a series of node No. that vehicle has to visit between From and To
        /// ex : 002,003,004,005
        /// </summary>
        public List<string> NewTravelingPath { get; set; }
    }
}
