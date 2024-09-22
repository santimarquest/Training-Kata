namespace ManhattanDistanceCalculator
{
    public class DistanceCalculator
    {
        public static int manhattanDistance(Point p1, Point p2)
        {

            var abs_x = Math.Abs(p1.GetX() - p2.GetX());
            var abs_y = Math.Abs(p1.GetY() - p2.GetY());

            return abs_x + abs_y;
        }
    }
}
