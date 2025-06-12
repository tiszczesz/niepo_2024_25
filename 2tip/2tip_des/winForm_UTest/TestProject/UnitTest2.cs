using WinFormsApp.Models;
namespace TestProject
{
    public class UnitTest2
    {
        [Fact]
        public void czy_odwraca()
        {
            string input = "test";
            string actual = StringOp.ReverseAndUpper(input);
            string expected = "TSET";
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void czy_dlugos_OK()
        {
            string input = "test";
            int actual = StringOp.ReverseAndUpper(input).Length;
            int expected = 4;
            Assert.Equal(expected, actual);
        }

    }
}