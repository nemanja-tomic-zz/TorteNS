//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TorteNS.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class slike
    {
        public slike()
        {
            this.proizvods = new HashSet<proizvod>();
        }
    
        public int idSlike { get; set; }
        public string naziv { get; set; }
        public int velicina { get; set; }
        public string tip { get; set; }
        public string putanja { get; set; }
    
        public virtual ICollection<proizvod> proizvods { get; set; }
    }
}
