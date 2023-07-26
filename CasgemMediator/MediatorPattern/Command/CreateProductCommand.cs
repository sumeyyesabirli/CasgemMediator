using MediatR;

namespace CasgemMediator.MediatorPattern.Command
{
    public class CreateProductCommand:IRequest
    {
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
