using System.Runtime.Intrinsics.Arm;
using CramFundation;

namespace SaveTheOcean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            string userJob;
            bool transfer;
            Random random = new Random();

            do
            {
                Console.WriteLine("Save the ocean!\r\nQuè vols fer?\r\n1. Jugar!\r\n2. Sortir");
                user = Console.ReadLine() ?? "";
            } while (user != "1" && user != "2");

            if (user == "1")
            {
                AAnimal animal = RescueFile.Specimen();
                do
                {
                    Console.WriteLine(
                        "Perfecte! Què vols ser?\r\n1. Tècnic (45 XP)\r\n2. Veterinari (80 XP)\r\n"
                    );
                    user = Console.ReadLine() ?? "";
                } while (user != "1" && user != "2");

                userJob = user == "1" ? "Tècnic" : "Veterinari";
                Console.WriteLine("Genial! I el teu nom?");

                Employee employee = new Employee(Console.ReadLine(), userJob);

                Console.WriteLine(
                    "Hola, {0}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:\r\n",
                    employee.Name
                );

                RescueFile rescueFile = new RescueFile(animal, employee);
                Console.WriteLine(rescueFile.ToString());
                Console.WriteLine("Aquí tens la seva fitxa, per a més informació:\r\n");
                Console.WriteLine(rescueFile.AAnimal.ToString());

                do
                {
                    Console.WriteLine(
                        "El {0} té un grau d’afectació (GA) del {1}%. Vols curar-la aquí (1) o traslladar-la al centre (2)?",
                        rescueFile.AAnimal.Name,
                        rescueFile.GA
                    );
                    user = Console.ReadLine() ?? "";
                } while (user != "1" && user != "2");

                transfer = user == "2";

                Console.WriteLine(rescueFile.RescueDetails(transfer));
                Console.WriteLine(employee.ToString());
                Console.WriteLine("Fins el proper rescat!\r\n");
                Console.WriteLine(animal.GetType());
                Console.WriteLine(typeof(AAnimal));
            }
        }
    }
}
