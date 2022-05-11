using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alta.DTOs;
using Alta.Entities.POCOs;



namespace Alta.Entities.Interfaces
{
    public interface IAltaRepository
    {
        public Task InsertLogAsync();
        public Task<CreateLineInventory> SaveDataToPrimeAsync(CreateLineInventory createLineInventory);
        public Task SaveDataFromPrimeAsync();
        public Task SetHeartbeatConfirmAsync();
        public Task SetLoadDetailAsync();
        public Task SetLoadErrorlAsync();
        public Task InsertRequestInitiateAsync();
        public Task<HeartbeatInitiate> InsertHeartbeatInitiateAsync(HeartbeatInitiate heartbeatInitiate);
        public Task<IEnumerable<RequestInbox>> CheckReprocessAsync();
        public Task InsertRequestToReprocessAsync();
        
    }
}
