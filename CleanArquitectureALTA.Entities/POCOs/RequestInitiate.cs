﻿using System;

namespace Alta.Entities.POCOs
{
    public class RequestInitiate // REQUEST_INITIATE - constraint en concluded y creation_time
    {
        public int Id { get; set; } // (int, not null)
        public string TranId { get; set; } // (varchar(50), null)
        public string TranDT { get; set; } // (varchar(50), null)
        public string WHId { get; set; } // (varchar(50), null)
        public string WCSId { get; set; } // (varchar(50), null)
        public string LODNum { get; set; } // (varchar(50), null)
        public string RequestContentsFlag { get; set; } // (varchar(50), null)
        public string RequestStolocFlag { get; set; } // (varchar(50), null)
        public string MessageSent { get; set; } // (varchar(MAX), null)
        public DateTime ResponseTimestamp { get; set; } // (datetime, null)
        public string MessageReceived { get; set; } // (varchar(MAX), null)
        public bool HasConcluded { get; set; } // (bit, null) | CONSTRAINT: default value = 0
        public DateTime CreationTimestamp { get; set; } // (datetime, null) | CONSTRAINT: default value = getdate()
        public bool Appointed { get; set; } // (bit, null)
        public string Line { get; set; } // (varchar(100), null)

    }
}
