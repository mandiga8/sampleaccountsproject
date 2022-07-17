using AccountsProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepositry supplierRepositry;

        public SupplierController(ISupplierRepositry supplierRepositry)
        {
            this.supplierRepositry = supplierRepositry;
        }

        [HttpGet("GetSuppliers")]
        public IActionResult GetSuppliers()
        {
            try
            {
                IEnumerable<Models.Supplier> suppliers = supplierRepositry.GetSuppliers();
                return Ok(suppliers);
            }
            catch (Exception ex)
            {
                return BadRequest("Exception in getting data. " + ex.Message);
            }
        }

        [HttpPost("CreateSuppliers")]
        public IActionResult CreateSupplier()
        {
            try
            {
                var st = supplierRepositry.CreateSupplier(new Models.Supplier { Name = "Supplier 1 " + DateTime.Now.ToString("MMddhhmmss"), Phone= DateTime.Now.ToString("MMddhhmmss"), AccountRef = "asdfs", CreatedDate = DateTime.Now, AddressLine1 = "1 ASHDOWN CLOSE", Postcode = "B13 9ST", VatReg = "ASDF", Void = false });
                //var st = supplierRepositry.CreateSupplier(supplierData);
                return Ok(st);

            }
            catch (Exception ex)
            {
                return BadRequest("Exception in creating Supplier : " + ex.Message);
            }
        }
    }
}
