using NUnit.Framework;
using data_structures;

namespace data_structure_tests
{
    [TestFixture]
    public class QueueTests
    {
        [Test]
        public void EnqueueAddsItem()
        {
            var queue = new Queue();

            queue.Enqueue(1);

            Assert.That(queue.Peek(), Is.EqualTo(1));
        }

        [Test]
        public void DequeueRemovesItem()
        {

            var q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Assert.That(q.Dequeue(), Is.EqualTo(1));
            Assert.That(q.Dequeue(), Is.EqualTo(2));
        }
    }
}
