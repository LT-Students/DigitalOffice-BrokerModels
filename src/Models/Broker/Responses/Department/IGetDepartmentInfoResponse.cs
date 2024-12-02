using DigitalOffice.Models.Broker.Models.Department;

namespace DigitalOffice.Models.Broker.Responses.Department
{
  public interface IGetDepartmentInfoResponse
  {
    DepartmentResponse DepartmentResponse { get; }

    public static object CreateObj(DepartmentResponse departmentResponse)
    {
      return new
      {
        DepartmentResponse = departmentResponse
      };
    }
  }
}