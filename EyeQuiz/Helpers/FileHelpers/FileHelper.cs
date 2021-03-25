using System.IO;

namespace EyeQuiz.Helpers.FileHelpers
{
    public static class FileHelper
    {
        public static string GetFilePath(string directoryPath, string fileName) => $@"{directoryPath}\{fileName}";
    }
}