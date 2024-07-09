namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            var circle = new Circle() { R = 5 };
            CheckR(circle);

            var square = new Square() { A = 7 };

            CheckR(new SquareToCircleAdapter(square));
        }

        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }
    }
}
