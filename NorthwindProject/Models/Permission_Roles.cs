//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permission_Roles
    {
        public Permission_Roles()
        {
            this.Permission_RoleMenuMapping = new HashSet<Permission_RoleMenuMapping>();
            this.Permission_RoleUserMapping = new HashSet<Permission_RoleUserMapping>();
        }
    
        public int RoleID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    
        public virtual ICollection<Permission_RoleMenuMapping> Permission_RoleMenuMapping { get; set; }
        public virtual ICollection<Permission_RoleUserMapping> Permission_RoleUserMapping { get; set; }
    }
}
