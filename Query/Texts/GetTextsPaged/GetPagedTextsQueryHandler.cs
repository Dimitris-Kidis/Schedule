using ApplicationCore.Domain.Entities;
using Query.Pagination;
using ApplicationCore.Services.Repository;
using AutoMapper;
using MediatR;
using Query.Pagination.Extensions;

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

            return await _textsRepository.GetAll().CreatePaginatedResultAsync<Text, PagedTextsDto>(req, _mapper);
        }
    }
}
