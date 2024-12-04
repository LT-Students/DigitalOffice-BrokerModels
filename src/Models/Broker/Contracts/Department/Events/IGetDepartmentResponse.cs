namespace DigitalOffice.Models.Broker.Contracts.Department.Events
{
  public interface IGetDepartmentResponse
  {
    DepartmentInfo DepartmentInfo { get; }

    public static object CreateObj(DepartmentInfo departmentInfo)
    {
      return new
      {
        DepartmentInfo = departmentInfo
      };
    }
  }
}