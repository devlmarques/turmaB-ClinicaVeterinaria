using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vets.Models {
   public class VetsDB : DbContext {
      // representar a Base de Dados
      // descrevendo as tabelas que lá estão contidas

      // representar o 'construtor' desta classe
      // identifica onde se enconta a Base de Dados
      public VetsDB() : base("VetsDBConnection") { }

      // descrever as 'tabelas' que estão na BD
      public virtual DbSet<Donos> Donos { get; set; }
   }
}