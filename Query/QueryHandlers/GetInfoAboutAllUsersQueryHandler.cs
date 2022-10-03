using ApplicationCore.Domain.Entities;
using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using Query.Queries;
using Query.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.QueryHandlers
{
    public class GetInfoAboutAllUsersQueryHandler : IRequestHandler<GetInfoAboutAllUsersQuery, List<AllUsersForAdminViewModel>>
    {
        private readonly ITypoRepository<User> _textRepository;
        private readonly IMapper _mapper;
        public GetInfoAboutAllUsersQueryHandler(ITypoRepository<User> textRepository, IMapper mapper)
        {
            this._textRepository = textRepository;
            this._mapper = mapper;
        }
        public Task<List<AllUsersForAdminViewModel>> Handle(GetInfoAboutAllUsersQuery request, CancellationToken cancellationToken)
        {
            var texts = _textRepository.GetAll().ToList();
            var result = _mapper.Map<List<AllUsersForAdminViewModel>>(texts);
            return Task.FromResult(result);
        }
    }
}
