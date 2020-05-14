using System;
using System.Collections.Generic;
using System.Text;

namespace IndexDemo
{
    class Users
    {
        // Declare an array

        private string[] arr = new string[3];

        // Define the indexer

        public string this[int indexerValue]
        {
            get { return arr[indexerValue]; }
            set { arr[indexerValue] = value; }
        }

        // Overload an indexer with string type

        public string this[string indexerValue]
        {
            get
            {
                foreach (string name in arr)
                {
                    if (name.ToLower() == indexerValue.ToLower())

                    {
                        return name.ToUpper();
                    }
                }
                return null;
            }
        }
        public int this[string indexerValue, int indexerintValue]
        {
            set
            {
                Console.WriteLine("String and integer value indexerValue:" + indexerValue + " ,indexerintValue: " + indexerintValue + " ,value:" + value);
            }
        }

    }

    class OverloadIndexer
    {
        public static void OverloadIndexerMain()
        {
            Users ulist = new Users();

            ulist[0] = "Suresh Dasari";
            ulist[1] = "Rohini Alavala";
            ulist[2] = "Trishika Dasari";

            // Accessing Indexer with int type

            Console.WriteLine("*****Indexer with int Type*****");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ulist[i]);
            }

            // Accessing Indexer with string type
            Console.WriteLine("*****Indexer with string Type*****");
            Console.WriteLine(ulist["Suresh Dasari"]);
            Console.WriteLine(ulist["Rohini Alavala"]);
            Console.WriteLine(ulist["Trishika Dasari"]);
            ulist["address", 2] = 40;
            Console.ReadLine();
        }

    }
}
