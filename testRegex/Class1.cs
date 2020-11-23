using Xunit;

namespace FisrtUnitTests {
    public class Class1 {
        [Fact]
        public void PassingTest () {
            //Given

            //When

            //Then
            Assert.Equal (4, Add (2, 2));
        }

        [Fact]
        public void FailingTest () {
            //Given

            //When

            //Then
            Assert.Equal (5, Add (2, 2));
        }

        int Add (int x, int y) {
            return x + y;
        }
    }
}