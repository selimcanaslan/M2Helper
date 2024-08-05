using M2Helper.Data;
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
    public class CooldownsService
    {
        CooldownsRepository cooldownRepository;

        public CooldownsService()
        {
            cooldownRepository = new CooldownsRepository();
        }

        public async Task<DataTable> GetCooldownAsDataTableAsync(int userId)
        {
            return await cooldownRepository.GetCooldownAsDataTableAsync(userId);
        }

        public async void AddOrUpdateRazadorCooldown(int userId)
        {
            cooldownRepository.AddOrUpdateRazadorCooldown(userId);
        }
        public void RemoveCooldown(int userId)
        {
            cooldownRepository.RemoveCooldown(userId);
        }
        public void UserRegistirationCooldownsFirstCreation(int userId)
        {
            cooldownRepository.UserRegistirationCooldownsFirstCreation(userId);
        }
    }
}
