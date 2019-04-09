using System;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for(int i = 1;i <=255;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for(int i = 1;i <= 255;i+=2)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0;i <= 255;i++)
            {
                sum += i;
                Console.WriteLine($"New Number: {i} Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void FindMax(int[] num)
        {
            int max = 0;
            for(int i = 0;i < num.Length;i++)
            {
                if(num[i] > max)
                {
                    max = num[i];
                }   
            }
            Console.WriteLine(max);
        }
        public static void GetAverage(int[]num)
        {
            int avg = 0;
            for(int i = 0;i < num.Length;i++)
            {
                avg += num[i];
            }
            Console.WriteLine(avg / num.Length);
        }
        public static void OddArray()
        {
            for(var i =1; i <= 255;i+=2)
            {
                Console.WriteLine(i);
            }
        }
        public static void GreaterThanY(int[] arr, int y)
        {
            int count = 0;
            for(int i =0; i < arr.Length;i++)
            {
                if(arr[i] > y)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for(int i = 0;i <numbers.Length;i++)
            {
                numbers[i] *= numbers[i];
                Console.WriteLine(numbers[i]);
            }
            
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i < numbers.Length;i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                    
                }
                Console.WriteLine(numbers[i]);
            }
        }
        public static void MinMaxAverage(int[] arr)
        {
            int min = 10;
            int max = 0;
            int avg = 0;
            for(int i =0; i < arr.Length;i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i]; 
                }
                if(arr[i] >  max)
                {
                    max = arr[i];
                }
                avg +=  arr[i]; 
                
            }
           int nim = avg / arr.Length;
            Console.WriteLine($"{min} {max} {nim}");
        }
        public static void ShiftValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length;i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] newArr = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    newArr[i] = "Dojo";
                }
                else
                {
                    newArr[i] = numbers[i];
                }
            }
            return newArr;
        }
        static void Main(string[] args)
        {
            //PrintNumbers();
            //PrintOdds();
            //PrintSum();
            //LoopArray(new int[]{1,2,3,4,5});
            //FindMax(new int[]{1,2,38,4,5});
            //GetAverage(new int[]{10,10});
            //OddArray();
            //GreaterThanY(new int[]{1,2,3,4,5}, 2);
            //SquareArrayValues(new int[]{1,5,10,-10});
            //EliminateNegatives(new int[]{1,-2,3,4,-5});
            //MinMaxAverage(new int[]{1,2,3,4,5});
            //ShiftValues(new int[]{1,2,3,4,5});
            
        }
    }
}
