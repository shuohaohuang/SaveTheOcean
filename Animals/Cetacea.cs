namespace CramFundation
{
    public class Cetacea : AAnimal
    {
        private const string NameC = "Espiraculo";
        private const string FamilyC = "Cetaci";
        private const string SpeciesC = "delfí";
        private const float WeightC = 302f;

        public Cetacea(string names, string family, string species, float weight) : base(names, family, species, weight)
        {
        }
        public Cetacea() : this(NameC,FamilyC,SpeciesC,WeightC)
        {
        }

        public override int Heal(int actualState,bool transfer)
        {
            int risc = transfer?25:0;
            return (int)(actualState - Math.Log10(actualState)-risc);
        }
    }
}
