//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentID { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string CommentContent { get; set; }
        public Nullable<int> OrderID { get; set; }
    
        public virtual OrderItem OrderItem { get; set; }
    }
}
