using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation c;
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        [TestInitialize]// thiet lap dl dung chung cho testacse
        public void SetUp()
        {
            c = new Caculation(10, 5);
        }
        [TestMethod]// 1 testcase 
        public void TestAddOpenrator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10,5);
            expected = 15;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]// 1 testcase 
        public void TestSubOpenrator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 5;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]// 1 testcase 
        public void TestMulOpenrator()
        {
            int expected = 15, actual;
            // Caculation c = new Caculation(10, 5);
            expected = 50;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]// 1 testcase 
        public void TestDivOpenrator()
        {
            int expected, actual;
            // Caculation c = new Caculation(10, 5);
            expected = 2;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]// 1 testcase 
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {

            c = new Caculation(10, 0);
            c.Exectute("/");
        }
        // testcase a=10 b =5 =15 
        // lien ket testdata voi project 
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv",DataAccessMethod.Sequential)]
      
        public void TestWithDataSource()
        {
            int a,b ,expected, actual;
            string operation; 
            a =int.Parse (TestContext.DataRow[0].ToString());
            b= int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();         
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new Caculation(a, b); 
            actual = c.Exectute(operation );
            Assert.AreEqual(expected,actual );


        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataPower.csv", "TestDataPower#csv", DataAccessMethod.Sequential)]
        public void TestPower ()
        {
            int n;
            double x, expected;
            double actual;
            n = int.Parse (TestContext.DataRow[1].ToString ());
            x = double.Parse(TestContext.DataRow[0].ToString());
            expected = double .Parse(TestContext.DataRow[2].ToString());
            actual = Caculation.Power(x, n);
            Assert.AreEqual(expected, actual);

        }
    }
}
