using ApplicationCore.Domain.Entities;
using ApplicationCore.Pagination.PagedReq;
using ApplicationCore.Services.Repository;
using ApplicationCore.Services.Repository.UserRepository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Users.GetUsersPaged
{
    
    public class GetPagedUsersQueryHandler : IRequestHandler<GetPagedUsersQuery, PaginatedResult<PagedUsersDto>>
    {
        private readonly IUserRepository<User> _usersRepository;
        private readonly ITypoRepository<Image> _imagesRepository;
        private readonly IMapper _mapper;
        public GetPagedUsersQueryHandler(IUserRepository<User> usersRepository, ITypoRepository<Image> imagesRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _imagesRepository = imagesRepository;
            _mapper = mapper;
        }
        public async Task<PaginatedResult<PagedUsersDto>> Handle(GetPagedUsersQuery request, CancellationToken cancellationToken)
        {
            var images = _imagesRepository.GetAll().ToListAsync(cancellationToken);
            PagedRequest req = new()
            {
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                ColumnNameForSorting = request.ColumnNameForSorting,
                SortDirection = request.SortDirection,
                RequestFilters = request.RequestFilters
            };
            var pagedUsers = await _usersRepository.GetPagedUsers<User, PagedUsersDto>(req);

            for (int i = 0; i < pagedUsers.Items.Count; i++)
            {
                pagedUsers.Items[i].Avatar = images.Result.Where(y => y.UserId == pagedUsers.Items[i].Id).Select(x => x.ImageTitle).LastOrDefault();
            }



            return pagedUsers;
        }
    }
}

