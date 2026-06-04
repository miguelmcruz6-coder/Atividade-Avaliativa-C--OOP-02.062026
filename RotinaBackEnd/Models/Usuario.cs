namespace RotinaBackEnd.Models
{
    // Modelo que representa um usuário da aplicação
    public class Usuario
    {
        // Nome do usuário
        public string Nome { get; set; }

        // E-mail do usuário
        public string Email { get; set; }

        // Data de cadastro do usuário
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            // Define a data de cadastro no momento da criação
            DataCadastro = DateTime.Now;
        }

        // Retorna uma representação textual do usuário
        public override string ToString()
        {
            return $"{Nome} - {Email}";
        }
    }
}