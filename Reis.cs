using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рейс
{
    class Reis
    {
        public string Pnazn { get; set; }
        public string Data { get; set; }
        public string Number { get; set; }
        public string Tips { get; set; }
        public string WeekDay { get; set; }
        public string TimeStart { get; set; }
        public string Print()
        {
            string str = "";
            str = str + "  " + Pnazn + "  " + Data + "  " + Number + "  " + Tips + "  " + WeekDay + "  " + TimeStart + "  " ;
            return str;
        }
    }
}
