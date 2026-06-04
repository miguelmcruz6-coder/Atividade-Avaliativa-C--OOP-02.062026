using RotinaBackEnd.Interfaces;

namespace RotinaBackEnd.Services
{
    // Serviço responsável por agendar a execução de rotinas
    public static class AgendamentoService
    {
        // Executa uma rotina após um tempo de espera
        public static void ExecutarComAtraso(
            IRotina rotina,
            int segundos)
        {
            // Informa o tempo restante para execução
            Console.WriteLine(
                $"Executando em {segundos} segundos...");

            // Aguarda o tempo definido
            Thread.Sleep(segundos * 1000);

            // Executa a rotina agendada
            rotina.Executar();
        }
    }
}