using System.Runtime.Intrinsics.Arm;
using CramFundation;

namespace SaveTheOcean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string StarterMenu = "Save the ocean!\r\nQuè vols fer?\r\n1. Jugar!\r\n2. Sortir";
            const string JobMenu =
                "Perfecte! Què vols ser?\r\n1. Tècnic (45 XP)\r\n2. Veterinari (80 XP)\r\n";
            const string NameNemu = "Genial! I el teu nom?";
            const string RescueMsg =
                "Hola, {0}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:\r\n";
            const string AnimalFileMsg = "Aquí tens la seva fitxa, per a més informació:\r\n";
            const string MoveAnimal =
                "El {0} té un grau d’afectació (GA) del {1}%. Vols curar-la aquí (1) o traslladar-la al centre (2)?";
            const string GoodByeMsg = "Fins el proper rescat!\r\n";
            string user = "";
            string userJob;
            bool transfer;
            Random random = new Random();

            do
            {
                Console.WriteLine(StarterMenu);
                user = Console.ReadLine() ?? "";
            } while (user != "1" && user != "2");

            if (user == "1")
            {
                AAnimal animal = RescueFile.Specimen();
                do
                {
                    Console.WriteLine(JobMenu);
                    user = Console.ReadLine() ?? "";
                } while (user != "1" && user != "2");
                userJob = user == "1" ? "Tècnic" : "Veterinari";

                Console.WriteLine(NameNemu);
                Employee employee = new Employee(Console.ReadLine()??" ", userJob);

                Console.WriteLine(RescueMsg, employee.Name);

                RescueFile rescueFile = new RescueFile(animal, employee);
                Console.WriteLine(rescueFile.ToString());

                Console.WriteLine(AnimalFileMsg);
                Console.WriteLine(rescueFile.AAnimal.ToString());

                do
                {
                    Console.WriteLine(MoveAnimal, rescueFile.AAnimal.Name, rescueFile.GA);
                    user = Console.ReadLine() ?? "";
                } while (user != "1" && user != "2");

                transfer = user == "2";
                Console.WriteLine(rescueFile.RescueDetails(transfer));

                Console.WriteLine(employee.ToString());

                Console.WriteLine(GoodByeMsg);
            }
            else
            {
                Console.WriteLine(GoodByeMsg);

            }
        }
    }
}
