using Query.Pagination;
using MediatR;

namespace Query.Texts.GetTextsPaged
{
    public class GetPagedTextsQuery : IRequest<PaginatedResult<PagedTextsDto>>
    {
        public GetPagedTextsQuery()
        {
            RequestFilters = new RequestFilters();
        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public string ColumnNameForSorting { get; set; }

        public string SortDirection { get; set; }

        public RequestFilters RequestFilters { get; set; }
    }
}
