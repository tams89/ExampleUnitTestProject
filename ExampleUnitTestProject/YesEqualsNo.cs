using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleUnitTestProject
{
    [TestClass]
    public class YesEqualsNo
    {
        [TestMethod]
        public void That_Yes_Does_Equal_No()
        {
            var yes = "Yes";
            var no = yes;

            Assert.AreEqual(yes, no);
        }
    }
}