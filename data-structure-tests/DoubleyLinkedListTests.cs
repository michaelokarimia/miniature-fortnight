using NUnit.Framework;
using data_structures;

namespace data_structure_tests
{
    [TestFixture]
    public class DoubleyLinkedListsTests
    {
        [Test]
        public void TraverseReturnsNullIfListIsEmpty()
        {
            var subject = new DoubleyLinkedList();

            var result = subject.Traverse((n,m) =>  n == null );

            Assert.IsNull(result);
        }

        [Test]
        public void AppendsNodeToList()
        {
            var subject = new DoubleyLinkedList();

            subject.Append(10);

            Assert.That(subject.ToString(), Is.EqualTo("Index: 0, Value: 10\r\n")); 
        }


        [Test]
        public void CanRemoveAHeadNode()
        {
            var subject = new DoubleyLinkedList();

            var one = subject.Append(1);
            subject.Append(2);

            Assert.That(subject.ToString(), Is.EqualTo("Index: 0, Value: 1\r\nIndex: 1, Value: 2\r\n"));

            subject.Remove(one);

            Assert.That(subject.ToString(), Is.EqualTo("Index: 0, Value: 2\r\n"));

        }

        [Test]
        public void CanRemoveMiddleNode()
        {
            var subject = new DoubleyLinkedList();

            subject.Append(1);
            var two = subject.Append(2);
            subject.Append(3);

            Assert.That(subject.ToString(), Is.EqualTo("Index: 0, Value: 1\r\nIndex: 1, Value: 2\r\nIndex: 2, Value: 3\r\n"));

            subject.Remove(two);

            Assert.That(subject.ToString(), Is.EqualTo("Index: 0, Value: 1\r\nIndex: 1, Value: 3\r\n"));

        }

        [Test]
        public void InsertsAtMiddle()
        {
            var subject = new DoubleyLinkedList();

            subject.Append(1);
            var two = subject.Append(2);
            subject.Append(3);

            subject.InsertAt(two, 10);

            Assert.That(subject.ToString(), Is.EqualTo("Index: 0, Value: 1\r\nIndex: 1, Value: 2\r\nIndex: 2, Value: 10\r\nIndex: 3, Value: 3\r\n"));

        }


    }
}
