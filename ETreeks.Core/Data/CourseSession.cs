﻿using System;
using System.Collections.Generic;

namespace ETreeks.Core.Data
{
    public partial class CourseSession
    {
        public decimal Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Createddate { get; set; }
        public string? Available_Status { get; set; }
        public decimal? Course_Id { get; set; }

        public virtual Course? Course { get; set; }
    }
}
