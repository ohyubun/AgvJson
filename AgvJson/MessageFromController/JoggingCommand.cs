using System.Collections.Generic;
/// <summary>
/// Message Id : JoggingCommand
/// Usage : request vehicle to execute motor jogging,Motor zeroing,home searching,moving
/// Primary : Y
/// Secondary : JoggingCommandAck
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
    public class JoggingCommand
    {
        /// <summary>
        /// ['AGV'][0001...9999]
        /// ex : 'AGV0034'
        /// </summary>
        public string VehicleId { get; set; }
        /// <summary>
        /// 'MOTOR_JOGGING'/'MOTOR_ZEROING'
        /// ex : TRANSPORT
        /// </summary>
        public string CommandType { get; set; }
        /// <summary>
        /// 'RIGHT_WHEEL','LEFT_WHEEL','FORWARD_WHEEL','HEADING_WHEEL'
        /// 'RIGHT_1_WHEEL','RIGHT_2_WHEEL','LEFT_1_WHEEL','LEFT_2_WHEEL'
        /// 'LIFT_ARM','ROTATE_ARM','FORWARD_ARM','ROLLER_ARM'
        /// if <CommandType> equals to 'MOTOR_JOGGING'/'MOTOR_ZEROING',this property is meaningful
        /// ex : RIGHT_WHEEL
        /// </summary>
        public string MotorName { get; set; }
        /// <summary>
        /// 0~10 M/s for line speed,RPM for rotation speed
        /// ex : 0.5
        /// </summary>
        public double Speed { get; set; }
        /// <summary>
        /// 'FORWARD','BACKWARD'
        /// ex : FORWARD
        /// </summary>
        public string Direction { get; set; }
      

    }

    public class JoggingCommandAck
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
