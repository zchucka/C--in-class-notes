using System;
using System.Collections.Generic;
using System.Text;

namespace IndexDemo
{
    public class IndexerBaseClass
    {
        public virtual int this[int indexerValue]
        {
            get
            {
                Console.WriteLine("Get of IndexerBaseClass; indexer value: " + indexerValue);
                return 100;
            }
            set
            {
                Console.WriteLine("Set of IndexerBaseClass; indexer value: " + indexerValue + " set value " + value);
            }

        }
    }
    public class IndexerDerivedClass : IndexerBaseClass
    {
        public override int this[int indexerValue]
        {
            get
            {
                int dValue = base[indexerValue];
                Console.WriteLine("Get of IndexerDerivedClass; indexer value: " + indexerValue + " dValue from base class indexer: " + dValue);
                return 500;
            }
            set
            {
                Console.WriteLine("Set of IndexerDerivedClass; indexer value: " + indexerValue + " set value " + value);
                base[indexerValue] = value;
            }

        }
    }

    class IndexerPloyTest
    {
        public static void ExecuteMain()
        {

            IndexerDerivedClass indexDerived = new IndexerDerivedClass();
            indexDerived[2] = 300;
            Console.WriteLine(indexDerived[2]);
            Console.ReadLine();

        }
    }
}
