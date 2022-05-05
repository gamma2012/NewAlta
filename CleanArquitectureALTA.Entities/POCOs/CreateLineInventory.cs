namespace Alta.Entities.POCOs
{
    public class CreateLineInventory : Entity // JSON File "CREATE_LINE_INVENTORY", tipos inferidos del documento y las demas tablas.
    {
        public int ID { get; set; } // (int, not null)
        public string TRANID { get; set; } // (varchar(50), null)
        public string TRANDT { get; set; } // (varchar(50), null)
        public string WH_ID{ get; set; } // (varchar(50), null)
        public string WCS_ID { get; set; } // (varchar(50), null)
        public string WKONUM { get; set; } // (varchar(50), null)
        public int WKOREV { get; set; } // (int, null)
        public string PRDLIN { get; set; } // (varchar(50), null)
        public string UOMCOD { get; set; } // (varchar(50), null)
        public int PRTNUM { get; set; } // (int, null)
        public string INVSTS { get; set; } // (varchar(50), null)
        public int UNTQTY { get; set; } // (int, null)
        public string LODNUM { get; set; } // (varchar(50), null)
        public string DSTLOC { get; set; } // (varchar(50), null)
        public string LOTNUM { get; set; } // (varchar(50), null)
        public string ASSET_TYP { get; set; } // (varchar(50), null)
        public string INV_ATTR_DTE1 { get; set; } // (varchar(50), null)
        public string INV_ATTR_DTE2 { get; set; } // (varchar(50), null)S


    }
}
 