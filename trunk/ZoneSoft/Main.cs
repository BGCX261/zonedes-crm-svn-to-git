using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoneSoft
{
    public partial class Main : Form
    {
        Boolean exit = true;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
