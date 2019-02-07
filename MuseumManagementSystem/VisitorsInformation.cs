using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumManagementSystem
{
    public class VisitorsInformation
    {

        [CsvIgnore]
        [Browsable(false)]
        public string Day { get; set; }
        public Int64 ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Int64 ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string Occupation { get; set; }
        public string EntryDate { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutTime { get; set; }
        [CsvIgnore]
        [Browsable(false)]
        public double TotalDuration { get; set; } 
    }
}
