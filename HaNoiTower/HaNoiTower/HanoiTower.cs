namespace HaNoiTowerGame
{
    public class HanoiTower : MyStack
    {
        public string Name { get; set; }

        public HanoiTower(string name)
        {
            this.Name = name;
        }

        public bool AddDisk(int size)
        {
            object topDisk = this.Peek();
            if (topDisk != null && (int)topDisk <= size)
            {
                return false;
            }

            this.Push(size);
            return true;
        }

        public int? RemoveDisk()
        {
            object data = this.Pop();
            if (data != null)
                return (int)data;
            else
                return null;
        }
    }

}
