//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fitness.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goal()
        {
            this.GoalProgesses = new HashSet<GoalProgess>();
        }
    
        public int Id { get; set; }
        public Nullable<double> WeightDesired { get; set; }
        public Nullable<int> StatusGoal { get; set; }
        public string UserId { get; set; }
        public Nullable<int> Category { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoalProgess> GoalProgesses { get; set; }
    }
}
