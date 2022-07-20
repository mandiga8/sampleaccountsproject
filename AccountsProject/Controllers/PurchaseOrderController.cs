using AccountsProject.Models;
using AccountsProject.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderRepository purchaseOrderRepository;

        public PurchaseOrderController(Repositories.IPurchaseOrderRepository purchaseOrderRepository)
        {
            this.purchaseOrderRepository = purchaseOrderRepository;
        }

        [HttpGet]
        [Route("GetPurchaseOrders")]
        public IActionResult GetPurchaseOrders()
        {
            try
            {
                var purchaseOrders = purchaseOrderRepository.GetPurchaseOrders();
                return Ok(purchaseOrders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetPurchaseOrder")]
        public IActionResult GetPurchaseOrder(int id)
        {
            try
            {
                return Ok(purchaseOrderRepository.GetPurchaseOrder(id));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("CreatePurchaseOrder")]
        public IActionResult CreatePurchaseOrder([FromBody] PurchaseOrder purchaseOrder)
        {
            try
            {
               return Ok(purchaseOrderRepository.CreatePurchaseOrder(new Models.PurchaseOrder { SupplierID = 1, CurrencyId= 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, PODate = DateTime.Now, SearchString = "tese", Source = "test", Status = "Pass", TotalGross = 23232, TotalNet = 39483, TotalVat = 332, Void = false }));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("UpdatePurchaseOrder")]
        public void UpdatePurchaseOrder(int id, [FromBody] string value)
        {
        }

        [HttpDelete]
        [Route("DeletePurchaseOrder")]
        public void DeletePurchaseOrder(int id)
        {
        }
    }
}
