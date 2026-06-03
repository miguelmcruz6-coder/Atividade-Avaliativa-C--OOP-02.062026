using RotinaBackEnd.Interfaces;

namespace RotinaBackEnd.Services
{
    public static class AgendamentoService
    {
        public static void ExecutarComAtraso(
            IRotina rotina,
            int segundos)
        {
            Console.WriteLine(
                $"Executando em {segundos} segundos...");

            Thread.Sleep(segundos * 1000);

            rotina.Executar();
        }
    }
}