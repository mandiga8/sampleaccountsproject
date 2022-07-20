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
                    .ToList();
            //return appDbContext.PurchaseOrders;
        }

        public Models.PurchaseOrder GetPurchaseOrder(int SupplierID)
        {
            return appDbContext.PurchaseOrders.Find(SupplierID)!;
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
