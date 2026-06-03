using System.Text.Json;
using RotinaBackEnd.Models;

namespace RotinaBackEnd.Services
{
    public static class ConfigService
    {
        private static readonly string caminho =
            "config.json";

        public static Configuracao Carregar()
        {
            if (!File.Exists(caminho))
            {
                return new Configuracao();
            }

            string json = File.ReadAllText(caminho);

            return JsonSerializer.Deserialize<Configuracao>(json)
                   ?? new Configuracao();
        }

        public static void Salvar(Configuracao configuracao)
        {
            string json = JsonSerializer.Serialize(
                configuracao,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(caminho, json);
        }
    }
}