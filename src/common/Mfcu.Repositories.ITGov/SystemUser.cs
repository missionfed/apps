//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mfcu.Repositories.ITGov
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemUser
    {
        public SystemUser()
        {
            this.Assignments = new HashSet<Assignment>();
            this.Practices = new HashSet<Practice>();
            this.Trackings = new HashSet<Tracking>();
        }
    
        public int SystemUserID { get; set; }
        public string DomainLogin { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public int DepartmentID { get; set; }
        public bool boolIsCobitOwner { get; set; }
        public bool boolIsIncidentOwner { get; set; }
        public bool boolIsActive { get; set; }
        public string created_by { get; set; }
        public System.DateTime created_dt { get; set; }
        public string modified_by { get; set; }
        public System.DateTime modified_dt { get; set; }
    
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Practice> Practices { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Tracking> Trackings { get; set; }
    }
}