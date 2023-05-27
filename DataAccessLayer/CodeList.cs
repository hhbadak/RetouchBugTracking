using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CodeList
    {
        public int ID { get; set; }
        public Int16 number { get; set; }
        public string defination { get; set; }
        public string clay { get; set; }
        public string patternCode { get; set; }
        public string description { get; set; }
        public string stockCode { get; set; }
        public int stock { get; set; }
        public string group { get; set; }
        public decimal weight { get; set; }
    }
}
