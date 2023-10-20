namespace TPI_P3_grupal.Data.Entities
{
    public class Client : User
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public object Order { get; internal set; }

        //public ICollection<Product> ProductAttended { get; set; } = new List<Product>();
    }
}
