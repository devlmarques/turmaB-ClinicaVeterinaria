using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vets.Models {
   public class Donos {
      // vai representar os dados da tabela dos DONOS

      // criar o construtor desta classe
      // e carregar a lista de Animais
      public Donos() {
         ListaDeAnimais = new HashSet<Animais>();
      }

      [Key] // indica que o atributo é PK
      [DatabaseGenerated(DatabaseGeneratedOption.None)] // marca o atributo como NÃO autonumber
      [Display(Name ="Identificador do Cliente")]
      public int DonoID { get; set; }

      [Required(ErrorMessage ="O {0} é de preencimento obrigatório...")]
      [Display(Name ="Nome do Cliente")]
      public string Nome { set; get; }

      [Required(ErrorMessage ="Não se esqueça de preencher o Nº de Contribuinte...")]
      public string NIF { get; set; }

      // especificar que um DONO tem muitos ANIMAIS
      public ICollection<Animais> ListaDeAnimais { get; set; }



   }
}