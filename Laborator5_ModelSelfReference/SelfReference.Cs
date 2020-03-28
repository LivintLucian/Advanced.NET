namespace Laboratorul5
{
    using System;
    using System.Collections.Generic;
    
    public partial class SelfReference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SelfReference()
        {
            this.SelfReference1 = new HashSet<SelfReference>();
        }
    
        public int SelfReferenceId { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentSelfReferenceId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelfReference> SelfReference1 { get; set; }
        public virtual SelfReference SelfReference2 { get; set; }
    }
}