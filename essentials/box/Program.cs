using System;
using System.Collections.Generic;
namespace box
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<object> stuff  = new List<object>
            {

            };
            stuff.Add(7);
            stuff.Add(28);
            stuff.Add(-1);
            stuff.Add("chair");
            stuff.Add(true);
            int sum = 0;
            foreach(var manu in stuff){
                //Console.WriteLine(manu);
                if(manu is int)
                {
                  sum += (int)manu;
                  Console.WriteLine(sum);
                }
            }
            

        }
    }
}
