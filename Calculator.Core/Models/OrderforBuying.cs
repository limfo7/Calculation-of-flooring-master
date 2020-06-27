namespace Calculator.Core.Models
{
    public class OrderforBuying
    {
        public int Id { get; set; }
        public string OderNumber { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
