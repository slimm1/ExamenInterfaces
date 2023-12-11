using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenInterfaces.utils
{
    internal class FileManager
    {
        public static string[] GetFilesInPath() {
            return Directory.EnumerateFiles(AppConstants.FILES_PATH).ToArray();
        }

        public static string GetFileContent(string path) {
            return File.ReadAllText(path);
        }
    }
}
