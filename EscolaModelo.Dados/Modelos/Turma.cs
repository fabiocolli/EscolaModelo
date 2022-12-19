using System.ComponentModel.DataAnnotations;

namespace EscolaModelo.Dados.Modelos
{
    public class Turma
    {
        public enum Serie
        {
            A, B, C, D, E
        }

        [Key]
        public int Id { get; set; }

        //[ForeignKey("IdCurso")]
        //[InverseProperty("Curso")]
        public int IdCurso { get; set; }

        //[ForeignKey("IdAluno")]
        //[InverseProperty("Aluno")]
        public int IdAluno { get; set; }
        public Serie? Grau { get; set; }

        public Curso Curso { get; set; }
        public Aluno Aluno { get; set; }
    }
}
