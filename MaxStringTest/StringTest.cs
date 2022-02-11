using Generics;
using NUnit.Framework;

namespace MaxStringTest
{
    public class StringTest
    {
        [Test]
        public void First_Position_String_TestCase()
        {
            MaxString maxString = new MaxString();
            string result = maxString.FindMaxString("Banana", "Peach", "Apple");
            Assert.AreEqual("Banana", result);
        }
        [Test]
        public void Second_Position_String_TestCase()
        {
            MaxString maxString = new MaxString();
            string result = maxString.FindMaxString("Peach", "Banana", "Apple");
            Assert.AreEqual("Banana", result);
        }
        [Test]
        public void Third_Position_String_TestCase()
        {
            MaxString maxString = new MaxString();
            string result = maxString.FindMaxString("Peach", "Apple", "Banana");
            Assert.AreEqual("Banana", result);
        }
    }
}
        