using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class ParentDtails
    {
        [Key]
        public int ParentID { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string  ParentAddress {get; set;}
        public int ParentContactNumer { get; set; }
        public string ParentOccupation { get; set; }
        public string AdharNumber { get; set; }
        public List<StudentDetail> Student {get; set;}
        public int CreatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }
    }
}