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

        [Test]
        public void BuildsAThreeNodeTree()
        {
            var btree = new BinaryTree(5);

            btree.AddLeft(4);
            btree.AddRight(10);

            Assert.That(btree.Value, Is.EqualTo(5));
            Assert.That(btree.LeftTree.Value, Is.EqualTo(4));
            Assert.That(btree.RightTree.Value, Is.EqualTo(10));

        }


        [Test]
        public void BuildsABalancedTree()
        {
            var root = new BinaryTree(5);

            var l1 = root.AddLeft(3);
            l1.AddLeft(2);

            l1.AddRight(4);

            var r1 = root.AddRight(7);
            
            r1.AddLeft(6);

            r1.AddRight(8);


            Assert.That(root.Value, Is.EqualTo(5));

            Assert.That(root.LeftTree.Value, Is.EqualTo(3));
            Assert.That(root.LeftTree.LeftTree.Value, Is.EqualTo(2));
            Assert.That(root.LeftTree.RightTree.Value, Is.EqualTo(4));



            Assert.That(root.RightTree.Value, Is.EqualTo(7));
            Assert.That(root.RightTree.LeftTree.Value, Is.EqualTo(6));
            Assert.That(root.RightTree.RightTree.Value, Is.EqualTo(8));


        }
    }
}
