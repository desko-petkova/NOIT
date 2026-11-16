namespace ASP_MVC.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        public double Floor { get; set; }
        public bool HasComputers { get; set; }

        public Room(int id, string number, int capacity, double floor, bool hasComputers)
        {
            Id = id;
            Number = number;
            Capacity = capacity;
            Floor = floor;
            HasComputers = hasComputers;
        }
    }
}
