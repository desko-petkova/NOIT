namespace ASP_MVC.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        public double Floor { get; set; }
        public bool HasComputers { get; set; }
    }
}
