namespace Core6Mvc.Models.DTO.Products
{
    public class ProductCreateDto
    {

        public string? ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
    }
}