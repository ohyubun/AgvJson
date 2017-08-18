using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AgvJson
{
    class Program
    {
        static void Main(string[] args)
        {
            StatusChangeReport statusReport = new StatusChangeReport
            {
                Area = "AREA001",
                VehicleId = "AGV013",
                CommandId = "",
                Mode = "ONLINE",
                Status = "IDLE",
                SubStatus = "",
                TransactionNo = 1,
                VehicleDirection = 0.0134
            };
            string jsonStatus = JsonConvert.SerializeObject(statusReport);


            Console.WriteLine(jsonStatus);
            Console.ReadKey();
        }
    }
}
