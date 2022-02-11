using Generics;
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
        [Test]
        public void First_Position_Double_TestCase()
        {
            MaxFloatNumber maxnum = new MaxFloatNumber();
            double result=maxnum.FindMaxNumber(5.5, 4.5, 2.5);
            Assert.AreEqual(5.5,result);
        }
        [Test]
        public void Second_Position_Double_TestCase()
        {
            MaxFloatNumber maxnum = new MaxFloatNumber();
            double result = maxnum.FindMaxNumber(2.3, 5.6, 2.8);
            Assert.AreEqual(5.6,result);
        }
        [Test]
        public void Third_Position_Double_TestCase()
        {
            MaxFloatNumber maxnum = new MaxFloatNumber();
            double result = maxnum.FindMaxNumber(4.2, 2.1, 8.5);
            Assert.AreEqual(8.5, result);
        }
       

    }
}