using System;
using Newtonsoft.Json;
using System.IO;

namespace JSONSerializer
{
    public class Serializer
    {
        public Serializer(string pathToSaveOrReadFile)
        {
            _path = pathToSaveOrReadFile;
        }

        public void SaveToFile(Object passedObject)
        {
            string json = JsonConvert.SerializeObject(passedObject, Formatting.Indented);
            File.WriteAllText(_path, json);
        }

        public Object ReadFromFile()
        {
            if (File.Exists(_path))
            {
                var caller = JsonConvert.DeserializeObject(File.ReadAllText(_path));
                return caller;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        private string _path;
        
    }
}
