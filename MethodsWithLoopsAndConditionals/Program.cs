using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            PosNegThousand();
            ThreeThru999();
            TwoIntegers();
            OddOrEven();
            PosOrNegNumber();
            OldEnough2Vote();
            Neg10ToPos10();
            MultiplicationTable();
            DivisionTable();

            Console.WriteLine($"\nTHE END - I enjoyed working on this program. I hope you had fun testing it!");

        }

        public static void PosNegThousand()
        {
            Console.WriteLine($"\nBegin - LukeWarm Section Exercise 1 - Printing (-1000) To (1000)");

            for (int i = 1000; i <= 1000 && i >= -1000; i--)
            {
                Console.WriteLine($"\n{i}");
            }
        }

        public static void ThreeThru999()
        {
            Console.WriteLine($"\nBegin - LukeWarm Section Exercise 2 - Printing 3 to 999 By Increments of Three");

            for (int x = 3; x >= 3 && x <= 999; x += 3)
            {
                Console.WriteLine($"\n{x}");
            }
        }

        public static void TwoIntegers()
        {
            Console.WriteLine($"\nBegin - LukeWarm Section Exercise 3 - Checking If Two Integers Are Equal Or Not");

            Console.WriteLine($"\nEqual Or Not Equal Number Checker: Please enter a number that you would like me to check for you");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = 45;
            
            if(num1 > num2)
            {
                Console.WriteLine($"\nThis number is greater than ({num2})");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"\nThis number is less than ({num2})");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"\nThe number entered ({num1}) is equal to ({num2})");
            }
            else
            {
                Console.WriteLine($"\nOops! Invalid input. Please follow the above instruction");
            }
        }

        public static void OddOrEven()
        {
            Console.WriteLine($"\nBegin - LukeWarm Section Exercise 4 - Checking If An Integer Is An Odd or Even Number");

            Console.WriteLine($"\nOdd or Even Number Checker: What number would you like to check today?");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"\nGuess what? Your number ({num}) is even! Thanks for checking with me...");
            }
            else if (num % 2 == 1)
            {
                Console.WriteLine($"\nAha - Your number ({num}) is odd! Thanks for checking with me...");
            }
            else
            {
                Console.WriteLine($"\nInvalid input. I can only check numbers for you :-)...");
            }
        }

        public static void PosOrNegNumber()
        {
            Console.WriteLine($"\nBegin- LukeWarm Section Exercise 5 - Checking If An Integer Is A Positive or Negative Number");

            Console.WriteLine($"\nPositive or Negative Number Checker: What number would you like to check today?");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine($"\nI hope you're feeling better than the negative number ({num}) you gave me :-)...");
            }
            else if (num >= 0)
            {
                Console.WriteLine($"\nYay! I hope you feel as positive as the number ({num}) you gave me :-D...");
            }
            else
            {
                Console.WriteLine($"\nInvalid input. Yours truly can only check numbers for you ;-)...");
            }
        }

        public static void OldEnough2Vote()
        {
            Console.WriteLine($"\nBegin - LukeWarm Section Exercise 6 - Checking If Someone Is Of Lawful Voting Age (18) In The U.S");

            Console.WriteLine($"\nVoter Age Checker: Please enter your age as of today");
            bool voterAge = int.TryParse(Console.ReadLine(), out int result);

            if (result >= 18)
            {
                Console.WriteLine($"\nCongratulations, you are old enough to cast a legal vote!");
            }
            else if (result < 18)
            {
                Console.WriteLine($"\nAwww man... You are not old enough to cast a legal vote. Maybe next time!");
            }
            else
            {
                Console.WriteLine($"\nOops! Invalid input. Please enter your age as of today");
            }
        }

        public static void Neg10ToPos10()
        {
            Console.WriteLine($"\nBegin - Heating Up Section Exercise 1 - Checking If A Signed (i.e, -17) or An Unsigned Integer Is Within A Range (-10 to 10)");

            Console.WriteLine($"\nNumber Range Checker: Please enter a number and I'll check it for you");
            int num = int.Parse(Console.ReadLine());

            if (num >= -10 && num <= 10)
            {
                Console.WriteLine($"\nThis number ({num}) is inside the range starting with -10 and ending with 10");
            }
            else
            {
                Console.WriteLine($"\nThis number ({num}) is outside the range starting with -10 and ending with 10");
            }
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine($"\nBegin - Heating Up Section Exercise 2 - Creating A Multiplication Table Up To 12");

            Console.WriteLine($"\nMultiplication Table Maker: Please enter a number and I'll make a Multiplication table for you :-)");
            var userEntered = int.TryParse(Console.ReadLine(), out int result);

            for (int i = 1; i <= 12; i++ )
            {
                Console.WriteLine($"\n {i} x {result} = { i * result}");
            }
        }

        public static void DivisionTable()
        {
            Console.WriteLine($"\nBegin - Doing One More Exercise For Extra Practice - Creating A Division Table Up To 45");

            Console.WriteLine($"\nDivison Table Maker: Please enter a number and Ill make a Division table for you :-)");
            var userEntered = decimal.TryParse(Console.ReadLine(), out decimal result);

            for (int x = 1; x <= 45; x++)
            {
                Console.WriteLine($"\n{result} / {x} = {result / x}");
            }
        }
    }
    }

