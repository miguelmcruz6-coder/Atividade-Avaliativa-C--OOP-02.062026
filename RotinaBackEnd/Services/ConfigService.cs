using System.Text.Json;
using RotinaBackEnd.Models;

namespace RotinaBackEnd.Services
{
    // Serviço responsável pelo gerenciamento das configurações da aplicação
    public static class ConfigService
    {
        // Caminho do arquivo de configuração
        private static readonly string caminho =
            "config.json";

        // Carrega as configurações salvas no arquivo
        public static Configuracao Carregar()
        {
            // Retorna configurações padrão caso o arquivo não exista
            if (!File.Exists(caminho))
            {
                return new Configuracao();
            }

            // Lê o conteúdo do arquivo JSON
            string json = File.ReadAllText(caminho);

            // Converte o JSON para o objeto Configuracao
            return JsonSerializer.Deserialize<Configuracao>(json)
                   ?? new Configuracao();
        }

        // Salva as configurações no arquivo JSON
        public static void Salvar(Configuracao configuracao)
        {
            // Converte o objeto para JSON formatado
            string json = JsonSerializer.Serialize(
                configuracao,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            // Grava o conteúdo no arquivo
            File.WriteAllText(caminho, json);
        }
    }
}