//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KompStul.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orders()
        {
            this.sostav = new HashSet<sostav>();
        }
    
        public int id { get; set; }
        public int id_users { get; set; }
        public int id_status { get; set; }
        public int id_point { get; set; }
        public System.DateTime order_date { get; set; }
        public int code { get; set; }
        public int cost { get; set; }
        public Nullable<int> discount { get; set; }
        public Nullable<int> total_cost { get; set; }
        public Nullable<int> delivery_days { get; set; }
    
        public virtual point point { get; set; }
        public virtual status status { get; set; }
        public virtual users users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sostav> sostav { get; set; }

        public bool TextColor
        {
            get
            {
                if (Convert.ToDouble(discount) != 0) return true;
                else return false;
            }
        }
        public string Arrow
        {
            get
            {
                if (TextColor) return "Strikethrough";
                else return "None";
            }

        }
        public string newcost
        {
            get
            {
                if (TextColor) return Convert.ToString((Convert.ToDouble(cost)) - Convert.ToDouble(cost) * Convert.ToDouble(discount) / 100);
                else return "";
            }

        }
    }
}
