namespace ShopingCart.Core.Entities
{
    public class Audit
    {
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set;}
        public Guid LastUpdatedBy { get; set; }
        public Guid CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
