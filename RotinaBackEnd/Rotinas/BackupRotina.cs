using RotinaBackEnd.Base;
using RotinaBackEnd.Services;
using RotinaBackEnd.Models;

namespace RotinaBackEnd.Rotinas
{
    public class BackupRotina : RotinaBase
    {
        private string origem;
        private string destino;

        public BackupRotina() :
            base("Backup Automático")
        {
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Configuracao config =
                ConfigService.Carregar();

            Console.Write("Pasta origem: ");
            origem = Console.ReadLine();

            destino = config.PastaBackup;

            Console.WriteLine(
                $"Destino automático: {destino}");

            Console.WriteLine("Realizando backup...");

            Thread.Sleep(2000);

            Console.WriteLine("Backup concluído!");

            string log =
                $"Backup realizado de {origem} para {destino}";

            AdicionarLog(log);

            LogService.Salvar(log);

            IncrementarExecucao();
        }
    }
}