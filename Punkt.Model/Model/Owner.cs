namespace Punkt.Model
{
    public class Owner : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }

            set
            {
                var tmp = value.Split(' ');
                FirstName = tmp[0];
                if (tmp.Length > 1)
                    LastName = tmp[1];
            }
        }
    }
}
