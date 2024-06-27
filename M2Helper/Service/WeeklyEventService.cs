using M2Helper.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Service
{
    public class WeeklyEventService
    {
        private WeeklyEventRepository weeklyEventRepository;
        public WeeklyEventService()
        {
            weeklyEventRepository = new WeeklyEventRepository();
        }
        public async Task<DataTable> ReadEvents()
        {
            return await weeklyEventRepository.ReadEvents();
        }
    }
}
