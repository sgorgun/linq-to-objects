namespace Linq.DataSources
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"{this.OrderId}: {this.OrderDate:d} for {this.Total:C2}";
        }
    }
}
