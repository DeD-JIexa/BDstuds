//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilBD.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dnevnik
    {
        public int idD { get; set; }
        public int IdS { get; set; }
        public int IdObj { get; set; }
        public int IdP { get; set; }
        public int IdO { get; set; }
    
        public virtual Appar Appar { get; set; }
        public virtual Studs Studs { get; set; }
        public virtual Supject Supject { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
