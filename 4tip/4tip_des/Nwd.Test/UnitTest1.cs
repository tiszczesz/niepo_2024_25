namespace Nwd.Test
{
    public class UnitTest1
    {
        [Fact]
        public void B_Zero_OK() {
            var result = cw1_wpf.Models.Nwd.NwdRec(12, 0);
            Assert.Equal(12, result);
        }

        [Fact]
        public void A_Zero_OK()
        {
            var result = cw1_wpf.Models.Nwd.NwdRec(0, 12);
            Assert.Equal(12, result);
        }
    }
}