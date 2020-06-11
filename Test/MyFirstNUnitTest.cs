using System;
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

    }
}