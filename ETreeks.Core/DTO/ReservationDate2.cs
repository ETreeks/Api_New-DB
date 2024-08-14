using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETreeks.Core.DTO
{
    public class ReservationDate2
    {
        public string User_Full_Name { get; set; }

        public string Reservation_Status { get; set; }
        public string Session_Name { get; set; }
        public string Course_Name { get; set; }
        public string Completed_Status { get; set; }
        public string Final_Mark { get; set; }
        public int userID { get; set; }
        public int CID { get; set; }
        public int Reservation_ID { get; set; }
        public DateTime Reservation_Date { get; set; }
    }
}
