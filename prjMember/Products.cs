//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjMember
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.OptionsToProducts = new HashSet<OptionsToProducts>();
            this.OrderDetail = new HashSet<OrderDetail>();
        }
    
        public int fid { get; set; }
        public int B_fid { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> Category_fid { get; set; }
        public string Memo { get; set; }
        public string Menu_fid { get; set; }
        public string IsForSale { get; set; }
    
        public virtual BusinessMember BusinessMember { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptionsToProducts> OptionsToProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
