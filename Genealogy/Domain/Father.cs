//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public partial class Father
    {
        public Father()
        {
            this.Person = new HashSet<Person>();
        }
    
        public int fatherId { get; set; }
        public bool fatherKnown { get; set; }
        public string fFirstName { get; set; }
        public string fLastName { get; set; }
        public string fGivenName { get; set; }
    
        public virtual ICollection<Person> Person { get; set; }
    }
}
