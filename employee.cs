//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp50
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee
    {
        public int Id { get; set; }
        public string id_number { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public int employee_type_id { get; set; }
        public int postal_code_id { get; set; }
        public Nullable<int> deleted { get; set; }
    
        public virtual employee_type employee_type { get; set; }
        public virtual postal_code postal_code { get; set; }
    }
}
