using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace thanawat_sr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================= Unplugged and Power off  \n");
            bool plugged = false;

            TV tv = new TV(plugged, "LG");
            Fan fan = new Fan(plugged, "HATARI");

            tv.ToString();
            tv.TurnOn();

            fan.ToString();
            fan.TurnOn();

            Console.WriteLine("========================================= Plugged and Power off \n");

            plugged = true;
            TV tv2 = new TV(plugged, "SAMSUNG");
            Fan fan2 = new Fan(plugged, "TOSHIBA");

            tv2.ToString();
            fan2.ToString();

            Console.WriteLine("========================================= Plugged and Power On \n");

            TV tv3 = new TV(plugged, "PANASONIC");
            Fan fan3 = new Fan(plugged, "MISUBISHI");

            tv3.TurnOn();
            tv3.ToString();

            fan3.TurnOn();
            fan3.ToString();

            Console.WriteLine("========================================= Get Type In List \n");

            List<ElectricEquipment> eeList = new List<ElectricEquipment>();
            eeList.Add(new ElectricEquipment());
            eeList.Add(new TV(plugged, "SAMSUNG"));
            eeList.Add(new Fan(plugged, "MISUBISHI ELEC"));

            foreach (var item in eeList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
