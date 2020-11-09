using System;

namespace thanawat_sr
{
    class ElectricEquipment
    {
        protected string brand;
        protected bool plug;
        protected bool powerOn;

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public ElectricEquipment(bool plugged = false, string brand = "Unknown")
        {
            Brand = brand;
            plug = plugged;
        }

        public virtual void TurnOn()
        {
            if (plug)
            {
                powerOn = true;
                Console.WriteLine("Now {0} is On!!!\n", brand);
            }
            else
            {
                Console.WriteLine("It's can't use without plugged\n");
            }
        }
        public virtual void TurnOff()
        {
            powerOn = false;
            Console.WriteLine("Now {0} is OFF!!!\n", brand);
        }

        public virtual string ToString()
        {

            Console.WriteLine(GetType());
            string returntext = string.Format("Brand : {0}\nPlugged : {1}\nPower On : {2}\n", brand, plug, powerOn);
            Console.WriteLine(returntext);
            return returntext;
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
            if (plug)
            {
            input:
                Console.Write("Open {0} on what level? [1/2/3] : ", brand);
                string levelstr = Console.ReadLine();
                try
                {
                    level = Int32.Parse(levelstr);
                    if (level > 0 && level <= 3)
                    {
                        powerOn = true;
                        Console.WriteLine("\nNow {0} is on Level {1}!!!\n", brand, levelstr);
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
            else
            {
                Console.WriteLine("It's can't use without plugged\n");
            }
        }
        public override void TurnOff()
        {
            level = 0;
            Console.WriteLine("Now {0} is OFF!!!", brand);
        }

        public override string ToString()
        {
            Console.WriteLine(GetType());
            string returntext = string.Format("Brand : {0}\nPlugged : {1}\nPower On : {2}\nLevel : {3}\n", brand, plug, powerOn, level);
            Console.WriteLine(returntext);
            return returntext;
        }
    }
}
