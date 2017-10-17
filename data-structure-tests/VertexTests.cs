using data_structures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_tests
{
    [TestFixture]
    public class VertexTests
    {
        private Vertex A;

        [SetUp]
        public void CreatesDAG()
        {
            A = new Vertex("A");
            var B = new Vertex("B");
            var C = new Vertex("C");
            var D = new Vertex("D");

            A.To(B, 4);
            B.To(C, 5);
            C.To(D, 10);
            D.To(A, 9);
         }

        [Test]
        public void CanTraverseGraph()
        {
            A.Traverse(A);
        }

      

    }
}
