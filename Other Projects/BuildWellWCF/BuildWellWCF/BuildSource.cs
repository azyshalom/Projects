//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildWellWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuildSource
    {
        public int Id { get; set; }
        public int BuildId { get; set; }
        public string Url { get; set; }
        public string Revision { get; set; }
        public string RepositoryType { get; set; }
        public string ReferencedBy { get; set; }
    
        public virtual Build Build { get; set; }
    }
}