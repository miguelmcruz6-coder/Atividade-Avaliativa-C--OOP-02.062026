// Importa as interfaces do projeto.
// A interface IRotina define o contrato que todas as rotinas devem seguir.
using RotinaBackEnd.Interfaces;

// Importa as implementações das rotinas.
using RotinaBackEnd.Rotinas;

// Importa os serviços auxiliares.
using RotinaBackEnd.Services;

// Importa os modelos de dados.
using RotinaBackEnd.Models;

// =======================================================
// CRIAÇÃO DO OBJETO USUÁRIO
// =======================================================

// Instancia um novo usuário.
Usuario usuario = new Usuario();

// Solicita o nome do usuário.
Console.Write("Nome do usuário: ");

// Armazena o valor digitado na propriedade Nome.
usuario.Nome = Console.ReadLine();

// Solicita o e-mail.
Console.Write("E-mail: ");

// Armazena o e-mail informado.
usuario.Email = Console.ReadLine();

// Exibe uma linha em branco para melhorar a visualização.
Console.WriteLine();

// Exibe mensagem de boas-vindas.
// O método ToString() da classe Usuario será chamado automaticamente.
Console.WriteLine($"Bem-vindo {usuario}");

Console.WriteLine();

// =======================================================
// CARREGA CONFIGURAÇÕES DO SISTEMA
// =======================================================

// Busca as configurações do arquivo JSON.
Configuracao config = ConfigService.Carregar();

// Exibe as configurações carregadas.
Console.WriteLine("Configuração carregada:");

Console.WriteLine(
    $"Limite de memória: {config.LimiteMemoria}%");

Console.WriteLine(
    $"Pasta backup: {config.PastaBackup}");

// =======================================================
// LISTA DE ROTINAS
// =======================================================

// Cria uma lista contendo todas as rotinas disponíveis.
// O uso da interface IRotina permite polimorfismo.
List<IRotina> rotinas = new List<IRotina>()
{
    new LimpezaTemp(),
    new MonitorMemoria(),
    new BackupRotina(),
    new OrganizadorArquivos(),
    new DiagnosticoSistema()
};

// Variável que controla o loop principal do sistema.
bool executando = true;

// =======================================================
// LOOP PRINCIPAL DO MENU
// =======================================================

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
        // Converte o valor digitado para inteiro.
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:

                // Executa a rotina de limpeza.
                rotinas[0].Executar();

                break;

            case 2:

                // Executa monitoramento de memória.
                rotinas[1].Executar();

                break;

            case 3:

                // Executa backup.
                rotinas[2].Executar();

                break;

            case 4:

                // Executa organização de arquivos.
                rotinas[3].Executar();

                break;

            case 5:

                // Executa diagnóstico.
                rotinas[4].Executar();

                break;

            case 6:

                // Executa todas as rotinas cadastradas.
                foreach (IRotina rotina in rotinas)
                {
                    rotina.Executar();
                }

                break;

            case 7:

                // Exibe os logs armazenados.
                LogService.MostrarLogs();

                break;

            case 8:

                // Agenda uma execução da rotina de limpeza.
                AgendamentoService.ExecutarComAtraso(
                    new LimpezaTemp(),
                    5);

                break;

            case 0:

                // Encerra o sistema.
                executando = false;

                break;

            default:

                Console.WriteLine("Opção inválida!");

                break;
        }
    }
    catch (FormatException)
    {
        // Captura erro quando o usuário digita letras.
        Console.WriteLine(
            "Digite apenas números.");
    }
    catch (Exception ex)
    {
        // Captura qualquer outro erro não previsto.
        Console.WriteLine(
            $"Erro: {ex.Message}");
    }
}