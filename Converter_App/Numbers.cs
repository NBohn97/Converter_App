using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Converter_App
{
    public class Numbers
    {
        public Numbers(string number)
        {
            Number = number;
        }


        protected string Number { get; set; }

        public long BinarytoDecimal()
        {
            // converts Binary int to string
            var binaryNum = Number;

            // reverses the string
            var rev = binaryNum.ToCharArray();
            Array.Reverse(rev);
            var binaryNumReversedString = new string(rev);

            long normal = 0;
            long multiplier = 1;

            // iterates over the reversed string and multiplies / multiplier is doubled with each iteration
            for (var i = 0; i < binaryNumReversedString.Length; i++)
            {
                // 48 has to be subtracted since unicode would be used otherwise
                normal += (binaryNumReversedString[i] - 48) * multiplier;
                multiplier *= 2;
            }


            // int binaryNumReversed = Int32.Parse(binaryNumReversedString);


            return normal;
        }

        // user input for a binary number
        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        public static string BinInput()
        {
            //string binInput = "10";
            string binInputString;
            var binaryBool = true;

            do
            {
                // prompt for user input
                Console.WriteLine("Enter a binary Number: ");
                binInputString = Console.ReadLine().Replace(" ", "");
                // resets binaryBool if previous number was not a binary number
                binaryBool = true;

                // checks if number only contains zeros and ones
                for (var i = 0; i < binInputString.Length; i++) //test
                    if (binInputString[i].Equals('0') == false && binInputString[i].Equals('1') == false)
                        binaryBool = false;

                // if input either can't be converted to int or is not a binary number user will be prompted again    
            } while (binaryBool == false);

            // binInput = Convert.To(binInputString);

            return binInputString;
        }


        public string DecimaltoBinary()
        {
            // var decimalNum = Convert.ToInt64(Number);
            var decimalNum = long.Parse(Number);
            // the exponent values have to be a BigInteger since they need to be able to be bigger than the biggest long
            BigInteger bigLowestExponent = 0;
            BigInteger expo = 1;
            var convBinary = "";

            // fix for 0 returning nothing
            if (decimalNum == 0)
            {
                convBinary = "0";
                return convBinary;
            }

            // finds the previous multiple of 2 to decimalNum (e.g. decimalNum of 23 would return 16 as biglowestExponent)
            // if decimalNum is bigger than half of the max possible 'long' value the two exponent variables would be
            // bigger than the max 'long' which is why they have to both be a BigInteger and not 'long'.
            // It also has to smaller OR equal since exponents of 2 wouldn't work otherwise
            while (expo <= decimalNum)
            {
                bigLowestExponent = expo;
                expo *= 2;
            }

            // used as a temporary copy of decimalNum
            long decimalNumTemp;
            // since bigLowestExponent can't be bigger than the max 'long' value at this point it can safely be
            // converted to long
            var lowestExponent = (long) bigLowestExponent;

            while (decimalNum != 0 || lowestExponent > 0)
            {
                // calculates remainder
                // decimalNumTemp is necessary for comparing with decimalNum
                decimalNumTemp = decimalNum % lowestExponent;
                // if decimalNumTemp is still the same as decimalNum adds '0' to the end of convBinary
                if (decimalNumTemp == decimalNum)
                    convBinary += "0";
                // if decimalNumTemp is different from decimalNum adds a '1' to the end of convBinary
                else
                    convBinary += "1";
                // value of decimalNum gets updated to decimalNumTemp
                decimalNum = decimalNumTemp;
                // lowestExponent needs to be halved before the while loop begins again
                lowestExponent /= 2;
            }

            return convBinary;
        }

        public static string DecimalInput()
        {
            string decInputString;
            // no real purpose. temporary value for 'out' in TryParse
            long tempval;
            do
            {
                Console.WriteLine("Enter a decimal Number: ");
                decInputString = Console.ReadLine().Replace(" ", "");
            } while (long.TryParse(decInputString, out tempval) == false);

            return decInputString;
        }
    }
}