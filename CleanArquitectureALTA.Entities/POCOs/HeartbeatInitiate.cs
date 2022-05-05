using System;

namespace Alta.Entities.POCOs
{
    public class HeartbeatInitiate // HEARTBEAT_INITIATE - constraint en creation_time
    {
        public int Id { get; set; } // (int, not null)
        public string TranId { get; set; } // (varchar(50), null)
        public string TranDT { get; set; } // (varchar(50), null)
        public string WHId { get; set; } // (varchar(50), null)
        public string WCSId { get; set; } // (varchar(50), null)
        public string Text { get; set; } // (varchar(MAX), null)
        public DateTime ResponseTimestamp { get; set; } // (datetime, null)
        public string MessageReceived { get; set; } // (varchar(MAX), null)
        public DateTime CreationTimesamp { get; set; } // (datetime, null) | CONSTRAINT: default value = getdate()

    }
}
