using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LamdaDemo
{
    class LambdaArray
    {
        static void Sample_Select_Lambda_Indexed()
        {
            string[] words = { "one", "two", "three" };

            var result = words.Select((w, i) => new
            {
                Index = i,
                Value = w
            });

            Debug.WriteLine("Words with index and value:");
            foreach (var word in result)
                Debug.WriteLine(String.Format("Index {0} is {1}", word.Index, word.Value));
        }
    }
}
