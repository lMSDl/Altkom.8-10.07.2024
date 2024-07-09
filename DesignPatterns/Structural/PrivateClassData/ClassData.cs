namespace Altkom._8_10._07._2024.DesignPatterns.Structural.PrivateClassData
{
    internal class ClassData
    {
        //private readonly string _someString;
        //private int SomeInt { get; }
        private PrivateClassData _data;

        public ClassData(string someString, int someInt)
        {
            //_someString = someString;
            //SomeInt = someInt;
            _data = new PrivateClassData(someString, someInt);
        }


        public void DoSth()
        {
            //_someString = "";
            //SomeInt = 0;

            _data.GetSomeString();
            _data.GetSomeInt();
        }
    }
}
