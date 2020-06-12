using System;
using NUnit.Framework;

namespace Tests
{
    public class AssertionsDemo
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AreEqual()
        {
            Assert.AreEqual("expected", "actual");
        }
        [Test]
        public void AreEqualWithDescription()
        {
            Assert.AreEqual("expected", "actual", "test failed, give some context here...");
        }
        [Test]
        public void AreEqualArrays()
        {
            var expected = new int[] { 1, 2, 3, 4, 5 };
            var actual = new int[] { 1, 2, 3, 7, 8, 9 };
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AreObjectsEqual()
        {
            var obj1 = new object();
            var obj2 = new object();
            var areTheyEqual = obj1.Equals(obj2); // reference equaliy, FAILs
            // Assert.IsTrue(areTheyEqual);
            // Assert.AreEqual(obj1, obj2); // reference equality, FAILs

            Assert.AreSame(obj1, obj2); // reference equality, FAILs
            obj2 = obj1;
            Assert.AreEqual(obj1, obj2); // PASSes
        }
        [Test]
        public void ConstraintModelDemo()
        {
            Assert.That(1, Is.EqualTo(1));
            Assert.That("santosh", Is.Not.EqualTo("marigowda"));
        }
        [Test]
        public void ContainsOneInstanceOfThree()
        {
            var arrayOfValues = new int[] { 1, 3, 5, 6, 7 };
            Assert.That(arrayOfValues, Has.Exactly(1).EqualTo(3));
            Assert.That(arrayOfValues, Has.One.EqualTo(6));
        }
        [Test]
        public void IsMoreThan5AndLessThan50()
        {
            var num = 45;
            Assert.That(num, Is.GreaterThan(5).And.LessThan(100));
        }
        [Test]
        public void UsingWarning()
        {
            var isProcessed = false;
            Warn.Unless(isProcessed, Is.True.After(1).Minutes.PollEvery(10).Seconds);
            Console.WriteLine("Still going on...");
        }
        [Test]
        public void AssertPassThrowsException()
        {
            Assert.That(Assert.Pass, Throws.Exception);
            // Assert.That(Assert.Pass, Throws.TypeOf<Exception>()); // fails
            Assert.That(Assert.Pass, Throws.TypeOf<SuccessException>());
        }
        [Test]
        public void AssumeDemo()
        {
            Assume.That("some value", Is.EqualTo("some other value")); // does not fail but just warns
        }
        [Test]
        public void MultipleAssertions()
        {
            Assert.Multiple(() =>
            {
                Assert.That(1, Is.EqualTo(2));
                Assert.That(4, Is.EqualTo(5));
            });
        }
    }
}