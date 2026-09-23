
namespace feature_review_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string? name;  // ? tecknet tillåter att vi kan lagra text som tom (null) (Variabeln namn)

            while (true)//Oändlig loop 
            {

                Console.WriteLine("Vad heter du??"); //Frågar användaren om namn
                name = Console.ReadLine(); //Väntar på svar från användaren

                
                if (string.IsNullOrWhiteSpace(name)) //kollar om användaren skrev tomt, mellanslag eller text

                {
                    Console.WriteLine();
                    Console.WriteLine("Du måste skriva ett namn"); //Om villkoret är sant körs If-loopen. 
                    
                }

                else   //Om villkoret är falskt (giltigt namn så hoppar den hit. 
                    
                {
                    Console.WriteLine($"Välkommen, {name}!"); //Skriver ut ett välkomstmeddalnde med namn
                    break; //Avslutar programmet. 

                }
                
            }
        }
    }
}





