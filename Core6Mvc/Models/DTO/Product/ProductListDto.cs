namespace Core6Mvc.Models.DTO.Employees
{
    public class ProductListDto
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
    }
}