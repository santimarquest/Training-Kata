using FluentAssertions;
using ManhattanDistanceCalculator;

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
            var distance = DistanceCalculator.manhattanDistance(point, point);
            distance.Should().Be(0);
        }

        [Test]

        public void point_distance_should_return_four()
        {
            var point1 = new Point(5, 4);
            var point2 = new Point(3, 2);
            var distance = DistanceCalculator.manhattanDistance(point1, point2);
            distance.Should().Be(4);
        }

        [Test]

        public void point_distance_should_return_three()
        {
            var point1 = new Point(1, 1);
            var point2 = new Point(0, 3);
            var distance = DistanceCalculator.manhattanDistance(point1, point2);
            distance.Should().Be(3);
        }


    }
}