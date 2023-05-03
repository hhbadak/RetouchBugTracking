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
        public string personal { get; set; }

    }
}
