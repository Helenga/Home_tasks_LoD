using System;
using Newtonsoft.Json;
using System.IO;

namespace JSONSerializer
{
    public class Serializer
    {
        public Serializer(string pathToSaveFile)
        {
            _path = pathToSaveFile;
        }

        public void SaveToFile(Object passedObject)
        {
            string json = JsonConvert.SerializeObject(passedObject, Formatting.Indented);
            File.WriteAllText(_path, json);
        }

        private string _path;
        
    }
}
