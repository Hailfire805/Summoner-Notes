using SummonerNotes;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace SummonerNotes {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            }
    }
}
