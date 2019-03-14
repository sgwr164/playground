using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace player
{
    [TestFixture]
    public class SampleTest
    {
        [Test]
        public void SimpleTest()
        {
            Assert.AreEqual(1 * 2, 2);
        }
    }
}
