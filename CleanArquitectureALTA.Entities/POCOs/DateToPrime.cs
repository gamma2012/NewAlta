﻿using System;

namespace Alta.Entities.POCOs
{
    public class DateToPrime //ALTA_WS_DATA_TO_PRIME - constraint en date
    {
        public int Id { get; set; } // (int, not null)
        public string TranId { get; set; } // (varchar(50), null)
        public string Data { get; set; } // (varchar(MAX), null)
        public string Endpoint { get; set; } // (varchar(50), null)
        public string Application { get; set; } // (varchar(50), null)
        public DateTime Date { get; set; } // (datetime, null) | CONSTRAINT: default value = getdate()
    }
}