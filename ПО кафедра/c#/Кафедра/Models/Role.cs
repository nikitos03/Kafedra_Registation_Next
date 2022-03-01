using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Role
    {
        public int id { get; set; }
        public string login { get; set; }

        public override string ToString() => login;
    }
}
