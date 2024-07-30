using M2Helper.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Service
{
    public class KeyService
    {
        public KeyRepository keyRepository;
        public KeyService()
        {
            keyRepository = new KeyRepository();
        }
        public async Task<DataTable> GetGivenKeyInfo(string key)
        {
            return await keyRepository.getDetailOfGivenKey(key);
        }
    }
}
