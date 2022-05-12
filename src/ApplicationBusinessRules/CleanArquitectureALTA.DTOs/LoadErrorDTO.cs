using System.Text.Json.Serialization;
using Alta.DTOs.DtoAbstraction;

namespace Alta.DTOs
{
    public class LoadErrorDTO : DtoBase
    {
        [JsonPropertyName("LOAD_ERROR")]
        public LOAD_ERROR LoadError { get; set; }
    }

    public partial class LOAD_ERROR
    {
        [JsonPropertyName("CTRL_SEG")]
        public LOAD_ERROR_CTRLSEG CtrlSeg { get; set; }

    }

    public partial class LOAD_ERROR_CTRLSEG
    {
        [JsonPropertyName("TRANID")]
        public string Tranid { get; set; }

        [JsonPropertyName("TRANDT")]
        public string Trandt { get; set; }

        [JsonPropertyName("WH_ID")]
        public string WhId { get; set; }

        [JsonPropertyName("WCS_ID")]
        public string WcsId { get; set; }


        [JsonPropertyName("LOAD_ERR_SEG")]
        public LOAD_ERROR_SEG LoadErrorSeg { get; set; }

    }


    public partial class LOAD_ERROR_SEG
    {
        [JsonPropertyName("LODNUM")]
        public string LODNUM { get; set; }

        [JsonPropertyName("ERROR_CODE")]
        public string ERROR_CODE { get; set; }

    }
}