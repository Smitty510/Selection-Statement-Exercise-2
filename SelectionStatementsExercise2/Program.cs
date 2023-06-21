namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                case "calculus":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                case "physics":
                case "biology":
                    Console.WriteLine("I love science!");
                    break;
                case "pe":
                case "phys ed":
                case "physical education":
                    Console.WriteLine("PE is the best!");
                    break;
                case "history":
                    Console.WriteLine("History is fun.");
                    break;
                case "english":
                    Console.WriteLine("English is boring.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;

                   






            }
                    


            
            
        }
    }
}