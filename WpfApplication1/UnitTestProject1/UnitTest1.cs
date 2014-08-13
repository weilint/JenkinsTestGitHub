using System;
using System.Windows.Controls;
using WpfApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow appl = new MainWindow();
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject pobject = new PrivateObject(appl);
            Button btn = (Button)pobject.GetFieldOrProperty("btn1");
            Assert.IsNotNull(btn);
        }
    }
}
