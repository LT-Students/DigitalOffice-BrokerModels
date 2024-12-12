namespace DigitalOffice.Models.Broker.Contracts.Department.Events
{
  public interface IDepartmentCreated
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