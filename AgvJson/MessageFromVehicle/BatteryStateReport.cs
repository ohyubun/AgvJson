/// <summary>
/// Message Id : BatteryStateReport
/// Usage : Report battery state
/// Primary : Y
/// Secondary : CommonAck
/// Trigger : (1)Battery statistics changed
///           (2)AGC requests a current state report
/// Direction : Vehicle -> AGC
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
        /// Cyclic number that indicates this transaction is unique
        /// [1...65535]
        /// ex : 5
        /// </summary>
        public int TransactionNo { get; set; } 
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
        /// (2)AGC requests a report
        /// [00...100]
        /// capacity changed from 93.6 to 95.2,report 95.2
        /// or capacity changed from 83.2 to 79.6
        /// ex : 79.6
        /// </summary>
        public double Capacity { get; set; }
        /// <summary>
        /// trigger is same as <BatteryCapacity>
        /// [00...100]
        /// ex : 80
        /// </summary>
        public double Current { get; set; }
        /// <summary>
        /// trigger is same as <BatteryCapacity>
        /// [00...100]
        /// ex : 45
        /// </summary>
        public double Temperature { get; set; }
        /// <summary>
        /// trigger is same as <BatteryCapacity>
        /// [00...1000]
        /// ex : 80
        /// </summary>
        public double Power { get; set; }

    }
}
