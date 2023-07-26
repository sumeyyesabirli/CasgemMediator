using CasgemMediator.Dal;
using CasgemMediator.MediatorPattern.Command;
using CasgemMediator.MediatorPattern.Result;
using MediatR;

namespace CasgemMediator.MediatorPattern.Handler
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.Id);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
