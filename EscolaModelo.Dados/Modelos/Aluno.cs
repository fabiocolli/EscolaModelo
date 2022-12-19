using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaModelo.Dados.Modelos
{
    public partial class Aluno
    {
        public Aluno()
        {
            TurmaDoAluno = new HashSet<Turma>();
        }

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime Nascimento { get; set; }

        [InverseProperty("IdTurmaNavigation")]
        public virtual ICollection<Turma> TurmaDoAluno { get; set; }
    }
}
