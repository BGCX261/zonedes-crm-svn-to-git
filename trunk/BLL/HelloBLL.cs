using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HelloBLL
    {
        public string hello(string he)
        {
            if (he != "tuan")
            {
                Hello h = new Hello();
                return h.HelloWorld(he);
            }
            return "khung";
        }
    }
}
