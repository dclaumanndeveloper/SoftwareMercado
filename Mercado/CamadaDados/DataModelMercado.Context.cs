﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbMercadoEntities1 : DbContext
    {
        public dbMercadoEntities1()
            : base("name=dbMercadoEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TabelaCadProduto> TabelaCadProduto { get; set; }
        public virtual DbSet<TabelaCadUsuario> TabelaCadUsuario { get; set; }
        public virtual DbSet<TabelaComprador> TabelaComprador { get; set; }
        public virtual DbSet<TabelaFamiliaProduto> TabelaFamiliaProduto { get; set; }
        public virtual DbSet<TabelaFornecedor> TabelaFornecedor { get; set; }
        public virtual DbSet<TabelaLoja> TabelaLoja { get; set; }
        public virtual DbSet<TabelaMercadoria> TabelaMercadoria { get; set; }
        public virtual DbSet<TabelaSetorProduto> TabelaSetorProduto { get; set; }
        public virtual DbSet<TabelaSetorUsuario> TabelaSetorUsuario { get; set; }
        public virtual DbSet<TabelaSituacaoCadastro> TabelaSituacaoCadastro { get; set; }
        public virtual DbSet<TabelaUnidadeMedida> TabelaUnidadeMedida { get; set; }
    }
}
