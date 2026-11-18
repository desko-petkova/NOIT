namespace ASP_MVC.Models
{
    public class Room
    {
        private int capacity;
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value <= 13 || value >= 100)
                    throw new ArgumentException("Капацитетът трябва да е между 13 и 100");

                capacity = value;
            }
        }
        public double Floor { get; set; }
        public bool HasComputers { get; set; }

        public Room(int id, string number, int capacity, double floor, bool hasComputers)
        {
            if (id <= 0)
                throw new ArgumentException("ID трябва да е положително цяло число");

            Id = id;
            Number = number;
            Capacity = capacity;
            Floor = floor;
            HasComputers = hasComputers;
        }
    }
}
