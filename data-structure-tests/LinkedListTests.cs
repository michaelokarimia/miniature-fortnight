using System;
using NUnit.Framework;
using data_structures;

namespace data_structure_tests
{
    [TestFixture]
    public class LinkedListsTests
    {
        [Test]
        public void TraverseReturnsNullIfListIsEmpty()
        {
            var subject = new LinkedList();

            var result = subject.Traverse(null);

            Assert.IsNull(result);
        }

        [Test]
        public void AppendsNodeToList()
        {
            var subject = new LinkedList();

            subject.Append(10);

            Assert.That(subject.Size, Is.EqualTo(1)); 
        }


        [Test]
        public void CanRemoveAHeadNode()
        {
            var subject = new LinkedList();

            subject.Append(1);
            subject.Append(2);

            Assert.That(subject.Size, Is.EqualTo(2));

            subject.Remove(1);

            Assert.That(subject.Size, Is.EqualTo(1));

        }

        [Test]
        public void CanRemoveMiddleNode()
        {
            var subject = new LinkedList();

            subject.Append(1);
            subject.Append(2);
            subject.Append(3);

            Assert.That(subject.Size, Is.EqualTo(3));

            subject.Remove(2);

            Assert.That(subject.Size, Is.EqualTo(2));

        }
    }
}
