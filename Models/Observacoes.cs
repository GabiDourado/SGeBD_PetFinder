using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSemestre3___Encontrar.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        public int ObservacoesId { get; set; }

        [Column("ObservacaoDescricao")]
        [Display(Name = "Descrição")]
        public string ObservacaoDescricao { get; set; } = string.Empty;

        [Column("ObservacaoLocal")]
        [Display(Name = "Local")]
        public string ObservacaoLocal { get; set; } = string.Empty;

        [Column("ObservacaoData")]
        [Display(Name = "Data")]
        public DateTime ObservacaoData { get; set; }

        [ForeignKey("AnimaisId")]
        public int AnimaisId { get; set; }
        public Animais? Animais { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
