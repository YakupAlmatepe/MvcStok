//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLKATEGORILER
    {
        public TBLKATEGORILER()
        {
            this.TBLURUNLER = new HashSet<TBLURUNLER>();
        }
    
        public short KATEGORYID { get; set; }
        public string KATEGORIAD { get; set; }
    
        public virtual ICollection<TBLURUNLER> TBLURUNLER { get; set; }
    }
}