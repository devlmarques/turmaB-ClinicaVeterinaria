﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vets.Models {
   public class Animais {

      [Key]
      public int AnimaisID { get; set; }

      public string NomeDoAnimal { get; set; }

      public string Especie { get; set; }

      public string Raca { get; set; }

      // .... outros atributos ficariam aqui



      // criar uma Chave Forasteira - FK
      [ForeignKey("Dono")]
      public int DonoFK { get; set; } // existe para criar a FK na BD
      public Donos Dono { get; set; } // existe para relacionar os objs. no C#

















   }
}