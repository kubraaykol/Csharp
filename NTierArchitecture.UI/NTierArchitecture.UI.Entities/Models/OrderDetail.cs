using NTierArchitecture.UI.Entities.Abstractions;

namespace NTierArchitecture.UI.Entities.Models
{
    public class OrderDetail : Entity
    {
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Product? Product { get; set; }   
        public Guid ProductID { get; set; }

        public Order? Order { get; set; }
        public Guid OrderID { get; set; }


    }
}
