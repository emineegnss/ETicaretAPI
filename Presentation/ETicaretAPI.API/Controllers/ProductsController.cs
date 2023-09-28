using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id=customerId,Name="Muhititn" });
            //await _orderWriteRepository.AddRangeAsync(new()
            //{
            //    new(){Description="bla bla",Address="Ankara",CustomerId=customerId},
            //    new(){Description="bla 2",Address="Urfa",CustomerId = customerId},

            //});
            //Product p = await _productReadRepository.GetByIdAsync("2d37e846-9660-430f-b2ff-f999a33e1ee2");
            //p.Name = "Elif";
            //Order order = await _orderReadRepository.GetByIdAsync("5960a920-b5d8-4b34-b61b-01aec6427784");
            //order.Address = "İstanbul";
            //await _orderWriteRepository.SaveAsync();
            return Ok("merhaba");
        }
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(string id)
        //{
        //    Product product =await  _productReadRepository.GetByIdAsync(id);
        //    return Ok(product);
        //}

    }
}
