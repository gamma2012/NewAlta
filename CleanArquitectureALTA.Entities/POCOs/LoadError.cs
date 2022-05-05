namespace Alta.Entities.POCOs
{
    public class LoadError // JSON File "LOAD_ERROR", tipos inferidos del documento y las demas tablas.
    {
        public int Id { get; set; } // (int, not null)
        public string TranId { get; set; } // (varchar(50), null)
        public string TranDT { get; set; } // (varchar(50), null)
        public string WHId { get; set; } // (varchar(50), null)
        public string WCSId { get; set; } // (varchar(50), null)
        public string LODNum { get; set; } // (varchar(50), null)
        public string ErrorCode { get; set; } // (varchar(50), null)
    }
}
