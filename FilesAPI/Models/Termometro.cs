namespace FilesAPI.Models
{
    public class Termometro
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Situacao { get; set; }
        public string Relato { get; set; }

        public Termometro(int id, DateTime date, string situacao, string relato)
        {
            Id = id;
            Date = date;
            Situacao = situacao;
            Relato = relato;
        }
    }
}
