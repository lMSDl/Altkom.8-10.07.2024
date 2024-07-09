namespace Altkom._8_10._07._2024.DesignPatterns.Creational.ObjectPool
{
    internal class Item
    {
        private bool isCollected;
        public bool IsVisible { get; set; }
        public bool IsCollected
        {
            get => isCollected;
            set
            {
                if (isCollected = value)
                    IsVisible = false;
            }
        }

        public byte[] Content { get; } = new byte[1024];
    }
}
