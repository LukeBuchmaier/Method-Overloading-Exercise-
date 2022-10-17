namespace MethodOverloading
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                sum = num1 + num2;
                //if (sum == 1 || sum == -1)
                //{
                //    return $"{sum} dollar.";
                //}
                //else
                //{
                //    return $"{sum} dollars.";
                //}

                response = (sum == 1 || sum == -1) ? $"{sum} dollar." : $"{sum} dollars.";
            }
            return response;
        }

        static void Main(string[] args)
        {
            var x = 20;
            var y = 10;
            var answerSum = Add(x, y);
            var k = 23.4m;
            var j = 55.8m;
            var answerDecimal = Add(k, j);
            var answerDollars = Add(0, 1, true);

            Console.WriteLine($"First Method Overload ansers is {answerSum}");
            Console.WriteLine();
            Console.WriteLine($"Second Method Overload answer is {answerDecimal}");
            Console.WriteLine();
            Console.WriteLine($"Final Metod Overload answre is {answerDollars}");
        
            
        }

    }

}
    