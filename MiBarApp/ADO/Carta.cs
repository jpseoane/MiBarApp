//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiBarApp.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carta
    {
        public int idcarta { get; set; }
        public int idproducto { get; set; }
        public string UserId { get; set; }
        public string descripcion { get; set; }
        public bool activa { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
