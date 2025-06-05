using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace taskManagemetApp.src
{
    internal class DbConfig
    {
        public static String GetConnectionString()
        {
            String baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(baseDir, "xml", "connection.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            String server   = doc.SelectSingleNode("//Server")?.InnerText;
            String database = doc.SelectSingleNode("//Database")?.InnerText;
            String user     = doc.SelectSingleNode("//User")?.InnerText;
            String password = doc.SelectSingleNode("//Password")?.InnerText;

            return $"Server={server};Database={database};Uid={user};Pwd={password};";
        }
    }
}
