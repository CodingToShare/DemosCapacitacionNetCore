namespace TestProjectXUnit
{
    public class UnitTest1
    {
        [InlineData()]
        [Fact]
        public void Test1()
        {
            var Test = new UnitTest1();
            bool result = Test.IsPrime(2);

            Assert.True(result);

        }

        public bool IsPrime(int cadidate)
        {
            if(cadidate == 1) return true;

            throw new NotImplementedException("No es el numero 1");
        }
    }
}