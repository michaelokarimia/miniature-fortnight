using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_structures;

namespace data_structure_tests
{
    [TestFixture]
    public class HashTests
    {
        [Test]
        public void ReturnsZeroWhenNoDuplicates()
        {
            var days = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Assert.That(Hash.DuplicateDays(days), Is.EqualTo(0));

        }

        [Test]
        public void ReturnsFirstDuplicate()
        {
            var days = new int[] { 1, 1, 3, 4, 5, 6, 7 };

            Assert.That(Hash.DuplicateDays(days), Is.EqualTo(1));

        }
    }
}
