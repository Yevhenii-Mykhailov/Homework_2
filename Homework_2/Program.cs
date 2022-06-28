using System;

namespace Homework_2
{
    class Program
    {
        
        static int GetCalcutaionResults(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        static int DetermineQuaterOfEnteredCoords(int x, int y)
        {
            int result = 0;

            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x < 0 && y > 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else if (x > 0 && y < 0)
            {
                result = 4;
            }

            return result;
        }

        static (int min, int medium, int high) PrintAscendingOrder(int a, int b, int c)
        {
            int min = 0;
            int medium = 0;
            int high = 0;

            if (a >= b && b >= c)
            {
                min = c;
                medium = b;
                high = a;
            }
            else if (a >= c && c >= b)
            {
                min = b;
                medium = c;
                high = a;
            }
            else if (b >= a && b >= c && a >= c)
            {
                min = c;
                medium = a;
                high = b;
            }
            else if (b >= c && c >= a)
            {
                min = a;
                medium = c;
                high = b;
            }
            else if (c >= a && a >= b)
            {
                min = b;
                medium = a;
                high = c;
            }
            else if (c >= b && b >= a)
            {
                min = a;
                medium = b;
                high = c;
            }

            return (min, medium, high);
        }

        static (double x1, double x2) GetRootsOfQuadraticEquation(int a, int b, int c)
        {
            double discriminant = b * b - 4 * a * c;
            double x1 = 0;
            double x2 = 0;

            if (discriminant == 0)
            {
                x1 = -b / 2 * a;
                x2 = x1;
            }
            else if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }

            return (x1, x2);
        }

        static void PrintNumberCapitalization()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            int firstNumber = userInput / 10;
            int secondNumber = userInput % 10;

            string firstNumberName = null;
            string secondNumberName = null;
            string result = null;

            if (userInput >=10 && userInput <20)
            {
                switch (userInput)
                {
                    case 10:
                        result = "Ten";
                        break;
                    case 11:
                        result = "Eleven";
                        break;
                    case 12:
                        result = "Twelve";
                        break;
                    case 13:
                        result = "Thirteen";
                        break;
                    case 14:
                        result = "Fourteen";
                        break;
                    case 15:
                        result = "Fifteen";
                        break;
                    case 16:
                        result = "Sixteen";
                        break;
                    case 17:
                        result = "Seventeen";
                        break;
                    case 18:
                        result = "Eighteen";
                        break;
                    case 19:
                        result = "Nineteen";
                        break;
                }
            }
            else
            {
                switch (firstNumber)
                {
                    case 2:
                        firstNumberName = "Twenty";
                        break;
                    case 3:
                        firstNumberName = "Thirty";
                        break;
                    case 4:
                        firstNumberName = "Fourty";
                        break;
                    case 5:
                        firstNumberName = "Fifty";
                        break;
                    case 6:
                        firstNumberName = "Sixty";
                        break;
                    case 7:
                        firstNumberName = "Seventy";
                        break;
                    case 8:
                        firstNumberName = "Eighty";
                        break;
                    case 9:
                        firstNumberName = "Ninety";
                        break;
                }

                switch (secondNumber)
                {
                    case 1:
                        secondNumberName = "One";
                        break;
                    case 2:
                        secondNumberName = "Two";
                        break;
                    case 3:
                        secondNumberName = "Three";
                        break;
                    case 4:
                        secondNumberName = "Four";
                        break;
                    case 5:
                        secondNumberName = "Five";
                        break;
                    case 6:
                        secondNumberName = "Six";
                        break;
                    case 7:
                        secondNumberName = "Seven";
                        break;
                    case 8:
                        secondNumberName = "Eight";
                        break;
                    case 9:
                        secondNumberName = "Nine";
                        break;
                }
                result = firstNumberName + "-" + secondNumberName;
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
           
        }
    }
}

