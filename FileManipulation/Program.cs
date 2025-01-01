namespace FileManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Projetos\Udemy\FileManipulation\file.txt";
            string targetPath = @"C:\Projetos\Udemy\FileManipulation\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
