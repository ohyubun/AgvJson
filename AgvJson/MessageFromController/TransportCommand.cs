using System.Collections.Generic;
/// <summary>
/// Message Id : TransportCommand
/// Usage : request vehicle to execute the assigned transport
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
    public class TransportCommand
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
        /// ex : 'CMD-201709131135001'
        /// </summary>
        public string CommandId { get; set; }
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
        /// <summary>
        /// 'TRANSPORT'/'CHARGING'/'MAINTENANCE'
        /// ex : TRANSPORT
        /// </summary>
        public string CommandType { get; set; }
        /// <summary>
        ///[any]
        /// if <CommandType> equals to 'CHARGING' or 'MAINTENANCE',this property is empty string
        /// ex : ERT-1233-34
        /// </summary>
        public string CarrierId { get; set; }
        /// <summary>
        /// [A...Z][0001...9999]
        /// if <CommandType> equals to 'CHARGING' or 'MAINTENANCE',this property is empty string
        /// ex : A0002
        /// </summary>
        public string FromNodeNo { get; set; }
        /// <summary>
        ///[A...Z][0001...9999]
        /// ex : 002
        /// </summary>
        public string ToNodeNo { get; set; }
        /// <summary>
        /// it indicates a series of node No. that vehicle has to visit between From and To
        /// ex : A0002,A0003,A0004,A0005
        /// </summary>
        public List<string> TravelingPath { get; set; }

    }
}
