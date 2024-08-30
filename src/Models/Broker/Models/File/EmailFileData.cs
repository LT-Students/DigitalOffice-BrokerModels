namespace DigitalOffice.Models.Broker.Models.File;

public class EmailFileData
{
  public string Name { get; }
  public string Path { get; }
  public string Extension { get; }

  public EmailFileData(
    string name,
    string path,
    string extension)
  {
    Name = name;
    Path = path;
    Extension = extension;
  }
}
