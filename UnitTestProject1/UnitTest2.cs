using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TKVar1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void FailtureTestMethod1()
        {
            var win = new MainWindow();
            Assert.IsFalse(win.Calculate("", "", "", ""));
            Assert.IsFalse(win.Calculate(" ", " ", " ", " "));
            Assert.IsFalse(win.Calculate("а", "ы", "b", "K"));
            Assert.IsFalse(win.Calculate("-3", "-4", "-10", "-2"));
            Assert.IsFalse(win.Calculate("20", "51", "12", "100"));

        }
    }
}
