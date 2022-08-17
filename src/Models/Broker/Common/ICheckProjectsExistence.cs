using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Common
{
    public interface ICheckProjectsExistence
    {
        List<Guid> ProjectsIds { get; }

        static object CreateObj(List<Guid> projectsIds)
        {
            return new
            {
                ProjectsIds = projectsIds
            };
        }
    }
}
