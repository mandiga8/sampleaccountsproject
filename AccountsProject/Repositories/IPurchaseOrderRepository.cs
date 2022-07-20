using AccountsProject.Models;

namespace AccountsProject.Repositories
{
    public interface IPurchaseOrderRepository
    {
        string CreatePurchaseOrder(PurchaseOrder purchaseOrder);
        PurchaseOrder GetPurchaseOrder(int SupplierID);
        IEnumerable<PurchaseOrder> GetPurchaseOrders();
    }
}