using NUnit.Framework;
using data_structures;

namespace data_structure_tests
{
    [TestFixture]
    public class BinaryTreeTests
    {
        [Test]
        public void ReturnsItsValue()
        {
            var subject = new BinaryTree(9);

            Assert.That(subject.Value, Is.EqualTo(9));
        }


        [Test]
        public void AddsToLeftNode()
        {
            BinaryTree btree = new BinaryTree(1);

            btree.AddLeft(2);

            Assert.That(btree.LeftTree.Value, Is.EqualTo(2));
        }

        [Test]
        public void AddsToRightNode()
        {
            BinaryTree btree = new BinaryTree(1);

            btree.AddRight(3);
            Assert.That(btree.RightTree.Value, Is.EqualTo(3));

        }
    }
}
