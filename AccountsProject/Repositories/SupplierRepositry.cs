using AccountsProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AccountsProject.Repositories
{
    public class SupplierRepositry : ISupplierRepositry
    {
        private readonly AppDbContext context;

        public SupplierRepositry(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return context.Suppliers;
        }

        public Supplier GetSupplier(int supplierID)
        {
            return context.Suppliers.Find(supplierID);
        }

        public string CreateSupplier(Supplier supplier)
        {
            try
            {
                context.Suppliers.Add(supplier);
                context.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

    }
}
