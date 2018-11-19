namespace Punkt.Model
{
    public class Sale : BaseEntity
    {
        public string Note { get; set; }
        public decimal Price { get; set; }

        public int CreatedBy { get; set; }
        public int CarId { get; set; }

        public Car Car { get; set; }
        public Employee Employee { get; set; }
    }
}
