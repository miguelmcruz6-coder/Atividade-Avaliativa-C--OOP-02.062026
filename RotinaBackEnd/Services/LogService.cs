using RotinaBackEnd.Models;

namespace RotinaBackEnd.Services
{
    // Serviço responsável pelo gerenciamento dos logs da aplicação
    public class LogService
    {
        // Caminho do arquivo onde os logs serão armazenados
        private static string caminho { get; set; }
        
        public LogService(string nomeUsuario)
        {
            caminho = $"Atividade-Avaliativa-C--OOP-02.062026/Logs/{nomeUsuario}-log.txt";
        }

        // Salva uma mensagem de log no arquivo
        public static void Salvar(string mensagem)
        {
            // Garante que a pasta de logs exista
            Directory.CreateDirectory("Atividade-Avaliativa-C--OOP-02.062026/Logs");

            // Adiciona a mensagem ao final do arquivo
            File.AppendAllText(
                caminho,
                mensagem + Environment.NewLine);
        }

        // Exibe todos os logs armazenados
        public static void MostrarLogs()
        {
            // Verifica se o arquivo de log existe
            if (File.Exists(caminho))
            {
                // Exibe o conteúdo completo do arquivo
                Console.WriteLine(File.ReadAllText(caminho));
            }
            else
            {
                // Informa que ainda não há logs registrados
                Console.WriteLine("Nenhum log encontrado.");
            }
        }
    }
}