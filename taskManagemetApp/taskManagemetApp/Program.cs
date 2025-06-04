using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using taskManagemetApp.src;

namespace taskManagemetApp
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loginForm = new form())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new formHome()); 
                }
            }
        }
    }
}
