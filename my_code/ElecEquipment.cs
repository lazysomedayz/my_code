using System;

namespace thanawat_sr
{
    class ElectricEquipment
    {
        protected string brand;
        protected bool plug;
        protected bool powerOn;
        public virtual void TurnOn()
        {
            if (plug)
            {
                powerOn = true;
                Console.WriteLine("Now {0} is On!!!", brand);
            }
            else
            {
                Console.WriteLine("It's can't use without plugged");
            }
        }
        public virtual void TurnOff()
        {
            powerOn = false;
            Console.WriteLine("Now {0} is OFF!!!", brand);
        }
    }

    class TV : ElectricEquipment
    {
        public TV(bool plugged, string brand)
        {
            this.brand = brand;
            plug = plugged;
        }
    }

    class Fan : ElectricEquipment
    {
        private int level;
        public Fan(bool plugged, string brand)
        {
            this.brand = brand;
            plug = plugged;
            level = 0;
        }

        public override void TurnOn()
        {
        input:
            Console.Write("Open on what level? [1/2/3] : ");
            string levelstr = Console.ReadLine();
            try
            {
                level = Int32.Parse(levelstr);
                if (level > 0 && level <= 3)
                {
                    Console.WriteLine("Now The {0} fan is on Level {1}", brand, levelstr);
                }
                else
                {
                    goto input;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                goto input;
            }
        }
        public override void TurnOff()
        {
            level = 0;
            Console.WriteLine("Now {0} is OFF!!!", brand);
        }
    }
}
