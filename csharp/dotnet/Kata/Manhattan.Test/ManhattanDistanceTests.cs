using FluentAssertions;
using System.Drawing;

namespace Manhattan.Test
{
    public class ManhattanDistanceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void same_point_distance_should_return_zero()
        {
            var point = new Point(1, 1);
            var distance = manhattanDistance(point, point);
            distance.Should().Be(0);
        }

        private object manhattanDistance(object point, object o)
        {
            throw new NotImplementedException();
        }
    }
}