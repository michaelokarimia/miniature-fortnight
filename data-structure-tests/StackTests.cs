using data_structures;
using NUnit.Framework;

namespace data_structure_tests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void CanPushAndPeekItemOntoStack()
        {
            var stack = new Stack();

            stack.Push(1);

            Assert.That(stack.Peek(), Is.EqualTo(1));
        }

        [Test]
        public void PopReturnsItem()
        {
            var stack = new Stack();

            stack.Push(15);

            Assert.That(stack.Pop(), Is.EqualTo(15));
        }

        [Test]
        public void PopReturnsLastItem()
        {
            var stack = new Stack();

            stack.Push(15);
            stack.Push(100);

            Assert.That(stack.Pop(), Is.EqualTo(100));
            Assert.That(stack.Pop(), Is.EqualTo(15));

        }
    }
}
