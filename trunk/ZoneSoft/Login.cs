using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace ZoneSoft
{
    public partial class Login : Form
    {
        Boolean exit = true;
        Tool tool = new Tool();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                exit = false;
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void lbl_setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit == true)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    exit = false;
                    //Application.Exit();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }
        private void checkInput()
        {
            if (tool.isNull(txt_username) || tool.isNull(txt_pass))
                btn_ok.Enabled = false;
            else
                btn_ok.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new HelloBLL().hello("tuan"));
        }
    }
}
