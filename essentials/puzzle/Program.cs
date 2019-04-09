using System;
using System.Collections.Generic;
namespace puzzle
{
    class Program
    {
        public static int[] RandomArray()
        {
            int[] arr = {5,6,7,8,9,11,12,13,14};
            int max = 0;
            int sum = 0;
            int min = 10;
            for(int i = 0; i < arr.Length;i++)
            {
                
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                if(arr[i] > max)
                {
                    max = arr[i];
                }

                sum += arr[i];
                
            }
            Console.WriteLine($"{min} is min {max} is the man {sum} is the sum");
            return new int[] {min};
        }
        public static string CoinFlip()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a coin!");
            var coin = new List<string> {"heads", "tails"};
            int index = rand.Next(coin.Count);
            var name = coin[index];
            coin.RemoveAt(index);


            Console.WriteLine(name);
            
            return null;

        }
        public static void TossMultipleCoins(int num)
        {
            int heads = 0;
            int tails = 0;
            double ratio = 0;
            for (int i = 0; i < num; i++) {
                string result = CoinFlip();
                if (result == "heads") {
                    heads++;
                } else {
                    tails++;
                }
            }
            ratio = heads / tails;
            Console.WriteLine(ratio); 
        }
        public static void Names()
        {
            List<string> friends = new List<string>
            {
                "Todd","Tiffany","Charlie","Geneva","Sydney"
            };
            
            for(int i = 0;i < friends.Count; i++)
            {
                string temp = friends[i];
                int rand = Random.Range(i, friends.Count);

            }


            Console.WriteLine("Shuffled Names");
            foreach(var i in friends)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Longer than 5");
            foreach(var i in friends)
            {
                if(i.Length > 5)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
           // RandomArray();
           //CoinFlip();
           TossMultipleCoins(3);
        }
    }
}
