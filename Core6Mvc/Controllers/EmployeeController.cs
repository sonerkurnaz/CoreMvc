using Core6Mvc.Models.DTO.Employees;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entities;

namespace Core6Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly NorthwindContext context;

        public EmployeeController(NorthwindContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            //
            List<EmployeeListDto> listDtos = new List<EmployeeListDto>();

            //database'den calısanları cekiyoruz
            var EmployeeList = context.Employees.ToList();

            //database den gelen verileri Employeelistdto ya teker teker atıyoruz
            foreach (var employee in EmployeeList)
            {
                EmployeeListDto listDto = new();
                listDto.Id = employee.EmployeeId;
                listDto.FirstName = employee.FirstName;
                listDto.LastName = employee.LastName;
                listDto.HireDate = employee.HireDate;
                listDto.Country = employee.Country;
                listDto.City = employee.City;
                listDto.HomePhone = employee.HomePhone;

                //Listeye ekliyoruz..
                listDtos.Add(listDto);

            }

            return View();
        }
    }
}
