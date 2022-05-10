using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alta.EFCore.DataContext;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;

namespace Alta.EFCore.Repositories
{
    public class SQLServerAltaRepository : IAltaRepository
    {
        private readonly AltaContext _context;
        public SQLServerAltaRepository(AltaContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<RequestInbox>> CheckReprocessAsync()
        {
            throw new NotImplementedException();
        }

        //DONE
        public async Task<HeartbeatInitiate> InsertHeartbeatInitiateAsync(HeartbeatInitiate heartbeatInitiate)
        {
            await _context.HeartbeatInitiate.AddAsync(heartbeatInitiate);
            return heartbeatInitiate;
        }

        public Task InsertLogAsync()
        {
            //probablemente el mas importante
            throw new NotImplementedException();
        }



        public Task InsertRequestInitiateAsync()
        {
            //este
            throw new NotImplementedException();
        }



        public Task InsertRequestToReprocessAsync()
        {
            throw new NotImplementedException();
        }



        public Task SaveDataFromPrimeAsync()
        {
            throw new NotImplementedException();
        }



        public Task SaveDataToPrimeAsync()
        {
            //dudoso
            throw new NotImplementedException();
        }



        public async Task<CreateLineInventory> SaveDataToPrimeAsync(CreateLineInventory createLineInventory)
        {
            //TODO: ADD LOGIC TO VALIDATE POCO INSTANCE HERE
            /*await _context.CREATE_LINE_INVENTORY.AddAsync(createLineInventory);
            return createLineInventory;*/
            throw new NotImplementedException();
        }



        public Task SetHeartbeatConfirmAsync()
        {
            throw new NotImplementedException();
        }



        public Task SetLoadDetailAsync()
        {
            throw new NotImplementedException();
        }



        public Task SetLoadErrorlAsync()
        {
            throw new NotImplementedException();
        }
    }
}