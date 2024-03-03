namespace CramFundation
{
    public class SeaBird : AAnimal
    {
        private const string NameC = "PicoLargo";
        private const string FamilyC = "Au marina";
        private const string SpeciesC = "Gavina";
        private const float WeightC = 2.3f;

        public SeaBird(string names, string family, string species, float weight) : base(names, family, species, weight)
        {
        }
        public SeaBird() : this(NameC, FamilyC, SpeciesC, WeightC)
        {
        }

        public override int Heal(int actualState, bool transfer)
        {
            int risc = transfer ? 5 : 0;
            return (int)(actualState - Math.Pow(actualState,2)+risc);
        }
    }
}
