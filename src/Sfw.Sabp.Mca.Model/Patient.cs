//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfw.Sabp.Mca.Model
{
    using Sfw.Sabp.Mca.Core.Contracts;
    using System;
    using System.Collections.Generic;
    
    
    
    public partial class Patient  : IQueryResult
    {
        public Patient()
        {
            this.Assessments = new HashSet<Assessment>();
        }
    
        public System.Guid PatientId { get; set; }
        public string ClinicalSystemId { get; set; }
        public Nullable<decimal> NhsNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
    
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual Gender Gender { get; set; }
    }
}