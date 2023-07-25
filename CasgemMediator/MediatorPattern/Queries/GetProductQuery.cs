using CasgemMediator.MediatorPattern.Result;
using MediatR;

namespace CasgemMediator.MediatorPattern.Queries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {


    }
}
