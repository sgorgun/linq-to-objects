namespace Linq.DataSources
{
    public class Customer
    {
        public string CustomerId { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public Order[] Orders { get; set; }

        public override string ToString()
        {
            return $"{this.CustomerId} {this.CompanyName}\n{this.Address}\n{this.City}, {this.Region} {this.PostalCode} {this.Country}\n{this.Phone}";
        }
    }
}
