namespace Altkom._8_10._07._2024.DesignPatterns.Behavioral.Command
{
    internal class PlantCommand : GardenCommand
    {
        public PlantCommand(Garden receiver, string plantName) : base(receiver, plantName)
        {
        }

        public override bool Execute()
        {
            return Receiver.Add(PlantName);
        }

        public override void Undo()
        {
            Receiver.Remove(PlantName);
        }
    }
}
