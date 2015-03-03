using L2AuthD.connectSqlDataBase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2AuthD
{
     class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
         [STAThread]
         static void Main(string[] args)
         {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());
         }
    }
}
