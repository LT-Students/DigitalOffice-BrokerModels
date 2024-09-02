using System;

namespace DigitalOffice.Models.Broker.Models.File;

public class FilePathData
{
  public Guid Id { get; set; }
  public string Name { get; }
  public string Path { get; }
  public string Extension { get; }

  public FilePathData(
    Guid id,
    string name,
    string path,
    string extension)
  {
    Id = id;
    Name = name;
    Path = path;
    Extension = extension;
  }
}
