//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace feature_review_lab
//{
//    internal class Meny
//    {
//        ResturantMenu myMenu = new ResturantMenu();

//        myMenu.AddItem("Cesarsallad", 129.00m, "Starter");
//            myMenu.AddItem("Oxfile med klyftpotatis", 349.00m, "Main course");
//            myMenu.AddItem("Kladdkaka med grädde", 89.00m, "Dessert");

//            myMenu.PrintMenu();
//        }

//    public class Menu //hanterar enskild rätt 
//    {
//        public string? Dish { get; set; }
//        public decimal Price { get; set; }
//        public string? Category { get; set; }

//    }

//    public class ResturantMenu
//    {
//        public List<Menu> Items { get; set; } = new List<Menu>(); //Auto-implementerad lista som lagrar alla alterntiv

//        public void AddItem(string dish, decimal price, string category) //metod för att lägga till en rätt i menyn
//        {

//            Menu newItem = new Menu
//            {
//                Dish = dish,
//                Price = price,
//                Category = category
//            };

//            Items.Add(newItem);
//        }
//        public void PrintMenu() //Metod 

//        {
//            Console.WriteLine("Välkommen till PastaWorld!, här är vår meny:");
//            foreach (var item in Items)
//            {
//                Console.WriteLine($" {item.Dish} | {item.Price} kr | {item.Category}");
//            }
//        }




//    }
//}
