using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.PageObjectes
{
    [TestClass]
    public class Gmail
    {
        [TestMethod]
        public void Compose()
        {
            Console.WriteLine("Compose And Send Email");
        }
        [TestMethod]
        public void Reply()
        {
            Console.WriteLine("Reply And Send Email");
            
        }
        [TestMethod]
        public void Forward()
        {
            Console.WriteLine("Forward And Send Email");
        }
    }
}
