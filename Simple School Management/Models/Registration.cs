//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simple_School_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string nic { get; set; }
        public Nullable<int> courseId { get; set; }
        public Nullable<int> batchId { get; set; }
        public string mobile { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual Course Course { get; set; }
    }
}
