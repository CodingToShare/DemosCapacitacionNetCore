namespace TestProjectNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(1)]
        [TestCase(-2)]
        [TestCase(-51)]
        public void Test1(int value)
        {
            var Test = new Tests();
            bool result = Test.IsPrime(value);
            Assert.Pass();
        }

        public bool IsPrime(int cadidate)
        {
            if (cadidate == 1) return true;

            throw new NotImplementedException("No es el numero 1");
        }
    }
}