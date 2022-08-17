using LT.DigitalOffice.Models.Broker.Enums;
using System;

namespace LT.DigitalOffice.Models.Broker.Models.Department
{
    public class DepartmentUserData
    {
        public Guid UserId { get; }
        public DepartmentUserRole Role { get; }

        public DepartmentUserData(Guid userId, DepartmentUserRole role)
        {
            UserId = userId;
            Role = role;
        }
    }
}
