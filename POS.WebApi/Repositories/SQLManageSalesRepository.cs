using POS.WebApi.Contracts;
using POS.WebApi.Data;

namespace POS.WebApi.Repositories
{
    public class SQLManageSalesRepository
    {
        private readonly DataContext dbContext;
        private readonly ISaleTransaction saleRepository;
        private readonly ISaleTransactionItem saleItemRepository;
        private readonly IStockRepository stockRepository;

        public SQLManageSalesRepository(DataContext dbContext,ISaleTransaction saleRepository, ISaleTransactionItem saleItemRepository,IStockRepository stockRepository)
        {
            this.dbContext = dbContext;
            this.saleRepository = saleRepository;
            this.saleItemRepository = saleItemRepository;
            this.stockRepository = stockRepository;
        }
    }
}
