namespace FileManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Caminhos dos arquivos de origem e destino
            string sourcePath = @"C:\Projetos\Udemy\FileManipulation\file.txt";
            string targetPath = @"C:\Projetos\Udemy\FileManipulation\file2.txt";

            try
            {
                /// <summary>
                /// Cria um objeto FileInfo para o arquivo de origem.
                /// </summary>
                FileInfo fileInfo = new FileInfo(sourcePath);
                /// <summary>
                /// Copia o arquivo de origem para o destino.
                /// </summary>
                fileInfo.CopyTo(targetPath);
                /// <summary>
                /// Lê todas as linhas do arquivo de origem.
                /// </summary>
                string[] lines = File.ReadAllLines(sourcePath);
                /// <summary>
                /// Imprime cada linha do arquivo no terminal.
                /// </summary>
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            /// <summary>
            /// Captura e trata exceções de E/S que possam ocorrer durante a manipulação de arquivos.
            /// </summary>
            /// <param name="e">A exceção de E/S capturada.</param>
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
