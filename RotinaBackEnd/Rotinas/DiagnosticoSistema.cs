using RotinaBackEnd.Base;
using RotinaBackEnd.Services;

namespace RotinaBackEnd.Rotinas
{
    // Rotina responsável por exibir informações do sistema
    public class DiagnosticoSistema : RotinaBase
    {
        public DiagnosticoSistema() : base("Diagnóstico do Sistema"){}

        public override void Executar()
        {
            // Exibe informações da rotina
            ExibirCabecalho();

            // Exibe informações básicas do ambiente
            Console.WriteLine($"Máquina: {Environment.MachineName}");
            Console.WriteLine($"Usuário: {Environment.UserName}");
            Console.WriteLine($"Sistema: {Environment.OSVersion}");
            Console.WriteLine($"Data/Hora: {DateTime.Now}");

            // Registra a execução da rotina
            string log ="Diagnóstico realizado.";
            AdicionarLog(log);
            LogService.Salvar(log);

            // Atualiza contador de execuções
            IncrementarExecucao();
        }
    }
}