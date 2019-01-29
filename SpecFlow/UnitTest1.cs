using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace SpecFlow
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Hello  Java World");
        }
        [TestMethod]
        public void LaunchApplication()
        {
            Debug.WriteLine("Launch Application ");
        }

        [TestMethod]
        public void LoginTOApplication()
        {
            Debug.WriteLine("LoginTOApplication ");
        }
        [TestMethod]
        public void Compose()
        {
            Debug.WriteLine("Compose Mail ");
        }
    }
}
