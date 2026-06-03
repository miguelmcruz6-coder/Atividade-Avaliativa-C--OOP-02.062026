namespace RotinaBackEnd.Models
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            DataCadastro = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Nome} - {Email}";
        }
    }
}