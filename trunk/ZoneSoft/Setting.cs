using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoneSoft
{
   
    public partial class Setting : Form
    {
        BackgroundWorker bgw = new BackgroundWorker();
        
        Boolean checkconnet;
        Boolean checkconnetCompleted;
        Boolean checkmsg;
        Tool tool = new Tool();
        Server con = new Server();

        public Setting()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = false;
            checkconnet = true;
            checkconnetCompleted = true;
            pb_server.Visible = true;
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();

            //Info info = new Info(txt_server.Text,txt_database.Text,txt_username.Text,txt_pass.Text);
            //Thread t = new Thread(info.loadServer);
            //t.Start();
                
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (checkconnet)
            {
                
                if (con.OpenDBOTest(txt_server.Text, txt_database.Text, txt_username.Text, txt_pass.Text))
                {
                    checkmsg = true;
                    if(!con.WriterServerXML(txt_server.Text, txt_database.Text, txt_username.Text, txt_pass.Text))
                        MessageBox.Show(con.errorString);
                }
                else
                {
                    checkmsg = false;   
                }

                checkconnet=false;
            }           
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_server.Value = 0;
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pb_server.Visible = false;
            btn_connect.Enabled = true;
            if (checkconnetCompleted)
            {
                if (checkmsg)
                {
                    MessageBox.Show("Kết nối đến Server thành công", "Server");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công.\n\nThông tin Server không chính xác", "Server");
                }
                checkconnetCompleted = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txt_server_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void checkInput()
        {
            if ( tool.isNull(txt_server) || tool.isNull(txt_database) || tool.isNull(txt_username) || tool.isNull(txt_pass))
                btn_connect.Enabled = false;   
            else
                btn_connect.Enabled = true;
            
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("Config/System.xml"))
            {
                if (con.ReadServerXML())
                {
                    txt_server.Text = con.str_server;
                    txt_database.Text = con.str_database;
                    txt_username.Text = con.str_username;
                    txt_pass.Text = con.str_password;
                }
            }
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
