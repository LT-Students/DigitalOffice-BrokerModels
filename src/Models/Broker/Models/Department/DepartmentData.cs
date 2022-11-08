using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Department
{
    public class DepartmentData
    {
        public Guid Id { get; }
        public string Name { get; }
        public string ShortName { get; }
        public List<DepartmentUserData> Users { get; }
        public List<Guid> ChildDepartmentsIds { get; }

        public DepartmentData(
            Guid id,
            string name,
            string shortName,
            List<DepartmentUserData> users = null,
            List<Guid> childDepartmentsIds = null)
        {
            Id = id;
            Name = name;
            ShortName = shortName;
            Users = users;
            ChildDepartmentsIds = childDepartmentsIds;
        }
    }
}
