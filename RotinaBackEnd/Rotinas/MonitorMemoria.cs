using RotinaBackEnd.Base;
using RotinaBackEnd.Services;
using RotinaBackEnd.Models;

namespace RotinaBackEnd.Rotinas
{
    public class MonitorMemoria : RotinaBase
    {
        private double usoMemoria;

        public MonitorMemoria() :
            base("Monitor de Memória")
        {
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Configuracao config =
                ConfigService.Carregar();

            Random rnd = new Random();

            usoMemoria = rnd.Next(30, 100);

            Console.WriteLine(
                $"Uso de memória: {usoMemoria}%");

            if (usoMemoria > config.LimiteMemoria)
            {
                Console.WriteLine(
                    $"ALERTA: memória acima de {config.LimiteMemoria}%!");
            }

            string log =
                $"Monitoramento executado. Uso: {usoMemoria}%";

            AdicionarLog(log);

            LogService.Salvar(log);

            IncrementarExecucao();
        }
    }
}