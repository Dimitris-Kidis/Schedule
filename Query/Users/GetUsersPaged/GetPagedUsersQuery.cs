using ApplicationCore.Pagination.PagedReq;
using MediatR;

namespace Query.Users.GetUsersPaged
{
    public class GetPagedUsersQuery : IRequest<PaginatedResult<PagedUsersDto>>
    {
        public GetPagedUsersQuery()
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
