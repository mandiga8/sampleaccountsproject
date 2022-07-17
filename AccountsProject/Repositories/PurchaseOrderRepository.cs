using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AccountsProject.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly AppDbContext appDbContext;

        public PurchaseOrderRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Models.PurchaseOrder> GetPurchaseOrders()
        {
            return appDbContext.PurchaseOrders
                    .Include(c => c.Supplier)
                    .ToList();
            //return appDbContext.PurchaseOrders;
        }

        public string CreatePurchaseOrder(Models.PurchaseOrder purchaseOrder)
        {
            try
            {
                appDbContext.PurchaseOrders.Add(purchaseOrder);
                appDbContext.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

    }
}
