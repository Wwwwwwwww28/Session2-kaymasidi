//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KaymasidiProg
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProdMaterials
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> MaterialID { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Materials Materials { get; set; }
    }
}
