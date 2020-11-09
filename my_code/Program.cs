using System;
using System.Collections.Generic;

namespace thanawat_sr
{
    class Program
    {
        static void Main(string[] args)
        {
            bool plugged = true;
            bool unplugged = false;

            TV tv = new TV(unplugged, "LG");
            tv.TurnOn();
            tv.TurnOff();

            Fan fan = new Fan(plugged, "HATARI");
            fan.TurnOn();
            fan.TurnOff();

            List<ElectricEquipment> eeList = new List<ElectricEquipment>();
            eeList.Add(new ElectricEquipment());
            eeList.Add(new TV(plugged, "SAMSUNG"));
            eeList.Add(new Fan(unplugged, "MISHUBISHI ELEC"));

            foreach (var item in eeList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
