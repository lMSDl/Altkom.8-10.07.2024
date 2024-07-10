namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Command
{
    internal interface ICommand
    {
        bool Execute();
        void Undo();
    }
}
