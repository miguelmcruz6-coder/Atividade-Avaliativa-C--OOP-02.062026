using RotinaBackEnd.Base;
using RotinaBackEnd.Services;

namespace RotinaBackEnd.Rotinas
{
    // Rotina responsável por organizar arquivos por categoria
    public class OrganizadorArquivos : RotinaBase
    {
        public OrganizadorArquivos(string nome) : base("Organizador de Arquivos", nome){}

        public override void Executar()
        {
            // Exibe informações da rotina
            ExibirCabecalho();

            // Simula a organização dos arquivos
            Console.WriteLine("Separando imagens...");
            Console.WriteLine("Separando vídeos...");
            Console.WriteLine("Separando documentos...");

            // Registra a execução da rotina
            string log = "Arquivos organizados por categoria.";
            AdicionarLog(log);
            LogService.Salvar(log);

            // Atualiza contador de execuções
            IncrementarExecucao();
        }
    }
}