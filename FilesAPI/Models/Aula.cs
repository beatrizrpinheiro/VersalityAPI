namespace FilesAPI.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Atividade { get; set; }
        public string Objetivo { get; set; }
        public string Metodo { get; set; }
        public string Processual { get; set; }

        public Aula(int id, string atividade, string objetivo, string metodo, string processual)
        {
            Id = id;
            Atividade = atividade;
            Objetivo = objetivo;
            Metodo = metodo;
            Processual = processual;
        }
    }
}
