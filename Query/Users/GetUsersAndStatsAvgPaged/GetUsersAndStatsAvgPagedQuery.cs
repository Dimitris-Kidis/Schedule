using Query.Pagination;
using MediatR;

namespace Query.Users.GetUsersAndStatsAvgPaged
{
    public class GetUsersAndStatsAvgPagedQuery : IRequest<PaginatedResult<GetUsersAndStatsAvgPagedDto>>
    {
        public GetUsersAndStatsAvgPagedQuery()
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
