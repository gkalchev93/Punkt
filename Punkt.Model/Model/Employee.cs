namespace Punkt.Model
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Roles { get; set; }
    }
}
