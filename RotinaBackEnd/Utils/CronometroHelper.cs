using System.Diagnostics;

namespace RotinaBackEnd.Utils
{
    // Classe utilitária para medição de tempo de execução
    public static class CronometroHelper
    {
        // Executa uma ação e retorna o tempo gasto em milissegundos
        public static long MedirTempo(Action acao)
        {
            // Inicia o cronômetro
            Stopwatch sw = Stopwatch.StartNew();

            // Executa a ação recebida
            acao();

            // Finaliza a medição
            sw.Stop();

            // Retorna o tempo decorrido
            return sw.ElapsedMilliseconds;
        }
    }
}