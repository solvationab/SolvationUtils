using FluentAssertions;
using SolvationExtensions;

namespace SolvationExtensionsTests
{
    [TestClass]
    public class EnumerableExtensionsTests
    {
        [TestMethod]
        public void BatchTest()
        {
            var list = Enumerable.Range(0, 100);

            var batches = list.Batch(10).Select(b => b.ToArray()).ToArray();

            batches.Should().NotBeNull();
            batches.Should().HaveCount(10);
        }

        [TestMethod]
        public void BatchArrayTest()
        {
            var list = Enumerable.Range(0, 100);

            var batches = list.BatchArray(10).ToArray();

            batches.Should().NotBeNull();
            batches.Should().HaveCount(10);
        }
    }
}