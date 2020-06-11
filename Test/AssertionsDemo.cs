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
        public void ConstraintModelDemo() {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}