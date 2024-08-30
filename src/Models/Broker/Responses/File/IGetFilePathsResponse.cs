using DigitalOffice.Models.Broker.Models.File;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.File;

public interface IGetFilePathsResponse
{
  List<FilePathData> FilePathsData { get; }

  static object CreateObj(List<FilePathData> filePathsData)
  {
    return new
    {
      FilePathsData = filePathsData
    };
  }
}
