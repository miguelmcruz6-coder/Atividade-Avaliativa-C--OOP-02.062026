using RotinaBackEnd.Base;
using RotinaBackEnd.Services;
using RotinaBackEnd.Utils;

namespace RotinaBackEnd.Rotinas
{
    public class LimpezaTemp : RotinaBase
    {
        private int arquivosRemovidos;

        public LimpezaTemp() : base("Limpeza de Temporários")
        {
        }

        public override void Executar()
        {
            long tempo = CronometroHelper.MedirTempo(() =>
            {
                ExibirCabecalho();

                Random rnd = new Random();

                arquivosRemovidos = rnd.Next(10, 200);

                Console.WriteLine(
                    $"Arquivos removidos: {arquivosRemovidos}");
            });

            Console.WriteLine(
                $"Tempo de execução: {tempo} ms");

            string log =
                $"Limpeza executada. Arquivos removidos: {arquivosRemovidos}";

            AdicionarLog(log);

            LogService.Salvar(log);

            IncrementarExecucao();
        }
    }
}