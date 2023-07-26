
using MediatR;

namespace CasgemMediator.MediatorPattern.Command
{
    public class RemoveProductCommand:IRequest
    {
        public RemoveProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
