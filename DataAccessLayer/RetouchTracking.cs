using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RetouchTracking : ManufacturedProducts
    {
        public int RetouchTrackingID { get; set; }
        public Int16 retouchFaultID { get; set; }
        public string retouchFault { get; set; }
        public DateTime retouchTransactionDate { get; set; }
        public Int16 personnelRegisterID { get; set; }
        public string personalID { get; set; }
        public string username { get; set; }
        public string nameSurname { get; set; }
        public string definition { get; set; }
    }
}
