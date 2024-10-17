using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw1_wpf.Models;

namespace Nwd.Test
{
    public class FakemodeTest
    {
        [Fact]
        public void AddTest() {
            var counter = new FakeModel();
            counter.A = 1;
            counter.B = 2;
            Assert.Equal(3, counter.GetSum());
        }
    }
}
