//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication7
{
    using System;
    using System.Collections.Generic;
    
    public partial class voter
    {
        public voter()
        {
            this.results = new HashSet<result>();
        }
    
        public int Id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string middleName { get; set; }
        public string sex { get; set; }
        public string phoneNo { get; set; }
        public string department { get; set; }
        public string regNo { get; set; }
        public string password { get; set; }
        public byte[] image { get; set; }
        public string fingerPrint { get; set; }
    
        public virtual ICollection<result> results { get; set; }
    }
}