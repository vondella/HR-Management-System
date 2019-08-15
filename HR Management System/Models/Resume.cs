using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class Resume
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public byte[] ProfileImage { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string PresentAddress { get; set; }

        public string PermanentAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string MarritualStatus { get; set; }

        public string NationalID { get; set; }

        public string Religion { get; set; }

        public string Nationality { get; set; }

        public string Email { get; set; }

        public List<DegreeDetails> EducationalDetails { get; set; }

        public List<ProfessionalExperience> Experiences { get; set; }
    }


    public class DegreeDetails
    {
        public long Id { get; set; }

        public string Qualification { get; set; }

        public string Subject { get; set; }

        public string Institute { get; set; }

        public string PassingYear { get; set; }

        public string Grade { get; set; }
    }


    public class ProfessionalExperience
    {
        public long Id { get; set; }

        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }

        public string Role { get; set; }

        public DateTime? DurationFrom { get; set; }

        public DateTime? DurationTo { get; set; }

    }
    
}
