//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCode.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class chatmaster
    {
        public int cid { get; set; }
        public string sendername { get; set; }
        public string recivername { get; set; }
        public string message { get; set; }
        public Nullable<System.DateTime> mdate { get; set; }
        public Nullable<System.TimeSpan> mtime { get; set; }
    }
}
