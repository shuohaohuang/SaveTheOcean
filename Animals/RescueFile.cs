using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramFundation
{
    public class RescueFile
    {
        private static Random rnd = new Random();
        private static string[] locations = { "Cadaquès", "Gavà", "Badalona", "Montgat", "Masnou" };

        /// <summary>
        /// Retorna una instancia d'AAnimal 
        /// </summary>
        /// <returns>retorna uan instancia d'AAnimal de forma aleatoria</returns>
        public static AAnimal Specimen()
        {
            switch (rnd.Next(0, 3))
            {
                case 0:
                    Cetacea delfin = new Cetacea();
                    return delfin;
                case 1:
                    SeaBird gavina = new SeaBird();
                    return gavina;
                default:
                    SeaTurtle tortuga = new SeaTurtle();
                    return tortuga;
            }
        }

        public string RescueId { get; set; }
        public string RescueDate { get; set; }
        public AAnimal AAnimal { get; set; }
        public int GA { get; set; }
        public string Location { get; set; }
        public Employee Employee { get; set; }

        public RescueFile(AAnimal animal, Employee employee)
        {
            this.RescueId = String.Format(
                "RES{0}{1}{2}",
                rnd.Next(0, 10),
                rnd.Next(0, 10),
                rnd.Next(0, 10)
            );
            this.RescueDate = String.Format("{0}-{1}-{2}", rnd.Next(1, 29), rnd.Next(1, 13), 2023);
            this.AAnimal = animal;
            this.GA = rnd.Next(1, 100);
            this.Location = locations[rnd.Next(0, 5)];
            this.Employee = employee;
        }
        /// <summary>
        /// Mètode retorna una taula amb els valors de la instanica
        /// </summary>
        /// <returns>Una taula en forma d'String</returns>
        public override string ToString()
        {
            string file = String.Format(
                "+-------------------------------------------------------------+\r\n"
                    + "|                       RESCAT                                |\r\n"
                    + "+-------------------------------------------------------------+\r\n"
                    + "| # Rescat | Data rescat | Superfamília   | GA | Localització |\r\n"
                    + "+-------------------------------------------------------------+\r\n"
                    + "|{0}|{1}|{2}|{3}|{4}|\r\n"
                    + "+-------------------------------------------------------------+\r\n",
                Txt.Format(this.RescueId, 10),
                Txt.Format(this.RescueDate, 13),
                Txt.Format(this.AAnimal.Family, 16),
                Txt.Format(this.GA.ToString(), 4),
                Txt.Format(this.Location, 14)
            );
            return file;
        }
        /// <summary>
        /// Metode que retorna un missatge sobre el rescat
        /// </summary>
        /// <param name="tranfered"> Si s'ha tractat al animal al mateix lloc o no </param>
        /// <returns>Retorna una String amb el resultat del rescat</returns>
        public string RescueDetails(bool tranfered)
        {
            this.GA = this.AAnimal.Heal(this.GA, tranfered);
            bool success = this.GA < 5;
            this.Employee.GainExp(success);
            if (success)
            {
                return string.Format(
                    "El tractament aplicat ha reduït el GA fins al {0}%. L’exemplar està " +
                    "recuperat i pot tornar al seu hàbitat. La teva experiència ha " +
                    "augmentat en +50XP.\r\n",this.GA
                );
            }

            return string.Format("El tractament aplicat ha reduït el GA fins al {0}%. No ha " +
                "estat prou efectiu i cal traslladar l’exemplar al centre. La teva " +
                "experiència s’ha reduït en -20XP.",this.GA);
        }
    }
}
