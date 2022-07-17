using AccountsProject.Models;

namespace AccountsProject.Repositories
{
    public interface IPurchaseOrderRepository
    {
        string CreatePurchaseOrder(PurchaseOrder purchaseOrder);
        IEnumerable<PurchaseOrder> GetPurchaseOrders();
    }
}