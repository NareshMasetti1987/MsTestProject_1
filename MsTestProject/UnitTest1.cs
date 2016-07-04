using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject
{
    [TestClass] // this is use for test class
    public class UnitTest1
    {
        [ClassInitialize]
        public static void BeforeClass(TestContext tc)
        {
            Console.WriteLine("This is Before Class");
            
        }

        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("This is After Class");
        }

        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("This is Before Test");
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("This is After Test");
        }

        [TestMethod,TestCategory("SmokeTest")] // this is used to decl method as test method
        public void TestMethod1()
        {
            Console.WriteLine("This is Test Method one");
        }

        [Ignore]
        [TestMethod,TestCategory("SmokeTest")]
        public void TestMethod2()
        {
            Console.WriteLine("This is Test Method two");
        }


        [TestMethod,ExpectedException(typeof(NullReferenceException))]
        public void TestMethod3()
        {
            Console.WriteLine("This is Test Method three");
            String b = null;
            Console.WriteLine(b.Length);
        }
    }
}
