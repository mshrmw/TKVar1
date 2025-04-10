using Microsoft.VisualStudio.TestTools.UnitTesting;
using TKVar1;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SucsessTestMethod1()
        {
            var win = new MainWindow();
            Assert.IsTrue(win.Calculate("9", "3", "0", "7"));
            Assert.IsTrue(win.Calculate("10", "50", "30", "10"));
        }
    }
}
