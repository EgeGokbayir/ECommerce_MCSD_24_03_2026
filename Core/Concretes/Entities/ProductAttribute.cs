namespace Core.Concretes.Entities
{
    public class ProductAttribute
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;

        // Foreign Key
        public int ProductId { get; set; }

        // Navigation Property
        public virtual Product? Product { get; set; }
    }
}