using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
     
    
    static class Program
    {
        private static void BSort(this int[] arr) 
        {
            int n = arr.Length;
              for(int i = 0; i<n; ++i)
                for (int j = 0; j < n-i-1; j++)
                   if (arr[j]>arr[j + 1])
                    {
                        int temp = arr[j]; 
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

        }

       
        
        static void Main(string[] args)
        {
            if ( args.Length == 0 )
	    {
                  Console.WriteLine("No Command Line ARguments");
                  return;

            }

            int [] arr = new int[args.Length];

            for( int i=0; i< arr.Length ; ++i )
                 arr[i] = Convert.ToInt32(args[i]);


           
            arr.BSort();
            foreach( var n2 in arr ) 
                Console.WriteLine(n2);
            
            
            Console.Read();

        }
    }
}