using FileSorting.Core.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace FileSortingConsole.Parser
{
    internal class ConfigParser<T> where T : ISortingConfig
    {
        private readonly string configPath;

        public ConfigParser() : this("config.json") { }
        public ConfigParser(string configPath)
        {
            this.configPath = configPath;
        }

        public ISortingConfig Parse()
        {
            string fileText;
            using (StreamReader reader = new(configPath, Encoding.UTF8))
            {
                fileText = reader.ReadToEnd();
                reader.Close();
            }

            T? config = JsonSerializer.Deserialize<T>(fileText);
            if (config is null) throw new NullConfigException();
            return config;
        }
    }
}
