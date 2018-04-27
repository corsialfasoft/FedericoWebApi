﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FedericoWebApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RICHIESTEEntities : DbContext
    {
        public RICHIESTEEntities()
            : base("name=RICHIESTEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ProdottiSet> ProdottiSet { get; set; }
        public virtual DbSet<RichiesteProdotti> RichiesteProdotti { get; set; }
        public virtual DbSet<RichiesteSet> RichiesteSet { get; set; }
    
        public virtual int AddOrdine(Nullable<int> richiesta, Nullable<int> prodotti, Nullable<int> quantita)
        {
            var richiestaParameter = richiesta.HasValue ?
                new ObjectParameter("Richiesta", richiesta) :
                new ObjectParameter("Richiesta", typeof(int));
    
            var prodottiParameter = prodotti.HasValue ?
                new ObjectParameter("Prodotti", prodotti) :
                new ObjectParameter("Prodotti", typeof(int));
    
            var quantitaParameter = quantita.HasValue ?
                new ObjectParameter("Quantita", quantita) :
                new ObjectParameter("Quantita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddOrdine", richiestaParameter, prodottiParameter, quantitaParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> Request(Nullable<System.DateTime> data)
        {
            var dataParameter = data.HasValue ?
                new ObjectParameter("data", data) :
                new ObjectParameter("data", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Request", dataParameter);
        }
    
        public virtual ObjectResult<RicercaDESC_Result> RicercaDESC(string desc)
        {
            var descParameter = desc != null ?
                new ObjectParameter("Desc", desc) :
                new ObjectParameter("Desc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RicercaDESC_Result>("RicercaDESC", descParameter);
        }
    
        public virtual ObjectResult<RicercaID_Result> RicercaID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RicercaID_Result>("RicercaID", idParameter);
        }
    }
}