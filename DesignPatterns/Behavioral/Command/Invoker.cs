namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Command
{
    internal class Invoker
    {
        private readonly ICommand _command;
        private readonly static Stack<ICommand> _commands = new Stack<ICommand>();

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            if(_command.Execute())
                _commands.Push(_command);
        }
        public static void Undo()
        {
            if (_commands.TryPop(out var command))
                command.Undo();
        }
    }
}
