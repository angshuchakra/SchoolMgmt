using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class StudentDetail
    {
        [Key]
        public int StudentID { get; set; }      
        public int StudentRollNumber { get; set; }        
        [MaxLength(20)]
        public string StudentClass{get; set;}
        [MaxLength(100)]
        public string StudentName { get; set; }        
        [Column(TypeName = "date")]
        public DateTime DateOfBirth {get; set;}
        [MaxLength(20)]
        public int StudentAge{get;set;}
        [MaxLength(100)]
        public string studentSex {get;set;}
        [MaxLength(500)]
        public string CurrentAddress {get; set;}
        [MaxLength(500)]
        public string PermanentAddress{get; set;}
        [MaxLength(15)]
        public int ContactNumber{get; set;}
        [MaxLength(50)]
        public string Nationality{get; set;}
        public int CreatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }
    }   
}