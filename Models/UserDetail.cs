//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserDetail
    {
        public UserDetail()
        {
            this.BlogTables = new HashSet<BlogTable>();
        }
    
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<BlogTable> BlogTables { get; set; }
    }
}
