
namespace feature_review_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string? name;  

            while (true)
            {

                Console.WriteLine("Vad heter du??"); 
                name = Console.ReadLine()?.Trim(); //väljer att lägga in trim för att skriva ut namnet utan mellanslag. 

                
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

/* Observation - Namnet skrevs ut mellanslag namn mellanslag
 Konsekvens/risk - Det vara väldigt många kommentarer som gör att det blir svårt att följa koden. Blanda ihop raderna.
Förslag - Förslag är att använda Console.ReadLine()?.Trim(); för att samla namnet "Anan" */




