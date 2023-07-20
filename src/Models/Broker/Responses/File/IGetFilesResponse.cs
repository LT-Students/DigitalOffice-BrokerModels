using LT.DigitalOffice.Models.Broker.Models.File;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.File;

public interface IGetFilesResponse
{
  List<FileCharacteristicsData> FilesCharacteristicsData { get; }

  static object CreateObj(List<FileCharacteristicsData> filesCharacteristicsData)
  {
    return new
    {
      FilesCharacteristicsData = filesCharacteristicsData
    };
  }
}
