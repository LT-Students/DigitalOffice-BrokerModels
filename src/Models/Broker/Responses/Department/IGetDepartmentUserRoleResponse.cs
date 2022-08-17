using LT.DigitalOffice.Models.Broker.Enums;

namespace LT.DigitalOffice.Models.Broker.Responses.Department
{
    public interface IGetDepartmentUserRoleResponse
    {
        DepartmentUserRole? DepartmentUserRole { get; }

        static object CreateObj(DepartmentUserRole? departmentUserRole)
        {
            return new
            {
                DepartmentUserRole = departmentUserRole
            };
        }
    }
}
