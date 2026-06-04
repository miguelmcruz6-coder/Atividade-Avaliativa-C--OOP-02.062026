using RotinaBackEnd.Interfaces;

namespace RotinaBackEnd.Base
{
    // Classe abstrata que serve como base para todas as rotinas.
    // Implementa a interface IRotina.
    public abstract class RotinaBase : IRotina
    {
        // Nome da rotina.
        protected string Nome { get; set; }

        // Data de criação da rotina.
        public DateTime DataCriacao { get; private set; }

        // Lista privada de logs.
        // Demonstra encapsulamento.
        private List<string> logs = new List<string>();

        // Quantidade de vezes que a rotina foi executada.
        private int quantidadeExecucoes;

        // Construtor da classe base.
        protected RotinaBase(string nome)
        {
            Nome = nome;
            DataCriacao = DateTime.Now;
        }

        // Método obrigatório que será implementado
        // pelas classes filhas.
        public abstract void Executar();

        // Exibe informações básicas da rotina.
        public virtual void ExibirCabecalho()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"ROTINA: {Nome}");
            Console.WriteLine($"CRIADA EM: {DataCriacao}");
            Console.WriteLine("==================================");
        }

        // Adiciona um log interno.
        public void AdicionarLog(string mensagem)
        {
            logs.Add($"{DateTime.Now} - {mensagem}");
        }

        // Retorna todos os logs armazenados.
        public List<string> ObterLogs()
        {
            return logs;
        }

        // Incrementa contador de execuções.
        public void IncrementarExecucao()
        {
            quantidadeExecucoes++;
        }

        // Retorna quantidade executada.
        public int ObterQuantidadeExecucoes()
        {
            return quantidadeExecucoes;
        }

        // Retorna descrição da rotina.
        public string ObterDescricao()
        {
            return $"Rotina: {Nome}";
        }
    }
}