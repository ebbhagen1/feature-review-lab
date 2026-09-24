
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Collections.Generic;
namespace feature_review_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ResturantMenu myMenu = new ResturantMenu();

            myMenu.AddItem("Cesarsallad", 129.00m, "Starter");
            myMenu.AddItem("Oxfile med klyftpotatis", 349.00m, "Main course");
            myMenu.AddItem("Kladdkaka med grädde", 89.00m, "Dessert");

            myMenu.PrintMenu();
        }

        public class Menu //hanterar enskild rätt 
        {
            public string? Dish { get; set; }
            public decimal Price { get; set; }
            public string? Category { get; set; }

        }

        public class ResturantMenu
        {
            public List<Menu> Items { get; set; } = new List<Menu>(); //Auto-implementerad lista som lagrar alla alterntiv

            public void AddItem(string dish, decimal price, string category) //metod för att lägga till en rätt i menyn
            {

                Menu newItem = new Menu
                {
                    Dish = dish,
                    Price = price,
                    Category = category
                };

                Items.Add(newItem);
            }
            public void PrintMenu() //Metod 

            {
                Console.WriteLine("Välkommen till PastaWorld!, här är vår meny:");
                foreach (var item in Items)
                {
                    Console.WriteLine($" {item.Dish} | {item.Price} kr | {item.Category}");
                }
            }
        }
    }
}
                             
           

        
        //{
        //    string? name;

        //    while (true)
        //    {

        //        Console.WriteLine("Vad heter du??");
        //        name = Console.ReadLine()?.Trim(); //väljer att lägga in trim för att skriva ut namnet utan mellanslag. 


        //        if (string.IsNullOrWhiteSpace(name))

        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("Du måste skriva ett namn");

        //        }

        //        else

        //        {
        //            Console.WriteLine($"Välkommen, {name}!");
        //            break;
        //        }

        //    }
        //}
       



