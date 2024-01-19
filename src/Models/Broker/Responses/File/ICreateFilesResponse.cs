using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.File
{
  public interface ICreateFilesResponse
  {
    List<Guid> FilesIds { get; set; }
    
    static object CreateObj(List<Guid> filesIds)
    {
      return new
      {
        FilesIds = filesIds,
      };
    }
  }
}
