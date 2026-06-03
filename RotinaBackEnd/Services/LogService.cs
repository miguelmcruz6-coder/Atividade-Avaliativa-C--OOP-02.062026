namespace RotinaBackEnd.Services
{
    public static class LogService
    {
        private static readonly string caminho =
            "Logs/logs.txt";

        public static void Salvar(string mensagem)
        {
            Directory.CreateDirectory("Logs");

            File.AppendAllText(
                caminho,
                mensagem + Environment.NewLine);
        }

        public static void MostrarLogs()
        {
            if (File.Exists(caminho))
            {
                Console.WriteLine(
                    File.ReadAllText(caminho));
            }
            else
            {
                Console.WriteLine("Nenhum log encontrado.");
            }
        }
    }
}