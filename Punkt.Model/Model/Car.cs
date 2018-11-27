namespace Punkt.Model
{
    public class Car : BaseEntity
    {
        public string NumberPlate { get; set; }
        public string Category { get; set; }

        public int OwnerId { get; set; }

        public Owner Owner { get; set; }
    }
}
