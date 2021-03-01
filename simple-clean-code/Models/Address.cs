namespace simple_clean_code.Models
{
    public record Address
    {
        public string AddressLine { get; set; }
        public string Number { get; set; }
        public string Floor { get; set; }
        public string Door { get; set; }
        public int ZipCode { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(AddressLine)) return false;
            if (AddressLine.Length > 200) return false;
            if (string.IsNullOrEmpty(Number)) return false;
            if (Number.Length > 10) return false;
            if (!string.IsNullOrEmpty(Floor) && Floor.Length > 10) return false;
            if (!string.IsNullOrEmpty(Door) && Door.Length > 10) return false;
            if (ZipCode.Equals(default)) return false;

            return true;
        }
    }
}