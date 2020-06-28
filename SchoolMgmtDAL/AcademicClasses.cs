using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class AcademicClasses
    {
        [Key]
        public int AcademicClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassStream { get; set; }
        public string ClassSubjectCombination { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }
    }
}