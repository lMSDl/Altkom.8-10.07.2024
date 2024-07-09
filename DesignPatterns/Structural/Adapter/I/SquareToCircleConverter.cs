namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Adapter.I
{
    internal static class SquareToCircleConverter
    {
        public static Circle ToCircle(this Square square)
        {
            return new Circle() { R = square.A * Math.Sqrt(2) / 2 };
        }
    }
}
