//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPLR4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Burger
    {
        public int BurgerPlace { get; set; }
        public int id_Customer { get; set; }
        public int id_Orders { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
