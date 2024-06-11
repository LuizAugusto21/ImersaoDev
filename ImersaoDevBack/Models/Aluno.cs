
namespace ImersaoDev.models
{
    public class Aluno
    {
        public string? Name { get; set; }
        public string? Materia { get; set; }
        public float NotaUnidade1 { get; set; }
        public float NotaUnidade2 { get; set; }
        public float NotaUnidade3 { get; set; }
        public float media { get; set; }
        
        public char? conceito { get; set; }
    }
}