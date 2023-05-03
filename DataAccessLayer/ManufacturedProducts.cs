using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ManufacturedProducts
    {
        public int ManufacturedProductsID { get; set; }
        public string barcode { get; set; }
        public int productionStaffID { get; set; }
        public string productionStaff { get; set; }
        public Int16 quantity { get; set; }
        public string status { get; set; }
        public DateTime productTime { get; set; }
        public int benchMoldID { get; set; }
        public string benchMold { get; set; }
        public int workbenchID { get; set; }
        public string workbench { get; set; }
        public Int16 faultID { get; set; }
        public string fault { get; set; }
        public Int16 shiftID { get; set; }
        public string shift { get; set; }
        public DateTime productTransactionDate { get; set; }
        public int dailyProductionID { get; set; }
    }
}
