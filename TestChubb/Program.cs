using System;
using System.Linq;

namespace TestChubb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pal = "32113";
            var count = pal.Length;
            var tempString = string.Empty;
            var result = 0;
            for (int i = 0; i <= count; i++)
            {
                var temp = pal.ToCharArray();
                if (i <= temp.Length - 1)
                {
                    var currentvalue = temp[i];
                    tempString += currentvalue;
                    for (int j = i + 1; j <= count; j++)
                    {
                        if (j <= temp.Length - 1)
                        {
                            var sencondVar = temp[j];
                            tempString = tempString + sencondVar.ToString();
                            if (tempString.Equals(RString(tempString)))
                            {
                                result = result + 1;
                            }
                        }

                    }
                    tempString = string.Empty;
                }
            }
            Console.WriteLine("Count  :" + result);
        }

        public static string RString(string value)
        {
            var result = new string(value.ToCharArray().Reverse().ToArray());
            return result;
        }
    }
}
