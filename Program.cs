using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
            IfLessFizzBuss();
            Even();
            Primes();
            Fibonnacci();
            Sort();
            Find();
            ConcatNumbers();
            ConcatString();
            ReadNumbers();
            Storage();

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Write a method that outputs the following to the console, in a range from 0 to 100:
        /// 0: 
        /// 1: 
        /// 2: 
        /// 3: Fizz
        /// 4: 
        /// 5: Buzz
        /// ...
        /// 15: FizzBuzz
        /// ...
        /// </summary>
        private static void FizzBuzz()
        {
            Console.WriteLine("Method FizzBuzz\n");

            int max = 100;

            for (int i = 0; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(String.Format("{0}: FizzBuzz", i));
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(String.Format("{0}: Buzz", i));
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(String.Format("{0}: Fizz", i));
                    continue;
                }
                else
                {
                    Console.WriteLine(String.Format("{0}:", i));
                    continue;
                }
            }
        }

        /// <summary>
        /// Write a method with similar output to FizzBuzz, however without using branching (if, ? :, or anything like that).
        /// </summary>
        private static void IfLessFizzBuss()
        {
            Console.WriteLine("\nMethod IfLessFizzBuss\n");

            Enumerable.Range(0, 100).Select(
                        n =>
                        (n % 15 == 0) ? String.Format("{0}: FizzBuzz", n) :
                        (n % 3 == 0) ? String.Format("{0}: Fizz", n) :
                        (n % 5 == 0) ? String.Format("{0}: Buzz", n) :
                        String.Format("{0}: ", n))
                        .ToList()
                        .ForEach(Console.WriteLine);
        }

        /// <summary>
        /// Write a method that outputs numbers from 0 to 100 indicating whether they are even or odd, as exemplified below.
        /// 0 - Even
        /// 1 - Odd
        /// 2 - Even
        /// 3 - Odd
        /// ...
        /// </summary>
        private static void Even()
        {
            Console.WriteLine("\nMethod Even\n");

            int max = 100;

            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(String.Format("{0} - {1}", i, (i % 2 == 0 ? "Even" : "Odd")));
            }
        }

        /// <summary>
        /// Write a method that receives a number input from the console, and outputs all the numbers indicating if they
        /// are prime numbers or not, starting from 0 up to the number entered in the console, like the example below.
        /// for 0 to N (N being read from the console)
        /// 0 - Not prime
        /// 1 - Not prime
        /// 2 - Prime
        /// 3 - Prime
        /// 4 - Not prime
        /// ....
        /// </summary>
        private static void Primes()
        {
            Console.WriteLine("\nMethod Primes\n");
            Console.Write("Write any number: ");
            string input = Console.ReadLine();

            int max = int.Parse(input);

            for (int i = 0; i <= max; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(String.Format("{0} - Prime", i));
                }
                else
                {
                    Console.WriteLine(String.Format("{0} - Not Prime", i));
                }
            }
        }

        private static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Write a method that receives a number input from the console, and outputs that number of members of the
        /// fibonnacci sequence, like exemplified below.
        /// Ex. (First 6 numbers of fibonnacci sequence): 0, 1, 1, 2, 3, 5, 8
        /// </summary>
        private static void Fibonnacci()
        {
            Console.WriteLine("\nMethod Fibonnacci\n");
            Console.Write("Write count number: ");
            string input = Console.ReadLine();

            int max = int.Parse(input);
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < max; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                Console.WriteLine(a);
            }
        }

        /// <summary>
        /// Create the numbersay [8, 16, 9, 15, 8, 1] and sort it so that it becomes [1, 8, 8, 9, 15, 16] without using c#'s libraries or methods.
        /// Expected output:
        /// [1, 8, 8, 9, 15, 16]
        /// </summary>
        private static void Sort()
        {
            Console.WriteLine("\nMethod Sort\n");

            int[] numbers = { 8, 16, 9, 15, 8, 1 };
            int temp = 0;

            Console.WriteLine("Array original: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            for (int write = 0; write < numbers.Length; write++)
            {
                for (int sort = 0; sort < numbers.Length - 1; sort++)
                {
                    if (numbers[sort] > numbers[sort + 1])
                    {
                        temp = numbers[sort + 1];
                        numbers[sort + 1] = numbers[sort];
                        numbers[sort] = temp;
                    }
                }
            }

            Console.WriteLine("\nArray sorted: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        /// <summary>
        /// Change the Sort method so that it returns the sorted numbersay and find the number M on that numbersay.
        /// M comes from the console.
        /// If M is not present on the numbersay, output a message saying so. If it's present, show the index of M on the numbersay.
        /// Do not use c#'s libraries or method for the search.
        /// Use the best sort method you can think of to search in a ordered numbersay.
        /// </summary>
        private static void Find()
        {
            Console.WriteLine("\nMethod Find\n");

            int[] numbers = { 8, 16, 9, 15, 8, 1 };
            int temp = 0;

            for (int write = 0; write < numbers.Length; write++)
            {
                for (int sort = 0; sort < numbers.Length - 1; sort++)
                {
                    if (numbers[sort] > numbers[sort + 1])
                    {
                        temp = numbers[sort + 1];
                        numbers[sort + 1] = numbers[sort];
                        numbers[sort] = temp;
                    }
                }
            }

            Console.WriteLine("\nArray sorted: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.Write("\nWrite any number: ");
            string input = Console.ReadLine();
            int m = int.Parse(input);

            if (m > numbers[numbers.Length - 1])
            {
                Console.WriteLine("Number not find");
            }
            else
            {
                int index = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if(m == numbers[i])
                    {
                        index = i;
                        Console.WriteLine("index of m: " + i);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Read 3 numbers from the console and concat them (without using strings) so that the resulting number is "XYZ".
        /// Ex. X = 5, Y = 6, Z = 15 -> 5615
        /// Remember, use only mathematical operations and not string operations.
        /// </summary>
        private static void ConcatNumbers()
        {
            Console.WriteLine("\nMethod ConcatNumbers\n");

            int max = 3;
            string[] inputs = new string[max];

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Write any number: ");
                inputs[i] = Console.ReadLine();
            }

            Console.WriteLine("Result");
            foreach(string input in inputs)
            {
                Console.Write(input);
            }
        }

        /// <summary>
        /// Read words from the console until you read the word "stop".
        /// After reading stop, show all the read words (except 'stop') in order, separated by comma.
        /// Ex. - Input: 
        /// This
        /// is
        /// a
        /// test
        /// stop
        /// 
        /// Would result on the output:
        /// This,is,a,test
        /// </summary>
        private static void ConcatString()
        {
            Console.WriteLine("\n\nMethod ConcatString\n");

            List<string> inputs = new List<string>();

            bool stopNow = false; 

            while(!stopNow)
            {
                Console.Write("Write any it: ");
                string input = Console.ReadLine();  
                inputs.Add(input);
                stopNow = string.Equals(input.ToLower(), "stop");
            }

            Console.WriteLine("Output:");
            foreach (var input in inputs)
            {
                if(string.Compare(input.ToLower(), "stop") == 0)
                {
                    break;
                }
                else
                {
                    Console.Write(String.Format("{0} ", input));
                }
            }
        }

        /// <summary>
        /// Read N (where N is the first number read from the console) numbers from the console.
        /// This shouldn't allow duplicated numbers, show a message if the read number was previously read and ignore the duplicated entry.
        /// After reading N numbers, show:
        /// Which numbers were read more than once (don't need to show how many time it was shown),
        /// The median and average of those numbers;
        /// Which of those numbers are even, prime and member of the first 100 fibonnacci numbers.
        /// The concatenated result of those numbers (like you did on ConcatNumbers).
        /// </summary>
        private static void ReadNumbers()
        {
            Console.WriteLine("\nMethod ConcatString\n");

            Console.Write("Write count number: ");
            string count = Console.ReadLine(); 
            int n = int.Parse(count);
            List<string> inputs = new List<string>();
            List<int> inputRepeats = new List<int>();
            bool repeat;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Write any number: ");
                string input = Console.ReadLine();
                repeat = false;

                for (int j = 0; j < inputs.Count; j++)
                {
                    if(input.Equals(inputs[j]))
                    {
                        repeat = true;
                        inputRepeats.Add(int.Parse(input));
                        Console.WriteLine("Número ja lido");
                        //break;
                    }

                }

                if (!repeat)
                {
                    inputs.Add(input);
                }
            }

            Console.WriteLine("\nList of numbers");
            foreach (var number in inputs)
            {
                Console.Write(String.Format("{0} ", number));
            }

            Console.WriteLine("\nNumber repeats");
            foreach (var number in inputRepeats)
            {
                Console.Write(String.Format("{0} ", number));
            }
            
            int sumNumberRepeats = 0;
            foreach (var number in inputRepeats)
            {
                sumNumberRepeats += number;
            }

            if(sumNumberRepeats != 0)
            {
                float averageNumbersRepeats = sumNumberRepeats / inputRepeats.Count;
                Console.WriteLine(String.Format("\nAverage number repeats is {0}", averageNumbersRepeats));
            }
            else
            {
                Console.WriteLine(String.Format("\nAverage number repeats is {0}", 0));
            }

            if (sumNumberRepeats != 0)
            {
                float averageOfNumbersRepeats = inputRepeats.Count / inputs.Count;
                Console.WriteLine(String.Format("\nAverage of number repeats is {0}", averageOfNumbersRepeats));
            }
            else
            {
                Console.WriteLine(String.Format("\nAverage of number repeats is {0}", 0));
            }
            

            int a = 0;
            int b = 1;
            List<int> sequenceFibonnaci = new List<int>();
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < 100; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                sequenceFibonnaci.Add(a);
            }

            List<int> containInFibonacci = new List<int>();

            foreach (var numberRepeat in inputRepeats)
            {
                if (sequenceFibonnaci.Contains(numberRepeat))
                {
                    containInFibonacci.Add(numberRepeat);
                }
            }

            Console.WriteLine("\nNumbe repeats contain on sequence fibonacci: ");
            foreach (var number in containInFibonacci)
            {
                Console.Write(String.Format("{0} ", number));
            }

            Console.WriteLine("\nNumbe repeats concatenated contain on sequence fibonacci: ");
            foreach (var number in containInFibonacci)
            {
                Console.Write(String.Format("{0}", number));
            }
        }

        /// <summary>
        /// Read 4 numbers from the console. These numbers are garanteed to be inside the range 0 ~ 255.
        /// Store these numbers in the most efficient way you can think of and then show them on the console again.
        /// </summary>
        private static void Storage()
        {
            Console.WriteLine("\nMethod ConcatString\n");

            int count = 4;
            List<string> inputs = new List<string>();
            int numberAddInputs = 0;

            while(numberAddInputs != 4)
            {
                Console.Write("Write any number: ");
                string input = Console.ReadLine();

                inputs.Add(input);
                numberAddInputs++;
            }

            string pathFile = "c:/Numbers.txt";

            //File.Create(pathFile);

            using (StreamWriter writeText = new StreamWriter("Numbers.txt"))
            {
                foreach (var number in inputs)
                {
                    writeText.Write(String.Format("{0}", number));
                }

                writeText.Close();
            }

            using (StreamReader readTxt = new StreamReader("Numbers.txt"))
            {
                Console.WriteLine("Numbers on txt:");
                Console.WriteLine(readTxt.ReadLine());
                readTxt.Close();
            }
        }
    }
}
