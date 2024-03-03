namespace CramFundation
{
    public abstract class AAnimal: IHealAble
    {
        public string Name { get; set; }
        public string Family {  get; set; }
        public string Species {  get; set; }
        public float Weight {  get; set; }

        public AAnimal(string names, string family, string species, float weight)
        {
            this.Name = names;
            this.Family = family;
            this.Species = species;
            this.Weight = weight;
        }

        /// <summary>
        /// Mètode retorna una taula amb els valors de la instanica
        /// </summary>
        /// <returns>Una taula en forma d'String</returns>
        public override string ToString()
        {
            string file =
                String.Format(
                    "+-------------------------------------------------------------+\r\n" +
                    "|                       FITXA                                 |\r\n" +
                    "+-------------------------------------------------------------+\r\n" +
                    "| # Nom | Superfamília | Espècie        | Pes aproximat       |\r\n" +
                    "+-------------------------------------------------------------+\r\n" +
                    "|{0}|{1}|{2}|{3}|\r\n" +
                    "+-------------------------------------------------------------+\r\n",
                Txt.Format(this.Name, 7), Txt.Format(this.Family, 14),
                Txt.Format(this.Family, 16), Txt.Format(this.Weight.ToString()+"kg", 21));
            return file;
        }

        public abstract int Heal(int actualState, bool transfer);
    }                                 
}
