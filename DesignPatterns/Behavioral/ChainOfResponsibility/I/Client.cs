namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class Client
    {
        public static void Execute()
        {
            var handler4 = new DiscountHandler("Kierownik sklepu", 1000, 7000);
            var handler3 = new DiscountHandler("Kierownik sali", 500, 7000/*, handler4*/);
            var handler2 = new DiscountHandler("Kierownik kas", 500, 10000, handler3);
            var handler1 = new DiscountHandler("Kasjer", 100, 10000, handler2);


            handler1.Handle(500, 15000);

            handler1.Handle(700, 15000);

            handler3.Handle(100, 7000);



            var handler_24 = new DiscountHandler_2("Kierownik sklepu", 1000, 7000);
            var handler_23 = new DiscountHandler_2("Kierownik sali", 500, 7000, handler_24);
            var handler_22 = new DiscountHandler_2("Kierownik kas", 500, 10000, handler_23);
            var handler_21 = new DiscountHandler_2("Kasjer", 100, 10000, handler_22);

            var context = new DiscountHandlerContext(15000, 700);
            handler_21.Handle(context);
            Console.WriteLine(context.Result);
        }
    }
}
