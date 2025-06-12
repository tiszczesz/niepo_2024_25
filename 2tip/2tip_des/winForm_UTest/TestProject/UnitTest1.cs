using WinFormsApp.Models;
namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void jesli_b_zero_to_a_rek()
        {
            int actual = Nwd.NwdRec(10, 0);
            int expected = 10;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void jesli_b_ujemne_zero_to_a_rek()
        {
            int actual = Nwd.NwdRec(-10, 0);
            int expected = 10;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void jesli_a__zero_to_b_Rek()
        {
            int actual = Nwd.NwdRec(0, 22);
            int expected = 22;
            Assert.Equal(expected, actual);
        }
        public void jesli_b_zero_to_a_iter()
        {
            int actual = Nwd.NwdIter(10, 0);
            int expected = 10;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void jesli_b_ujemne_zero_to_a_iter()
        {
            int actual = Nwd.NwdIter(-10, 0);
            int expected = 10;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void jesli_a__zero_to_b_iter()
        {
            int actual = Nwd.NwdIter(0, 22);
            int expected = 22;
            Assert.Equal(expected, actual);
        }
    }
}
