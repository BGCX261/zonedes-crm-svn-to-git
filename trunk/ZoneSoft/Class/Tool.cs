using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoneSoft
{
    public class Tool
    {
        public Boolean isNull(TextBox t)
        {
            if (t.Text.Trim() == "" || t.Text.Trim() == null)
                return true;
            return false;
        }

        public Boolean isNullString(string t)
        {
            if (t.Trim() == "" || t.Trim() == null)
                return true;
            return false;
        }

    }
}
