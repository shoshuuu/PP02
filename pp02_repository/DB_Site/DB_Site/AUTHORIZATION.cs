//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Site
{
    using System;
    using System.Collections.Generic;
    
    public partial class AUTHORIZATION
    {
        public string LOGIN { get; set; }
        public string PASSWORD { get; set; }
        public int SALT_ID { get; set; }
    
        public virtual SALT SALT { get; set; }
    }
}
