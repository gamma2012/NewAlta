using System;

namespace Alta.Entities.POCOs
{
    public class Log //AltaNew_Log - constrain en date
    {
        public int Id { get; set; } // (int, not null)
        public string Description { get; set; } // (text, null)
        public int Code { get; set; } // (int, null)
        public bool Error { get; set; }  // (bit, null)
        public DateTime Date { get; set; } // (datetime, null) | CONSTRAINT: default value = getdate()
        public string Resource { get; set; } // (varchar(50), null)
    }
}
