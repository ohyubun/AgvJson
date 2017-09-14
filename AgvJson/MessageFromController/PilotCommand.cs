using System.Collections.Generic;
/// <summary>
/// Message Id : PilotCommand
/// Usage : request vehicle to do pilot by manual
/// Primary : Y
/// Secondary : PilotCommandAck
/// Trigger : any
/// Direction : VMS client-> Vehicle
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
    public class PilotCommand
    {
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
        /// <summary>
        /// 'STEERING'/'SLAM_MAPPING'/'HOME_SEARCHING'
        /// ex : STEERING
        /// </summary>
        public string CommandType { get; set; }
        /// <summary>
        /// Valid on <CommandType> = 'STEERING'
        /// 0~10 M/s
        /// ex : 1.2
        /// </summary>
        public double Speed { get; set; }
        /// <summary>
        /// Valid on <CommandType> = 'STEERING'
        /// 'FORWARD','BACKWARD','LEFT,'RIGHT'
        /// ex : FORWARD
        /// </summary>
        public string Heading { get; set; }

        /// <summary>
        /// Valid on <CommandType> = 'STEERING'
        /// it indicates the duration that vehicle keeps running
        /// 0~10 sec
        /// ex : 5.5
        /// </summary>
        public double ActionTime { get; set; }
    }

    public class PilotCommandAck
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
