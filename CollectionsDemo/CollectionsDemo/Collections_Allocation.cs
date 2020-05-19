using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    class Collections_Allocation
    {
        public static void MemAllocMain()
        {
            // Demo: Arrays

            // Array elements are mutable
            // Arrays are fixed size

            var myArray = new int[2];
            myArray[0] = 1;
            myArray[1] = 2;

            Console.WriteLine("myArray[0] = {0}", myArray[0]);

            // Demo: Lists

            // Lists elements are mutable
            // Lists resize as needed
            // Internally lists are arrays that the list type automatically copies to new arrays as more space is needed

            var myList = new List<int>();
            myList.Add(1);
            myList.Add(2);

            Console.WriteLine("myList[1] = {0}", myList[1]);

            // Demo: Dictionaries

            // Dictionaries are key/value pairs

            var myDict = new Dictionary<string, int>();
            myDict.Add("Sunday", 1);
            myDict.Add("Monday", 2);

            Console.WriteLine("myDict[\"Monday\"] = {0}", myDict["Monday"]);

            Console.WriteLine();

            // Demo: Object Initializer Syntax - Arrays

            var myArray2 = new[] { 1, 2 };  // Implicitly typed array
            Console.WriteLine("myArray2[0] = {0}", myArray2[0]);

            // Demo: Object Initializer Syntax - Lists

            var myList2 = new List<int> { 1, 2 }; // Note use of parens is optional here
            Console.WriteLine("myList2[1] = {0}", myList2[1]);

            // Demo: Object Initializer Syntax - Dictionaries

            var myDict2 = new Dictionary<string, int> {
                                { "Sunday", 1 },
                                { "Monday", 2 }
                            };

            Console.WriteLine("myDict2[\"Monday\"] = {0}", myDict2["Monday"]);

            // Enumerations are not collections!


        }
    }
}
