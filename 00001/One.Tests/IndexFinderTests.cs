using FluentAssertions;

namespace One.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] input = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int index1 = 0;
            int index2 = 1;

            int[] indices = IndexFinder.FindIndices(input, target);

            indices[0].Should().Be(index1);
            indices[1].Should().Be(index2);
        }

        [Test]
        public void Test2()
        {
            int[] input = new int[] { 3, 2, 4 };
            int target = 6;
            int index1 = 1;
            int index2 = 2;

            int[] indices = IndexFinder.FindIndices(input, target);

            indices[0].Should().Be(index1);
            indices[1].Should().Be(index2);
        }

        [Test]
        public void Test3()
        {
            int[] input = new int[] { 3, 3 };
            int target = 6;
            int index1 = 0;
            int index2 = 1;

            int[] indices = IndexFinder.FindIndices(input, target);

            indices[0].Should().Be(index1);
            indices[1].Should().Be(index2);
        }
    }
}