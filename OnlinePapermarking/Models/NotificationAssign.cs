//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlinePapermarking.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NotificationAssign
    {
        public long AssignID { get; set; }
        public long NotificationId { get; set; }
        public long LoginId { get; set; }
        public string ControllerName { get; set; }
        public string MethodName { get; set; }
        public bool IsExpired { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Notification Notification { get; set; }
    }
}