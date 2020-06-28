using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class StudentToClassRelation
    {
        public int StudentToClassRelationID { get; set; }
        public int StudentID { get; set; }
        public int AcademicClassID { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }
    }
}