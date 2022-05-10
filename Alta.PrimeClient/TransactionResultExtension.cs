using Alta.DTOs.DtoAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Alta.DTOs.HttpDTOs
{
    public static class TransactionResultExtension
    {
        public static async Task<TransactionResult> ToResult(this HttpResponseMessage result, DtoBase dto)
        {
            return new TransactionResult { CODE = (int)result.StatusCode, DATA = dto, MESSAGE = await result.Content.ReadAsStringAsync() };
        }
    }
}
