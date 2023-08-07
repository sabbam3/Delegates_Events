using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Delegates_Events
{
    public delegate double Calculate(double num1, double num2);
    public class DelegateExamples
    {
        

        public static Action<string> PrintTextV1 = delegate (string text) { Console.WriteLine(text); };
        
        public static Action<string> PrintTextV2 = i => Console.WriteLine(i);
        
        public static Func<int, int, int> CalculateMultiply = delegate (int num1, int num2) { return num1 * num2; };
        
        public static double CalculateSub(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double CalculateDer(double num1, double num2)
        {
            return num1/num2;
        }
       

        
    }
}
