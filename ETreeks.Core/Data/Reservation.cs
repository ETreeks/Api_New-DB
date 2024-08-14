using System;
using System.Collections.Generic;

namespace ETreeks.Core.Data
{
    public partial class Reservation
    {
        public Reservation()
        {
            Notifications = new HashSet<Notification>();
        }

        public decimal Id { get; set; }
        public string? Reservationstatus { get; set; }
        public DateTime? Reservationdate { get; set; }
        public decimal? Gusers_Id { get; set; }
        public decimal? Session_Id { get; set; }
        public decimal? Finalmark { get; set; }
        public string? Completed { get; set; }

        public virtual Guser? Gusers { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
