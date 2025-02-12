using NTierArchitecture.UI.Entities.Abstractions;

namespace NTierArchitecture.UI.Entities.Models
{
    public class Supplier : Entity
    {
        public string? CompanyName { get; set; }
        public string? ContactTitl { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
