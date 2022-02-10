using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class MaxNumberTest
    {
        [Test]
        public void First_Position_TestCase()
        {
            MaxNumber maxnum = new MaxNumber();
            int result=maxnum.FindMaxNumber(20, 15,5);
            Assert.AreEqual(20, result);

        }
        [Test]
        public void Second_Position_TestCase()
        {
            MaxNumber maxnum=new MaxNumber();
            int result = maxnum.FindMaxNumber(25, 30, 15);
            Assert.AreEqual(30,result);

        }
        [Test]
        public void Third_Position_TestCase()
        {
            MaxNumber maxnum=new MaxNumber();
            int result = maxnum.FindMaxNumber(20,40,90);
            Assert.AreEqual(90,result);
        }
    }
}