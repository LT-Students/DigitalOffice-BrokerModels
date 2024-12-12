namespace DigitalOffice.Models.Broker.Contracts.Department.Events
{
  public interface IDepartmentUpdated
  {
    DepartmentInfo Department { get; }

    static object CreateObj(DepartmentInfo department)
    {
      return new
      {
        Department = department
      };
    }
  }
}