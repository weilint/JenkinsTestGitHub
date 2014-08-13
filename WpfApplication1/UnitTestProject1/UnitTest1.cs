using System;
using System.Windows.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WpfApplication1.MainWindow appl = new WpfApplication1.MainWindow();
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject pobject = new PrivateObject(appl);
            Button btn = (Button)pobject.GetFieldOrProperty("btn1");
            Assert.IsNotNull(btn);
        }
    }
}
