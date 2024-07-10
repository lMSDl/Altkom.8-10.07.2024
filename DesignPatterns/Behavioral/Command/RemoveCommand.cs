namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Command
{
    internal class RemoveCommand : GardenCommand
    {
        public RemoveCommand(Garden receiver, string plantName) : base(receiver, plantName)
        {
        }

        public override bool Execute()
        {
            return Receiver.Remove(PlantName);
        }

        public override void Undo()
        {
            Receiver.Add(PlantName);
        }
    }
}
