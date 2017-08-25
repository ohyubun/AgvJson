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
                VehicleId = "AGV013",
                CommandId = "",
                Status = "IDLE",
                SubStatus = "",
            };
            string jsonStatus = JsonConvert.SerializeObject(statusReport);

            Console.WriteLine(jsonStatus);
            Console.ReadKey();
        }
    }
}
