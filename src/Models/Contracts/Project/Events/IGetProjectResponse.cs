namespace DigitalOffice.Models.Contracts.Project.Events
{
  public interface IGetProjectResponse
  {
    ProjectInfo ProjectInfo { get; }

    public static object CreateObj(ProjectInfo projectInfo)
    {
      return new
      {
        ProjectInfo = projectInfo
      };
    }
  }
}