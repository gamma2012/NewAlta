using System;

namespace Alta.Entities.POCOs
{
    public class RequestInbox //REQUEST_INBOX - constraints en concluded_request, time_request, failed_request, processing, reprocess_request
    {
        public int Id { get; set; } // (int, not null)
        public string TranId { get; set; } // (varchar(50), null)
        public string TranDT { get; set; } // (varchar(50), null)
        public string WHId { get; set; } // (varchar(50), null)
        public string WCSId { get; set; } // (varchar(50), null)
        public string LODNum { get; set; } // (varchar(50), null)
        public string RequestContentsFlag { get; set; } // (varchar(50), null)
        public string RequestStolocFlag { get; set; } // (varchar(50), null)
        public bool IsProcessing { get; set; } // (int, null) | CONSTRAINT: default value = 0
        public bool HasFailed { get; set; } // (int, null) | CONSTRAINT: default value = 0
        public bool Reprocess { get; set; } // (int, null) | CONSTRAINT: default value = 0
        public bool HasConcluded { get; set; } // (int, null) | CONSTRAINT: default value = 0
        public DateTime CreationTimestamp { get; set; } // (datetime, null) | CONSTRAINT: default value = getdate()
        public int StatusCode { get; set; } // (int, null)
    }
}
