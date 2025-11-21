using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Management_Hotel
{
    public class Check
    {
        public bool checkid(string ac)
        {
            return Regex.IsMatch(ac, "^[0-9]{6,24}$");
        }
        public bool check(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z]{1,100}$");
        }
        public bool checkphone(string ac)
        {
            return Regex.IsMatch(ac, "^[0-9]{6,12}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[\w]{3,20}@gmail.com(.vn|)$"); //dau "|" la neu co phai co .vn con k co thi thoi
        }
        public bool checkmoney(string ac)
        {
            return Regex.IsMatch(ac, "^[0-9]{4,10}$");
        }
        public bool checkroomid(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{1,10}$");
        }
    }
}
