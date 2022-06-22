using System.ComponentModel.DataAnnotations;

namespace Core6Mvc.Models.DTO.Employees
{
    public class EmployeeCreateDto
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        [StringLength(50, ErrorMessage = "Ad alanı 50 karakterden büyük olamaz")]
        [MinLength(2, ErrorMessage = "Ad alanı 2 den az olamaz")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        [StringLength(50, ErrorMessage = "Soyad alanı 50 karakterden büyük olamaz")]
        [MinLength(2, ErrorMessage = "Soyad alanı 2 den az olamaz")]
        public string? LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public string? Title { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? HomePhone { get; set; }
    }
}
