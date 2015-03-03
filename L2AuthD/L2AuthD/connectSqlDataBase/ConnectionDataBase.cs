using L2AuthD.configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2AuthD.connectSqlDataBase
{
    class ConnectionDataBase
    {
        private static ConnectionDataBase sqlDataBase = new ConnectionDataBase();

        public static ConnectionDataBase getInstance()
        {
            return sqlDataBase;
        }

        protected MySqlConnectionStringBuilder connectionBuilder;

        public ConnectionDataBase()
        {
            connectionBuilder = new MySqlConnectionStringBuilder();
            connectionBuilder.Add("Database", Сonfiguratione.DATABASE_NAME);
            connectionBuilder.Add("Data Source", Сonfiguratione.DATABASE_HOST);
            connectionBuilder.Add("User Id", Сonfiguratione.DATABASE_USER_ID);
            connectionBuilder.Add("Password", Сonfiguratione.DATABASE_PASSWORD);

            Console.WriteLine("Sql подключение к Data Base установлено");

        }

        public MySqlConnection connection()
        {
            return new MySqlConnection(connectionBuilder.ConnectionString);
        }


    }
}
