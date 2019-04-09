using System;
using System.Collections.Generic;
namespace HungryNinja {
    class Program {

        public class Food {
            public string Name;
            public int Calories;
            public bool IsSpicy;
            public bool IsSweet;
            public Food (string name, int cal, bool sweet, bool spicy) {
                Name = name;
                Calories = cal;
                IsSpicy = spicy;
                IsSweet = sweet;
            }
        }

        public class Buffet {
            public List<Food> Menu;

            public Buffet () {
                Menu = new List<Food> {
                    new Food ("Gyro", 2000, false, true),
                    new Food ("Bella's Blueberrires", 1000, false, false),
                    new Food ("chips", 300, true, false),
                    new Food ("Nerds", 6544, false, false),
                    new Food ("Coffee", 766, false, false),
                };
            }
            public Food Serve () {
                Random rand = new Random ();
                return Menu[rand.Next (Menu.Count)];
            }
        }
        public class Ninja {
            private int calorieIntake;
            public List<Food> FoodHistory;
            public int calories {
                get {
                        return calorieIntake;
                }
            }
            public bool isFull
            {
                get
                {
                    bool full = false;
                    if(calorieIntake > 1200)
                    {
                        full = true;
                    }
                    return full;
                }
            }
            public Ninja () {
                calorieIntake = 0;
                FoodHistory = new List<Food> ();
            }
            public void Eat (Food food) {
                var item = (Food) food;
                calorieIntake += item.Calories;
                FoodHistory.Add (item);
                }
        }

        static void Main (string[] args) {
            Buffet ninjaBuffet = new Buffet ();
            Ninja kirill = new Ninja ();
            while (kirill.isFull == false) {
                kirill.Eat (ninjaBuffet.Serve ());
                Console.WriteLine ($"Calories: {kirill.calories}\nYour ninja is full.");
            
            }

        }
    }
}