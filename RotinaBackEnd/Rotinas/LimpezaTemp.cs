using RotinaBackEnd.Base;
using RotinaBackEnd.Models;
using RotinaBackEnd.Services;
using RotinaBackEnd.Utils;

namespace RotinaBackEnd.Rotinas
{
    // Rotina responsável pela limpeza de arquivos temporários
    public class LimpezaTemp : RotinaBase
    {
        // Quantidade de arquivos removidos
        private int arquivosRemovidos;

        public LimpezaTemp(string nome) : base("Limpeza de Temporários", nome){}

        public override void Executar()
        {
            // Mede o tempo de execução da rotina
            long tempo = CronometroHelper.MedirTempo(() =>
            {
                // Exibe informações da rotina
                ExibirCabecalho();

                Random rnd = new Random();

                // Simula a remoção de arquivos
                arquivosRemovidos = rnd.Next(10, 200);

                Console.WriteLine($"Arquivos removidos: {arquivosRemovidos}");
            });

            // Exibe o tempo gasto na execução
            Console.WriteLine($"Tempo de execução: {tempo} ms");

            // Registra a execução da rotina
            string log = $"Limpeza executada. Arquivos removidos: {arquivosRemovidos}";

            AdicionarLog(log);
            LogService.Salvar(log);

            // Atualiza contador de execuções
            IncrementarExecucao();
        }
    }
}