using RotinaBackEnd.Interfaces;
using RotinaBackEnd.Rotinas;
using RotinaBackEnd.Services;
using RotinaBackEnd.Models;

Usuario usuario = new Usuario();

Console.Write("Nome do usuário: ");
usuario.Nome = Console.ReadLine();

Console.Write("E-mail: ");
usuario.Email = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Bem-vindo {usuario}");
Console.WriteLine();

Configuracao config = ConfigService.Carregar();

Console.WriteLine("Configuração carregada:");
Console.WriteLine($"Limite de memória: {config.LimiteMemoria}%");
Console.WriteLine($"Pasta backup: {config.PastaBackup}");

List<IRotina> rotinas = new List<IRotina>()
{
    new LimpezaTemp(),
    new MonitorMemoria(),
    new BackupRotina(),
    new OrganizadorArquivos(),
    new DiagnosticoSistema()
};

bool executando = true;

while (executando)
{
    Console.WriteLine("\n===== MENU =====");

    Console.WriteLine("1 - Executar Limpeza");
    Console.WriteLine("2 - Monitorar Memória");
    Console.WriteLine("3 - Fazer Backup");
    Console.WriteLine("4 - Organizar Arquivos");
    Console.WriteLine("5 - Diagnóstico");
    Console.WriteLine("6 - Executar Todas");
    Console.WriteLine("7 - Mostrar Logs");
    Console.WriteLine("8 - Executar limpeza agendada");
    Console.WriteLine("0 - Sair");

    Console.Write("Escolha: ");

    try
    {
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                rotinas[0].Executar();
                break;

            case 2:
                rotinas[1].Executar();
                break;

            case 3:
                rotinas[2].Executar();
                break;

            case 4:
                rotinas[3].Executar();
                break;

            case 5:
                rotinas[4].Executar();
                break;

            case 6:

                foreach (IRotina rotina in rotinas)
                {
                    rotina.Executar();
                }

                break;

            case 7:
                LogService.MostrarLogs();
                break;

            case 8:
                AgendamentoService.ExecutarComAtraso(
                    new LimpezaTemp(),
                    5);

                break;

            case 0:
                executando = false;
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine(
            "Digite apenas números.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(
            $"Erro: {ex.Message}");
    }
}