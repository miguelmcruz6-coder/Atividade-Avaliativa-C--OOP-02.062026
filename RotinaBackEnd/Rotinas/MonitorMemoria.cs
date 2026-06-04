using RotinaBackEnd.Base;
using RotinaBackEnd.Services;
using RotinaBackEnd.Models;

namespace RotinaBackEnd.Rotinas
{
    // Rotina responsável por monitorar o uso de memória
    public class MonitorMemoria : RotinaBase
    {
        // Percentual de memória utilizado
        private double usoMemoria;

        public MonitorMemoria() : base("Monitor de Memória"){}

        public override void Executar()
        {
            // Exibe informações da rotina
            ExibirCabecalho();

            // Carrega as configurações do sistema
            Configuracao config = ConfigService.Carregar();
            Random rnd = new Random();

            // Simula o uso de memória
            usoMemoria = rnd.Next(30, 100);
            Console.WriteLine($"Uso de memória: {usoMemoria}%");

            // Verifica se o limite configurado foi ultrapassado
            if (usoMemoria > config.LimiteMemoria)
            {
                Console.WriteLine($"ALERTA: memória acima de {config.LimiteMemoria}%!");
            }

            // Registra a execução da rotina
            string log = $"Monitoramento executado. Uso: {usoMemoria}%";
            AdicionarLog(log);
            LogService.Salvar(log);

            // Atualiza contador de execuções
            IncrementarExecucao();
        }
    }
}