using DigitalOffice.Models.Broker.Models.File;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.File;

public interface IGetFilesPathsResponse
{
  List<FilePathData> FilesPathsData { get; }

  static object CreateObj(List<FilePathData> filesPathsData)
  {
    return new
    {
      FilesPathsData = filesPathsData
    };
  }
}
