using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Xml;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ZonesoftContext;

namespace ZoneSoft
{
    class Server
    {
        string connstring = "";
        public string errorString = "";
        public string str_server = "";
        public string str_database = "";
        public string str_username = "";
        public string str_password = "";
        MySqlConnection con;
        Tool tool = new Tool();
        public void testcontext()
        {
            ZonesoftDataContext db = new ZonesoftDataContext();
            int x=0;
            var zone = db.ZoneUsers.ToList();
            foreach (var a in zone)
            {
                x = a.UserId;
            }

        }

        public Boolean OpenDBOTest(String server, String database, String username, String password)
        {
            String connstringTest = "server=" + server + ";database=" + database + ";uid=" + username + ";pwd=" + password + "";
          
            try
            {
                con = new MySqlConnection(connstringTest);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                errorString = ex.Message;
                return false;
            }       
        }

        public Boolean OpenDBO()
        {
            if (ReadServerXML())
            {
                con = new MySqlConnection(connstring);
                con.Open();
                return true;
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến Server", "Server");
            }
            return false;
        }

        public void CloseDBO()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public Boolean WriterServerXML(String server, String database, String username, String password)
        {
            try
            {
                if (!tool.isNullString(server))
                {
                    if (!System.IO.Directory.Exists("Config"))
                        System.IO.Directory.CreateDirectory("Config");
                    if (!System.IO.File.Exists("Config/System.xml"))
                        System.IO.File.Create("Config/System.xml").Dispose();

                    XmlTextWriter xtw = new XmlTextWriter("Config/System.xml", System.Text.Encoding.UTF8);
                    
                    xtw.Formatting = Formatting.Indented;
                    xtw.WriteStartDocument();
                    xtw.WriteStartElement("System");
                    xtw.WriteElementString("Server", server);
                    xtw.WriteElementString("DataBase", database);
                    xtw.WriteElementString("UserName", username);
                    xtw.WriteElementString("PassWord", password);
                    xtw.WriteEndElement();
                    xtw.WriteEndDocument();
                    xtw.Flush();
                    xtw.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                errorString = ex.Message;
                return false;
            }
            
            return false;
        }

        public Boolean ReadServerXML() 
        {
            string fileName = "Config/System.xml";
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlTextReader xtr = new XmlTextReader(fs);
            while (!xtr.EOF)
            {
                if (xtr.MoveToContent() == XmlNodeType.Element && xtr.Name == "Server")
                {
                    str_server = xtr.ReadElementString();
                }
                else if (xtr.MoveToContent() == XmlNodeType.Element && xtr.Name == "DataBase")
                {
                    str_database = xtr.ReadElementString();
                }
                else if (xtr.MoveToContent() == XmlNodeType.Element && xtr.Name == "UserName")
                {
                    str_username = xtr.ReadElementString();
                }
                else if (xtr.MoveToContent() == XmlNodeType.Element && xtr.Name == "PassWord")
                {
                    str_password = xtr.ReadElementString();
                }
                else
                {
                    xtr.Read();
                }
            }

            fs.Dispose();
            if (!tool.isNullString(str_server) && !tool.isNullString(str_database) && !tool.isNullString(str_username) && !tool.isNullString(str_password))
            {
                connstring = "server=" + str_server + ";database=" + str_database + ";uid=" + str_username + ";pwd=" + str_password + "";
                return true;
            }
            return false;
        }

        
    }
}
