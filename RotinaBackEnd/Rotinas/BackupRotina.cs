using RotinaBackEnd.Base;
using RotinaBackEnd.Services;
using RotinaBackEnd.Models;

namespace RotinaBackEnd.Rotinas
{
    // Rotina responsável pela execução de backups
    public class BackupRotina : RotinaBase
    {
        // Pasta de origem dos arquivos
        private string origem;

        // Pasta de destino do backup
        private string destino;

        public BackupRotina(string nome) : base("Backup Automático", nome){}

        public override void Executar()
        {
            // Exibe informações da rotina
            ExibirCabecalho();

            // Carrega as configurações do sistema
            Configuracao config = ConfigService.Carregar();

            // Solicita a pasta de origem
            Console.Write("Pasta origem: ");
            origem = Console.ReadLine();

            // Obtém a pasta de destino configurada
            destino = config.PastaBackup;

            Console.WriteLine($"Destino automático: {destino}");
            Console.WriteLine("Realizando backup...");

            // Simula o tempo necessário para realizar o backup
            Thread.Sleep(2000);
            Console.WriteLine("Backup concluído!");

            // Registra a execução da rotina
            string log =$"Backup realizado de {origem} para {destino}";
            AdicionarLog(log);
            LogService.Salvar(log);

            // Atualiza contador de execuções
            IncrementarExecucao();
        }
    }
}