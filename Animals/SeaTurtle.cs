namespace CramFundation
{
    public class SeaTurtle : AAnimal
    {
        private const string NameC = "Aletas";
        private const string FamilyC = "Totuga marina";
        private const string SpeciesC = "Tortuga Careta";
        private const float WeightC = 2.3f;

        
        public SeaTurtle(string names, string family, string species, float weight) : base(names, family, species, weight)
        {
        }
        public SeaTurtle() : this(NameC, FamilyC, SpeciesC, WeightC)
        {
        }

        public override int Heal(int actualState, bool transfer)
        {
            int risc = transfer?5:5;
            return actualState - ((actualState - 2) * (2 * actualState + 3)) - risc;
        }

    }
}
