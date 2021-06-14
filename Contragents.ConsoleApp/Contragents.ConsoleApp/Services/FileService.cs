using Contragents.ConsoleApp.Models;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Contragents.ConsoleApp.Services;

namespace Contragents.ConsoleApp.Services
{
    public abstract class FileService
    {
        public int counter { get; protected set; }
        public string FilePath { get; }
        public FileService(string filePath)
        {
            FilePath = filePath;
            counter = 0;
        }

        protected abstract string GetStringFromContragent(Contragent contragent);
        public    abstract bool WriteContragentsToFile(List<Contragent> contragentsList);
         
    }   
}

