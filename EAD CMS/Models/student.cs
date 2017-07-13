//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EAD_CMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class student
    {
        public student()
        {
            this.assignments = new HashSet<assignment>();
            this.finals = new HashSet<final>();
            this.mids = new HashSet<mid>();
            this.quizs = new HashSet<quiz>();
        }

        [DisplayName("Roll Number")]
        [Required]
        [Remote("isExist", "Admin", HttpMethod = "Get", ErrorMessage = "Such roll number already exists!")]
        public string rollno { get; set; }
        [Required]
        [DisplayName("Student's Name")]
        public string name { get; set; }

        [DisplayName("Degree")]
        [Required]
        public string degree { get; set; }

        [Required]
        [DisplayName("Batch")]
        public string batch { get; set; }


        [DisplayName("Batch")]
        public virtual batch batch1 { get; set; }

        [DisplayName("Degree")]
        public virtual degree degree1 { get; set; }

        public virtual ICollection<assignment> assignments { get; set; }
        public virtual ICollection<final> finals { get; set; }
        public virtual ICollection<mid> mids { get; set; }
        public virtual ICollection<quiz> quizs { get; set; }
        public virtual ICollection<attendence> attendences { get; set; }
        public IEnumerable<System.Web.Mvc.SelectListItem> batchList { get; set; }
        public IEnumerable<System.Web.Mvc.SelectListItem> degreeList { get; set; }
    }
}