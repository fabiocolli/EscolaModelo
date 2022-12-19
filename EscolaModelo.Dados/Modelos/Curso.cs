using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaModelo.Dados.Modelos
{
    public partial class Curso
    {
        public Curso()
        {
            TurmaDoCurso = new HashSet<Turma>();
        }

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public int creditosNecessarios { get; set; }

        [InverseProperty("IdCursoNavigation")]
        public virtual ICollection<Turma> TurmaDoCurso { get; set; }

    }
}
