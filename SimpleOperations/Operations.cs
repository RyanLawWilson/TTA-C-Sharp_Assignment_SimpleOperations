using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOperations
{
    public class Operations
    {
        public Operations()
        {
            Random rand = new Random();
        }

        public int Mathematics(int i = 4)
        {
            int result;
            result = (int)Math.Pow(i, 2);
            return result;
        }

        public int Mathematics(double d = 3.0)
        {
            int result;
            result = (int)Math.Abs(Math.Sqrt(d));
            return result;
        }

        public int Mathematics(string s = "123")
        {
            int result;
            try
            {
                result = (int)(Convert.ToInt32(s) * Math.PI);
            }
            catch (Exception)
            {
                Console.WriteLine("\nCannot convert that to a number... using default number");
                result = (int)(123 * Math.PI);
            }

            return result;
        }
    }
}
