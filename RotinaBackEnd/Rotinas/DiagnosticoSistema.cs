using RotinaBackEnd.Base;
using RotinaBackEnd.Services;

namespace RotinaBackEnd.Rotinas
{
    public class DiagnosticoSistema : RotinaBase
    {
        public DiagnosticoSistema() :
            base("Diagnóstico do Sistema")
        {
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Console.WriteLine(
                $"Máquina: {Environment.MachineName}");

            Console.WriteLine(
                $"Usuário: {Environment.UserName}");

            Console.WriteLine(
                $"Sistema: {Environment.OSVersion}");

            Console.WriteLine(
                $"Data/Hora: {DateTime.Now}");

            string log =
                "Diagnóstico realizado.";

            AdicionarLog(log);

            LogService.Salvar(log);

            IncrementarExecucao();
        }
    }
}