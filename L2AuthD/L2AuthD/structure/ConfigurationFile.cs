using L2AuthD.logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2AuthD.structure
{
    class ConfigurationFile
    {
        private FileInfo File;
        public SortedList<string, string> _topics;

        public ConfigurationFile(string Path)
        {
            File = new FileInfo(Path);
            _topics = new SortedList<string, string>();
            reload();
        }

        public void reload()
        {
            StreamReader reader = new StreamReader(File.FullName);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Length == 0)
                    continue;

                if (line.StartsWith(";"))
                    continue;

                _topics.Add(line.Split('=')[0], line.Split('=')[1]);
            }

            //Logging.info("Config file " + File.Name + " loaded with " + _topics.Count + " parameters.");
        }

        public string getProperty(string value, string defaultprop)
        {
            string ret;
            try
            {
                ret = _topics[value];
            }
            catch
            {
                return defaultprop;
            }

            return ret == null ? defaultprop : ret;
        }
    }
}
