using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test
{
    public class MyFirstNUnitTest
    {
        [Test]
        public void IAmDoningGreat()
        {
            Console.WriteLine("will see this in console");
            Assert.True(true);

        }
        [Test]
        public static void ThisIsAStaticTest()
        {
            Assert.True(true);
        }
        [Test]
        public async Task IAmAnAsyncTest()
        {
            Assert.True(true);
            await Task.CompletedTask;
        }
    }
}