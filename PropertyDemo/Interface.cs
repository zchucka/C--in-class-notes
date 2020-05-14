using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    interface IHotDrink
    {
        //properties go here
        bool Instant
        {
            get;
            set;
        }

        //methods go here
        void AddSugar();
    }
    public class CupOfCoffee : IHotDrink
    {
        private bool instant;
        public CupOfCoffee(bool i)
        {
            instant = i;
        }

        // Property implementation:
        public bool Instant
        {
            get
            {
                return instant;
            }
            set
            {
                instant = value;
            }
        }

        public void AddSugar()
        {
            Console.WriteLine("Adding Sugar!");
        }

        public static void InterfaceMain()
        {
            // Create an instance of a Cup of Coffee Class
            bool i = false;
            CupOfCoffee myCup = new CupOfCoffee(i);

            Console.WriteLine("myCup's instant value is:" + myCup.Instant);

            // let's change the value of Instant
            myCup.Instant = true;
            Console.WriteLine("myCup's instant value is:" + myCup.Instant);


        }
    }



}
