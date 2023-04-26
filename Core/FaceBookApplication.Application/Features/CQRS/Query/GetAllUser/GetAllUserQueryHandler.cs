using AutoMapper;
using FaceBookApplication.Application.Repositories;
using FaceBookApplication.Application.ViewModel;
using FaceBookApplication.Domain.Entity;
using MediatR;
using System.Collections.Generic;

namespace FaceBookApplication.Application.Features.CQRS.Query.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, List<UserVM>>
    {
        private readonly IUoW _uoW;
        private readonly IMapper _mapper;
        public GetAllUserQueryHandler(IUoW uoW, IMapper mapper)
        {
            _uoW=uoW;
            _mapper=mapper;
        }

        public async Task<List<UserVM>> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<UserVM>>(_uoW.GetReadRepository<User>().GetAll());
           
        }
    }
}
