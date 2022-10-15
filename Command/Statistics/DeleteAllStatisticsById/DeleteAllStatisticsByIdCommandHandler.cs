using ApplicationCore.Services.Repository;
using Command.Users.DeleteUserById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Statistics.DeleteAllStatisticsById
{
    public class DeleteAllStatisticsByIdCommandHandler : IRequestHandler<DeleteAllStatisticsByIdCommand, Unit>
    {
        private readonly ITypoRepository<ApplicationCore.Domain.Entities.Statistics> _statsRepository;
        public DeleteAllStatisticsByIdCommandHandler(ITypoRepository<ApplicationCore.Domain.Entities.Statistics> statsRepository)
        {
            this._statsRepository = statsRepository;
        }
        public Task<Unit> Handle(DeleteAllStatisticsByIdCommand request, CancellationToken cancellationToken)
        {
            var stats = _statsRepository.GetListWithInclude(x => x.UserId == request.Id);
            _statsRepository.DeleteRange(stats);
            _statsRepository.Save();

            return Task.FromResult(new Unit());
        }
    }
}
