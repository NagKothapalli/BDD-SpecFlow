﻿using System;
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
            Debug.WriteLine("HelloWorld");
        }
        [TestMethod]
        public void LaunchApplication()
        {
            Debug.WriteLine("Launch Application ");
        }
    }
}
