
namespace EFCoreTry.Models
{
    public class Item : Product
    {
        public int Stocks { get; set; }
        public Supplier Supplier { get; set; }
    }
}

