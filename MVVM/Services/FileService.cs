using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;
using Newtonsoft.Json;

namespace MVVM.Services
{
    public class FileService
    {
        private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\MVVM.json";

        public ObservableCollection<ContactModel> Read()
        {
            try
            {
                using var sr = new StreamReader(filePath);
               return JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(sr.ReadToEnd())!;
            }
            catch { return new ObservableCollection<ContactModel>(); }
        }

        public void Save(string contact)
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(contact);
        }
    }
}
