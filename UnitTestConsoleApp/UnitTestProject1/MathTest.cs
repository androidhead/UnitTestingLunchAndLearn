using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;

namespace Utility.Test
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void AddTwoNumbers_Basic_Success()
        {
            Assert.AreEqual(4, new Math().AddTwoNumbers(3, 1));
        }
    }
}
