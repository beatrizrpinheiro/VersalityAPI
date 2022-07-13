namespace FilesAPI.Models
{
    public class Login
    {
        public int Id { get; set; } 
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Login(string usuario, string senha, int id)
        {
            Usuario = usuario;
            Senha = senha;
            Id = id;
        }
    }
}
