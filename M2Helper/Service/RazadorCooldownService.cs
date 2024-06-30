using M2Helper.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Service
{
    public class RazadorCooldownService
    {
        RazadorCooldownRepository razadorCooldownRepository;

        public RazadorCooldownService()
        {
            razadorCooldownRepository = new RazadorCooldownRepository();
        }

        public async Task<DataTable> GetNextRazadorDate()
        {
            return await razadorCooldownRepository.GetNextRazadorDate();
        }

        public void UpdateNextRazadorTimeAsync(int id)
        {
            razadorCooldownRepository.UpdateNextRazadorTime(id);
        }
        public void RemoveRazadorCooldown(int id)
        {
            razadorCooldownRepository.RemoveRazadorCooldown(id);
        }
    }
}
