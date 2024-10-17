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
        [Fact]
        public void A_B_OK()
        {
            var result = cw1_wpf.Models.Nwd.NwdRec(12, 8);
            Assert.Equal(4, result);
        }

        [Fact]
        public void B_Zero_OKIter()
        {
            var result = cw1_wpf.Models.Nwd.NwdIter(12, 0);
            Assert.Equal(12, result);
        }

        [Fact]
        public void A_Zero_OKIter()
        {
            var result = cw1_wpf.Models.Nwd.NwdIter(0, 12);
            Assert.Equal(12, result);
        }
        [Fact]
        public void A_B_OKIter()
        {
            var result = cw1_wpf.Models.Nwd.NwdIter(12, 8);
            Assert.Equal(4, result);
        }
    }
}