using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public int? role { get; set; }

        public Role Role { get; set; }
    }
}
