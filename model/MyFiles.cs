using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenInterfaces.model
{
    internal class MyFiles
    {
        public string contentFileOrigin { get; set; }
        public string contentFileOther { get; set; }

        public MyFiles(string FirstFile, string SecondFile) {
            this.contentFileOrigin = FirstFile;
            this.contentFileOther = SecondFile;
        }
    }
}
