namespace Altkom._8_10._07._2024.SOLID.L
{
    //złamanie LSP
    public abstract class Shape
    {
        public abstract int Area { get; }
    }

    public class Rectangle : Shape
    {
        public virtual int A { get; set; }
        public virtual int B { get; set; }

        public override int Area => A * B;
    }
    public class Square : Rectangle
    {
        public override int A { set => base.A = base.B = value; }
        public override int B { set => base.B = base.A = value; }
    }
}
