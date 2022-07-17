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

        // GET: api/<PurchaseOrderController>
        [HttpGet]
        public IActionResult Get()
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

        // GET api/<PurchaseOrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PurchaseOrderController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
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

        // PUT api/<PurchaseOrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PurchaseOrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
