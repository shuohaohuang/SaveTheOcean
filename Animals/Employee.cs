using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramFundation
{
    public class Employee
    {
        public string Name {  get; set; }
        public string Job {  get; set; }
        public int Exp {  get; set; }

        public Employee(string name, string job)
        {
            this.Name = Txt.Name(name);
            this.Job = job;
            this.Exp = this.Job== "Tècnic"?45:80;
        }
        /// <summary>
        /// modifica el valor Exp de la instancia, depenent del de Success, si es cert suma si no resta.
        /// </summary>
        /// <param name="success">si ha complert la missió</param>
        public void GainExp(bool success)
        {
            this.Exp += success ? 50 : -20;
        }

        /// <summary>
        /// Mètode retorna una taula amb els valors de la instanica
        /// </summary>
        /// <returns>Una taula en forma d'String</returns>
        public override string ToString()
        {
             string file=string.Format(
                  "+-------------------------------------------------------------+\r\n"
                    + "|                           Empleat                           |\r\n"
                    + "+-------------------------------------------------------------+\r\n"
                    + "|        Nom        |        Feina        |        Exp        |\r\n"
                    + "+-------------------------------------------------------------+\r\n"
                    + "|{0}|{1}|{2}|\r\n"
                    + "+-------------------------------------------------------------+\r\n",
                Txt.Format(this.Name, 19),
                Txt.Format(this.Job, 21),
                Txt.Format(this.Exp.ToString(), 19)
            );
            return file;
        }
    }
}
