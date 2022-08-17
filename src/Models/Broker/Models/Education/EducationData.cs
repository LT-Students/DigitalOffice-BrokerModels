using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Models.Education
{
    public class EducationData
    {
        public Guid Id { get; }
        public string UniversityName { get; }
        public string QualificationName { get; }
        public EducationFormData EducationForm { get; }
        public EducationTypeData EducationType { get; }
        public string Completeness { get; }
        public DateTime AdmissionAt { get; }
        public DateTime? IssueAt { get; }
        public List<Guid> ImagesIds { get; }

        public EducationData(
            Guid id,
            string universityName,
            string qualificationName,
            string completeness,
            EducationFormData educationForm,
            EducationTypeData educationType,
            DateTime admissionAt,
            DateTime? issueAt,
            List<Guid> imagesIds)
        {
            Id = id;
            UniversityName = universityName;
            QualificationName = qualificationName;
            EducationForm = educationForm;
            EducationType = educationType;
            Completeness = completeness;
            AdmissionAt = admissionAt;
            IssueAt = issueAt;
            ImagesIds = imagesIds;
        }
    }
}
