using Kalkulator.DataAccess;
using Kalkulator.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Kalkulator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentCategoryController : ControllerBase
    {
        private readonly IRepository<PaymentCategory> paymentCategoryRepository;
        public PaymentCategoryController(IRepository<PaymentCategory>paymentCategoryRepository) 
        {
            this.paymentCategoryRepository = paymentCategoryRepository;
        }
    [HttpGet]
    [Route("")]
    public IEnumerable<PaymentCategory> GetPayments() => this.paymentCategoryRepository.GetAll();
    
    
    }
}
