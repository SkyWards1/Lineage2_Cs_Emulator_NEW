using L2AuthD.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2AuthD.configuration
{
    class Сonfiguratione
    {
        public static string SERVER_HOST;
        public static int SERVER_PORT;
        public static int SERVER_PORT_GANESERVER;

        public static string DATABASE_HOST, DATABASE_NAME, DATABASE_USER_ID, DATABASE_PASSWORD;

        public static bool AUTO_ACCOUNTS;

        public static void load()
        {
            ConfigurationFile server = new ConfigurationFile(@"config\server.ini");

            SERVER_HOST = server.getProperty("host", "192.168.1.2");
            SERVER_PORT = int.Parse(server.getProperty("port", "2106"));
            SERVER_PORT_GANESERVER = int.Parse(server.getProperty("gsport", "2107"));

            DATABASE_HOST = server.getProperty("dbhost", "localhost");
            DATABASE_NAME = server.getProperty("dbname", "rabbit_cauth");
            DATABASE_USER_ID = server.getProperty("dbuser", "root");
            DATABASE_PASSWORD = server.getProperty("dbpass", "root");

            AUTO_ACCOUNTS = bool.Parse(server.getProperty("autoaccounts", "false"));
        }

    }
}
