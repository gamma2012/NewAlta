namespace Alta.Entities.POCOs
{
    public class APIKey //AltaNew_ApiKey
    {
        public int Id { get; set; } // (int, not null)
        public string KeyValue { get; set; } // (varchar(200), null)
        public string ApiName { get; set; } // (varchar(50), null)
        public string ApplicationAccess { get; set; } // (varchar(50), null)
        public string Description { get; set; }  // (varchar(50), null)
        public bool IsActive { get; set; }  // (int, null)
    }
}
