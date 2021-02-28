namespace simple_clean_code.Models
{
    public record Address
    {
        public string AddressLine { get; set; }
        public string Number { get; set; }
        public string Floor { get; set; }
        public string Door { get; set; }
        public int ZipCode { get; set; }
    }
}