//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityProviders.SqlServerProvider
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrgAppRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrgAppRole()
        {
            this.OrgAppUserRoles = new HashSet<OrgAppUserRole>();
        }
    
        public int Id { get; set; }
        public int OrgAppId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string created_by { get; set; }
        public System.DateTime created_dt { get; set; }
        public string modified_by { get; set; }
        public System.DateTime modified_dt { get; set; }
    
        public virtual OrgApp OrgApp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgAppUserRole> OrgAppUserRoles { get; set; }
    }
}
