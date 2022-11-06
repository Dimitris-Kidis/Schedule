using ApplicationCore.Domain.Entities;
using ApplicationCore.Pagination.PagedReq;
using ApplicationCore.Services.Repository;
using ApplicationCore.Services.Repository.UserRepository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Texts.GetTextsPaged
{
    public class GetPagedTextsQueryHandler : IRequestHandler<GetPagedTextsQuery, PaginatedResult<PagedTextsDto>>
    {
        private readonly ITypoRepository<Text> _textsRepository;
        private readonly IMapper _mapper;
        public GetPagedTextsQueryHandler(ITypoRepository<Text> textsRepository, IMapper mapper)
        {
            _textsRepository = textsRepository;
            _mapper = mapper;
        }
        public async Task<PaginatedResult<PagedTextsDto>> Handle(GetPagedTextsQuery request, CancellationToken cancellationToken)
        {
            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };
            var pagedTexts = await _textsRepository.GetPaged<Text, PagedTextsDto>(req);

            return pagedTexts;
        }
    }
}
