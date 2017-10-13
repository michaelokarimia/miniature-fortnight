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
    }
}
