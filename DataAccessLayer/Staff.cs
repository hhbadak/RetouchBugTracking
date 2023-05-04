using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Staff
    {
        public int ID { get; set; }
        public string nameSurname { get; set; }
        public Int16 departmentID { get; set; }
        public string department { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Int16 authorization { get; set; }
    }
}
