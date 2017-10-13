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

            var result = subject.Traverse();

            Assert.IsNull(result);
        }

        [Test]
        public void AppendsNodeToList()
        {
            var subject = new LinkedList();

            subject.Append(10);

            Assert.That(subject.Size, Is.EqualTo(1)); 
        }
    }
}
