using CasgemMediator.MediatorPattern.Command;
using CasgemMediator.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMediator.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetProductQuery());
            return View(values);
        }

        [HttpGet]

        public IActionResult AddProduct()
        {
            return View();
        } 
        [HttpPost]

        public  async Task<IActionResult> AddProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index"); 
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
    }
}
