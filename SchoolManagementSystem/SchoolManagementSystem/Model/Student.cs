using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Admission { get; set; }           // admission_no
        public string FirstName { get; set; }           // first_name
        public string LastName { get; set; }            // last_name
        public string Gender { get; set; }              // gender
        public string Phone { get; set; }               // telephone_no
        public string Email { get; set; }               // email_id
        public string Address { get; set; }             // address
        public DateTime DateOfBirth { get; set; }       // date_of_birth
        public DateTime DateOfAdmission { get; set; }   // date_of_admission
        public int GradeId { get; set; }                // grade_id

        // Audit fields
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
    }
}

