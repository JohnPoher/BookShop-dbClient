//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShop_WinForms
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int Id { get; set; }
        public Nullable<int> BookId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> BuyerId { get; set; }
        public Nullable<int> Cost { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Buyers Buyers { get; set; }
    }
}
