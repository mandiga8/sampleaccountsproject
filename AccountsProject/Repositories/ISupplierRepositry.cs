using AccountsProject.Models;

namespace AccountsProject.Repositories
{
    public interface ISupplierRepositry
    {
        Supplier GetSupplier(int supplierID);
        IEnumerable<Supplier> GetSuppliers();

        public string CreateSupplier(Supplier supplier);
    }
}