using M2Helper.Models;
using M2Helper.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Service
{
    public class KilledRazadorService
    {
        public KilledRazadorRepository razadorRepository;
        public KilledRazadorService()
        {
            razadorRepository = new KilledRazadorRepository();
        }

        public async Task<DataTable> ReadKilledRazadorRecords()
        {
            return await razadorRepository.ReadKilledRazadorRecords();
        }

        public void AddKilledRazadorRecord(KilledRazador killedRazador)
        {
            razadorRepository.AddKilledRazadorRecord(killedRazador);
        }
        public void DeleteKilledRazadorRecord(int Id)
        {
            razadorRepository.DeleteKilledRazadorRecord(Id);
        }
    }
}
