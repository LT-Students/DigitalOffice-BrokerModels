using DigitalOffice.Models.Broker.Models.Image;

namespace LT.DigitalOffice.Models.Broker.Models.Image;

public class CreateImageData
{
  public string Name { get; }
  public string Content { get; }
  public string Extension { get; }
  public ResizeParameters ResizeParameters { get; }

  public CreateImageData(
      string name,
      string content,
      string extension,
      ResizeParameters resizeParameters)
  {
    Name = name;
    Content = content;
    Extension = extension;
    ResizeParameters = resizeParameters;
  }
}
