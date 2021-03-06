﻿using System.Collections.Generic;
/// <summary>
/// Message Id : TransportCommand
/// Usage : request vehicle to execute the assigned transport
/// Primary : Y
/// Secondary : TransportCommandAck
/// Trigger : any
/// Direction : VMS -> Vehicle
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
        /// 'TRANSPORT'/'CHARGING'/'MAINTENANCE'/'STANDBY'
        /// ex : TRANSPORT
        /// </summary>
        public string CommandType { get; set; }
        /// <summary>
        ///[any]
        /// if <CommandType> equals to 'CHARGING','MAINTENANCE' or 'STANDBY',this property is empty string
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
        public List<string> Route { get; set; }

    }

    public class TransportCommandAck
    {
        /// <summary>
        /// [0..99]
        /// 0 : Accepted,1 : Rejected, 99 : other reason
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
