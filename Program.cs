
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Collections.Generic;
namespace feature_review_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //string? name;

                while (true)
                {

                    Console.WriteLine("Vad heter du??");
                    string? name = Console.ReadLine()?.Trim(); //väljer att lägga in trim för att skriva ut namnet utan mellanslag. 


                    if (string.IsNullOrWhiteSpace(name)) 

                    {
                        Console.WriteLine();
                        Console.WriteLine("Du måste skriva ett namn");

                    }

                    else

                    {
                        Console.WriteLine($"Välkommen, {name}!");
                        break;
                    }

                }
            }

        }
    }
}








