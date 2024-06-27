using M2Helper.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin2Helper.Service
{
    public class SaleService
    {
        private SaleRepository saleRepository;
        public SaleService()
        {
            saleRepository = new SaleRepository();
        }
        public async Task<DataTable> ReadSales()
        {
            return await saleRepository.ReadSales();
        }
    }
}
