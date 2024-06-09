
namespace ImersaoDev.models
{
    public class Aluno
    {
        public string? Name { get; set; }
        public string? Materia { get; set; }
        public double NotaUnidade1 { get; set; }
        public double NotaUnidade2 { get; set; }
        public double NotaUnidade3 { get; set; }
        public double media { get; set; }
        
        public char? conceito { get; set; }
    }
}