using System;

namespace Converter_App
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            double mean = 0;
            double total = 0;
            
            
            for (/*int repeats = 0; repeats < 1000; repeats++*/;;)
            {
                /*
                 * Testing Binary to decimal - Block
                // binary input
                var input = Numbers.BinInput();
                // new Numbers
                var binaryNumber = new Numbers(input);
                // output input to decimal
                Console.WriteLine($"binary '{input}' converted to decimal is '{binaryNumber.BinarytoDecimal()}'\n");
                */
                
                // decimal input
                var decinput = Numbers.DecimalInput();   // comment out if testing fixed values
                // new Numbers
                var decimalNumber = new Numbers(decinput);
                
                /*
                 * COMMENTED OUT BLOCK BELOW FOR TESTING WITH FIXED VALUES
                 * 
                var decinput = "9223372036854775807";                          // fixed value for testing purposes
                var decimalNumber = new Numbers(decinput);
                
                // times execution time of DecimalToBinary
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var timeStop = decimalNumber.DecimaltoBinary();
                watch.Stop();
                var ts = Math.Round(watch.Elapsed.TotalMilliseconds,7);

                total = Math.Round(total + ts , 7);
                repeats = repeats + 1;
                mean = Math.Round(total / repeats,7);
                Console.WriteLine(f" Mean running time after {repeats} repeats: {mean}");
                
                Console.WriteLine($"decimal '{decinput}' converted to binary is '{timeStop}'\n");
                Console.WriteLine($"Function DecimalToBinary Runtime: {ts}")
                
                */
                
                
                // output input to binary
                // Console.WriteLine($"decimal '{decinput}' converted to binary is '{decimalNumber.DecimaltoBinary()}'\n");
                Console.WriteLine($"decimal '{decinput}' converted to binary is '{decimalNumber.DecimaltoBinary()}'\n");
 
            }
        }
    }
}