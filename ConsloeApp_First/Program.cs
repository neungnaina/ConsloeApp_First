using System;

namespace ConsoleApp_First
{
    class Program
    {
        static void Main(string[] args)

        {
       for (int iterator = 0; iterator<3; iterator++)
        {
            Console.WriteLine("Outer Loop"+iterator);// Execute 3 times

            for (int _iterator = 0; _iterator < 2; _iterator++)
            {
                Console.WriteLine("Inner Loop" + iterator);// Execute 2 times
            }
        
                
        }
            Console.WriteLine("-----------------------------For loop----------------------------------");//For loop
            {
                for (int iterator = 0; iterator < 5; iterator++)
                {
                    Console.WriteLine("Counter" + iterator);// 
                    
                }
                Console.WriteLine("-----------------------------For loop----------------------------------");//For loop
            }


            string[] brandTV= { "LG","SONY","SAMSUNG","TCL","JVC"};

        foreach(string television in brandTV)
        {
            Console.WriteLine("Brand" + television);
        }
        
        Console.WriteLine("-----------------------------Brand TV------------------------------------");//Brand TV
        
        int iterator0 = 0;
        while (iterator0 < 5)
        {
            Console.WriteLine("iterator" + iterator0);
            iterator0++;
        }
        
        Console.WriteLine("-----------------------------WhlieLoop------------------------------------");//Do/WhlieLoop
            {        
            
         int iterator1 = 0;
                do
                {
                    Console.WriteLine("iterator" + iterator1);
                    iterator1++;
                }
                while (iterator1 < 5);
            
                Console.WriteLine("-----------------------------Do/WhlieLoop------------------------------------");//Do/WhlieLoop
            }
        }

    }
}


