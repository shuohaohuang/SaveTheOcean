using CramFundation;

namespace TestCramFundation
{
    [TestClass]
    public class UnitTest1
    {
        static Employee employee = new Employee(Console.ReadLine(), "Tècnic");
        static Cetacea animal=new ();
        static RescueFile rescueFile = new RescueFile(animal, employee);


        [TestMethod]
        public void RescueFile_Specimen_0_AAnimals()
        {
            //Arrange
            AAnimal animal = RescueFile.Specimen();

            //Act
            bool resutlA = animal.GetType() == typeof(Cetacea) ;
            bool resutlB = animal.GetType() == typeof(SeaBird) ;
            bool resutlC = animal.GetType() == typeof(SeaTurtle);


            //Assert
            Assert.IsTrue(resutlA||resutlB||resutlC);

        }
        [TestMethod]
        public void SeaTurtle_Heal()
        {
            //Arrange
             SeaTurtle seaTurtle = new SeaTurtle();
            //Act
            int result = seaTurtle.Heal(20, false);
            //Assert
            Assert.AreEqual(-759, result);
        }
        [TestMethod]
        public void SeaBird_Heal()
        {
            //Arrange
            SeaBird seaBird = new SeaBird();
            //Act
            int result = seaBird.Heal(20, false);
            //Assert
            Assert.AreEqual(-380, result);
        }
        [TestMethod]
        public void Cetacea_Heal()
        {
            //Arrange
            Cetacea cetacea = new Cetacea();
            //Act
            int result = cetacea.Heal(20, false);
            //Assert
            Assert.AreEqual(18, result);
        }
        [TestMethod]
        public void Employee_GainExp()
        {
            //Arrange
            Employee employee = new Employee("lala","po");
            //Act
            employee.GainExp(false);
            bool result = employee.Exp==80-20;
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Txt_Format()
        {
            //arrange
            string content = "eps";
            int lenght = 7;
            string expectedResult = "  eps  ";
            //act
            string result= Txt.Format(content, lenght);

            //assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Txt_Name()
        {
            //arrange
            string name = "eps";
            string expectedResult = "Eps";
            //act
            string result = Txt.Name(name);

            //assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}