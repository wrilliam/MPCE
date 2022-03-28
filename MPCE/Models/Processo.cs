using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MPCE.Models
{
    public class Processo
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Código")]
        [Column(TypeName = "nvarchar(10)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public string Codigo { get; set; }

        [DisplayName("Título")]
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public string Titulo { get; set; }

        [DisplayName("Descrição")]
        [Column(TypeName = "nvarchar(250)")]
        public string Descricao { get; set; }

        [DisplayName("Data de Criação")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public DateTime DataCriacao { get; set; }

        [ForeignKey("Categoria")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
