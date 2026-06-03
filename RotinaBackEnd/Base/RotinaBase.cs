using RotinaBackEnd.Interfaces;

namespace RotinaBackEnd.Base
{
    public abstract class RotinaBase : IRotina
    {
        protected string Nome { get; set; }

        public DateTime DataCriacao { get; private set; }

        // ENCAPSULAMENTO
        private List<string> logs = new List<string>();

        private int quantidadeExecucoes;

        protected RotinaBase(string nome)
        {
            Nome = nome;
            DataCriacao = DateTime.Now;
        }

        public abstract void Executar();

        public virtual void ExibirCabecalho()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"ROTINA: {Nome}");
            Console.WriteLine($"CRIADA EM: {DataCriacao}");
            Console.WriteLine("==================================");
        }

        public void AdicionarLog(string mensagem)
        {
            logs.Add($"{DateTime.Now} - {mensagem}");
        }

        public List<string> ObterLogs()
        {
            return logs;
        }

        public void IncrementarExecucao()
        {
            quantidadeExecucoes++;
        }

        public int ObterQuantidadeExecucoes()
        {
            return quantidadeExecucoes;
        }

        public string ObterDescricao()
        {
            return $"Rotina: {Nome}";
        }
    }
}