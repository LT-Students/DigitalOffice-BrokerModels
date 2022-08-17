using LT.DigitalOffice.Models.Broker.Models.Department;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Department
{
	public interface IFilterDepartmentsResponse
	{
        List<DepartmentFilteredData> Departments { get; }

        static object CreateObj(List<DepartmentFilteredData> departments)
        {
            return new
            {
                Departments = departments
            };
        }
    }
}
