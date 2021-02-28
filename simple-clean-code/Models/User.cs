namespace simple_clean_code.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        // Another properties
        public Address PrimaryAddress { get; set; }
    }
}