using RotinaBackEnd.Base;
using RotinaBackEnd.Services;

namespace RotinaBackEnd.Rotinas
{
    public class OrganizadorArquivos : RotinaBase
    {
        public OrganizadorArquivos() :
            base("Organizador de Arquivos")
        {
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Console.WriteLine("Separando imagens...");
            Console.WriteLine("Separando vídeos...");
            Console.WriteLine("Separando documentos...");

            string log =
                "Arquivos organizados por categoria.";

            AdicionarLog(log);

            LogService.Salvar(log);

            IncrementarExecucao();
        }
    }
}