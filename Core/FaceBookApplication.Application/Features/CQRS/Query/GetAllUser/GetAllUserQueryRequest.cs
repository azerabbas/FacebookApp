using FaceBookApplication.Application.ViewModel;
using MediatR;

namespace FaceBookApplication.Application.Features.CQRS.Query.GetAllUser
{
    public class GetAllUserQueryRequest : IRequest<List<UserVM>>
    {

    }
}
