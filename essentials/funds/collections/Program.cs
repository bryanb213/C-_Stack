using System;
using System.Collections.Generic;
namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numarr;
            // numarr = new int[]{1,2,3,4};
            // //Console.WriteLine(numarr[0]);
            // List<string> stuff = new List<string>();//empty list
            // stuff.Add("tv");
            // stuff.Add("ps4");
            // stuff.Add("bed");
            // stuff.Add("mac");
            // stuff.Remove("tv");
            // for(var isx = 0; isx < stuff.Count;isx++)
            // {
            //     Console.WriteLine("i got " + stuff[isx]);
            // }
            // stuff.Add("pixel");
            // foreach(string manu in stuff)
            // {
            //     Console.WriteLine(manu);
            // }

        //     Dictionary<string,string> bryan = new Dictionary<string,string>();
        //     bryan.Add("life","wack");
        //    // Console.WriteLine("Bryan's life be " +bryan["life"]);
        //     bryan.Add("day","I'ts sunday ese!");
        //     //Console.WriteLine("Whats today?");
        //     //Console.WriteLine(bryan["day"]);

        //     foreach(var i in bryan)
        //     {
        //         Console.WriteLine(i.Key + " - " + i.Value);
        //     }

        int[] arr1 = {0,1,2,3,4,5,6,7,8,9};
        string[] arr2 = {"Tim", "Martin", "Niiki", "Sara"};
        bool[] arr3 = {true,false,true,false,true,false,true,false,true,true};

        List<string> icecream = new List<string>
        {"strawberry","vanilla","rocky road","chocolate","black cherry"};
        Console.WriteLine(icecream.Count);
        Console.WriteLine(icecream[3]);
        icecream.RemoveAt(3);
        Console.WriteLine(icecream.Count);

        Dictionary<string,string> kids = new Dictionary<string, string>
        {
            {"Tim",null},
            {"Martin",null},
            {"Nikki",null},
            {"Sara",null},
        };
        kids["Tim"] = "strawberry";
        kids["Martin"] = "vanilla";
        kids["Nikki"] = "rocky road";
        kids["Sara"] = "chocolate";

        foreach(var i in kids)
        {
            Console.WriteLine(i.Key + " - " + i.Value);
        }

        Console.WriteLine(kids["Tim"]);
        }
    }
}
