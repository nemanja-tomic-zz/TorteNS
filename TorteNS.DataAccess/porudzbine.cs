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
    
    public partial class porudzbine
    {
        public int idPorudzbine { get; set; }
        public string napomena { get; set; }
        public System.DateTime datumPorucivanja { get; set; }
        public System.DateTime datumTransakcije { get; set; }
        public int idKlijenta { get; set; }
        public int idProizvoda { get; set; }
    }
}