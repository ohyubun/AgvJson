/// <summary>
/// Message Id : NodeCheckReport
/// Usage : Report node check result
/// Primary : Y
/// Secondary : NodeCheckReportAck
/// Trigger : Tag reader reports information
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
    public class NodeCheckReport
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
        /// [A...Z][0001...9999]
        /// (*)Reading error by fixed value 'NODE_ID_ERROR'
        /// ex : 'A0002'
        /// </summary>
        public string NodeNo { get; set; }
        /// <summary>
        /// Vehicle~
        /// angle degree difference from Virtual North Pole at virtual X-Y coordinate
        /// [0...360]
        /// ex : 90
        /// </summary>
        public double Heading { get; set; }
        /// <summary>
        /// Vehicle~
        /// X position at virtual X-Y coordinate
        /// [any]
        /// ex : -0.01
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Vehicle~
        /// Y position at virtual X-Y coordinate
        /// [any]
        /// ex : -0.01
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// radian
        /// [0.0000...-1.5700]
        /// ex : 0.01
        /// </summary>
        public double X_Angle_Shift { get; set; }
        /// <summary>
        /// radian
        /// [0.0000...-1.5700]
        /// ex : 0.01
        /// </summary>
        public double Y_Angle_Shift { get; set; }
        /// <summary>
        /// radian
        /// [-59.99..59.99]
        /// ex : 0.12
        /// </summary>
        public double X_Linear_Shift { get; set; }
        /// <summary>
        /// radian
        /// [-59.99..59.99]
        /// ex : 0.12
        /// </summary>
        public double Y_Linear_Shift { get; set; }

    }

    public class NodeCheckReportAck
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
