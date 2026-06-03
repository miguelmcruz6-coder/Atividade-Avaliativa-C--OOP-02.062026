using System.Diagnostics;

namespace RotinaBackEnd.Utils
{
    public static class CronometroHelper
    {
        public static long MedirTempo(Action acao)
        {
            Stopwatch sw = Stopwatch.StartNew();

            acao();

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}