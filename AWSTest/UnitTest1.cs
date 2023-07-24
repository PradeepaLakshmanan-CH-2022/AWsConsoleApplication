using AWSCOnsole;

namespace AWSTest
{
    [TestClass]
    public class UnitTest1
    {
        Hello hello=new Hello();    
        [TestMethod]
        public void TestMethod1()
        {
       
            var expected = "Hello Kavinya,Code Pipeline created and deployed successfully";
            var actual = hello.GetName();
            
            Assert.AreEqual(expected, actual);  
        }
    }
}