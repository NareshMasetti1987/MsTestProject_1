using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject
{
    [TestClass]
    public class Class2
    {
        [TestMethod,TestCategory("SmokeTest")]
        public void TestCaseone()
        {
            Console.WriteLine("This is Class 2 Test Method");
        }
    }
}
