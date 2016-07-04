using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject
{
    [TestClass]
    public class Class1
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext tc)
        {
            Console.WriteLine("This is Before Assembly");
        }

        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Console.WriteLine("This is After Assembly");
        }
    
}
}
