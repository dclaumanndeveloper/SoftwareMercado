//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CamadaDados
{
    using System;
    using System.Collections.Generic;
    
    public partial class TabelaLoja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TabelaLoja()
        {
            this.TabelaCadProduto = new HashSet<TabelaCadProduto1>();
            this.TabelaCadUsuario = new HashSet<TabelaCadUsuario1>();
        }
    
        public int id { get; set; }
        public string Descricao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabelaCadProduto1> TabelaCadProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabelaCadUsuario1> TabelaCadUsuario { get; set; }
    }
}
