﻿/// <summary>
/// Message Id : BatteryStateReport
/// Usage : Report battery state
/// Primary : Y
/// Secondary : BatteryStateReportAck
/// Trigger : (1)Battery statistics changed
///           (2)VMS requests a current state report
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
    public class BatteryStateReport
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
        /// reporting timing :
        /// (1)capacity is less than {100,95,90,85,80...,15,10,5,0}
        /// or greater than {100,95,90,85,80...,15,10,5,0}
        /// (2)VMS requests a report
        /// [00...100]
        /// capacity changed from 93.6 to 95.2,report 95.2
        /// or capacity changed from 83.2 to 79.6
        /// ex : 79.6
        /// </summary>
        public double Capacity { get; set; }
        /// <summary>
        /// trigger is same as <Capacity>
        /// [00...100]
        /// ex : 80
        /// </summary>
        public double Current { get; set; }
        /// <summary>
        /// trigger is same as <Capacity>
        /// [00...100]
        /// ex : 45
        /// </summary>
        public double Temperature { get; set; }
        /// <summary>
        /// trigger is same as <Capacity>
        /// [00...1000]
        /// ex : 80
        /// </summary>
        public double Power { get; set; }
        /// <summary>
        /// trigger is same as <Capacity>
        /// [0...999999]
        /// ex : 8906766.5
        /// </summary>
        public double WorkingTime { get; set; }
    }

    public class BatteryStateReportAck
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
