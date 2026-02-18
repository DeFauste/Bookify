using Domain.Abstractions;
using MediatR;

namespace Application.Abstractions.Messaging;

public interface IQueryHandle<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}